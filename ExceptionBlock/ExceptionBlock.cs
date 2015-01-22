﻿using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    public sealed class ExceptionBlock : IDisposable
    {
        private readonly ILGenerator generator;
        private readonly Label endLabel;

        private bool tryBlockEnded;
        private bool hasCatchBlocks;
        private bool hasFinallyBlock;
        private bool hasFaultBlock;

        internal ExceptionBlock(ILGenerator generator)
        {
            this.generator = generator;
            endLabel = generator.DefineLabel();
            generator.BeginExceptionBlock();
        }

        [PublicAPI]
        public void Leave() => generator.Leave(endLabel);

        [PublicAPI]
        public void LeaveShortForm() => generator.LeaveShortForm(endLabel);

        private void EnsureTryBlockEnded()
        {
            if (tryBlockEnded)
            {
                return;
            }

            Leave();
            tryBlockEnded = true;
        }

        [PublicAPI]
        public CatchBlock CatchBlock()
        {
            return CatchBlock<object>();
        }

        [PublicAPI]
        public CatchBlock CatchBlock<T>()
        {
            return CatchBlock(typeof (T));
        }

        [PublicAPI]
        public CatchBlock CatchBlock(Type exceptionType)
        {
            return CatchBlock(exceptionType, null);
        }

        [PublicAPI]
        public CatchBlock CatchBlock(Action<ILGenerator> filter)
        {
            return CatchBlock(null, filter);
        }

        [PublicAPI]
        public CatchBlock CatchBlock<T>(Action<ILGenerator> filter)
        {
            return CatchBlock(typeof (T), filter);
        }

        [PublicAPI]
        public CatchBlock CatchBlock(Type exceptionType, Action<ILGenerator> filter)
        {
            EnsureTryBlockEnded();

            if (hasFinallyBlock)
            {
                throw new InvalidOperationException(
                    "Exception block already has a finally block - cannot start new catch block");
            }

            if (hasFaultBlock)
            {
                throw new InvalidOperationException(
                    "Exception block already has a fault block - cannot have both catch and fault blocks");
            }

            if (filter != null)
            {
                generator.BeginExceptFilterBlock();

                if (exceptionType != null)
                {
                    var filterBlockEnd = generator.DefineLabel();
                    var customFilter = generator.DefineLabel();
                    generator.Duplicate();
                    generator.IsInstanceOfType(exceptionType);
                    generator.BranchIfTrue(customFilter);

                    generator.Pop();
                    generator.LoadConstant(false);
                    generator.BranchTo(filterBlockEnd);

                    generator.MarkLabel(customFilter);
                    filter(generator);

                    generator.MarkLabel(filterBlockEnd);
                }
                else
                {
                    filter(generator);
                }

                generator.BeginCatchBlock(null);
            }
            else
            {
                generator.BeginCatchBlock(exceptionType);
            }

            hasCatchBlocks = true;

            return new CatchBlock(generator, endLabel);
        }

        [PublicAPI]
        public FaultBlock FaultBlock()
        {
            if (hasCatchBlocks)
            {
                throw new InvalidOperationException("Exception block already has catch blocks - cannot use both catch and fault block");
            }

            if (hasFaultBlock)
            {
                throw new InvalidOperationException("Exception block already has fault block");
            }

            if (hasFinallyBlock)
            {
                throw new InvalidOperationException(
                    "Exception block already has a finally block - cannot have both fault and finally - try nesting this exception block in another that has its own fault block");
            }

            EnsureTryBlockEnded();

            hasFaultBlock = true;

            generator.BeginFaultBlock();
            return new FaultBlock();
        }

        [PublicAPI]
        public FinallyBlock FinallyBlock()
        {
            if (hasFinallyBlock)
            {
                throw new InvalidOperationException("Exception block already has finally block");
            }

            if (hasFaultBlock)
            {
                throw new InvalidOperationException(
                    "Exception block already has a fault block - cannot have both fault and finally - try nesting this exception block in another that has its own finally block");
            }

            EnsureTryBlockEnded();

            hasFinallyBlock = true;

            generator.BeginFinallyBlock();
            return new FinallyBlock();
        }

        public void Dispose()
        {
            if (!tryBlockEnded)
            {
                EnsureTryBlockEnded();
                CatchBlock().Dispose(); // Suppress all errors and do nothing
            }

            generator.EndExceptionBlock();
            generator.MarkLabel(endLabel);
        }
    }
}
