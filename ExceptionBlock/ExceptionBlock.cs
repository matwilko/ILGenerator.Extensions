﻿using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    /// <summary>
    /// Represents a protected region
    /// </summary>
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

        /// <summary>
        /// Jumps to the instruction immediately after this protected region (after any finally block executes)
        /// </summary>
        [PublicAPI]
        public ILGenerator Leave() => generator.Leave(endLabel);

        /// <summary>
        /// Jumps to the instruction immediately after this protected region (after any finally block executes)
        /// </summary>
        [PublicAPI]
        public ILGenerator LeaveShortForm() => generator.LeaveShortForm(endLabel);

        private void EnsureTryBlockEnded()
        {
            if (tryBlockEnded)
            {
                return;
            }

            Leave();
            tryBlockEnded = true;
        }

        /// <summary>
        /// Starts a new catch block which handles exceptions of any type
        /// </summary>
        [PublicAPI]
        public CatchBlock CatchBlock()
        {
            return CatchBlock<object>();
        }

        /// <summary>
        /// Starts a new catch block which handles exceptions of the given type
        /// </summary>
        /// <typeparam name="T">The type of exception this catch block should handle</typeparam>
        [PublicAPI]
        public CatchBlock CatchBlock<T>()
        {
            return CatchBlock(typeof (T));
        }

        /// <summary>
        /// Starts a new catch block which handles exceptions of the given type
        /// </summary>
        /// <param name="exceptionType">The type of exception this catch block should handle</param>
        [PublicAPI]
        public CatchBlock CatchBlock(Type exceptionType)
        {
            return CatchBlock(exceptionType, null);
        }

        /// <summary>
        /// Starts a new catch block which handles exceptions based on the filter created by the given action
        /// </summary>
        /// <param name="filter">An action that writes the IL comprising the filter block</param>
        [PublicAPI]
        public CatchBlock CatchBlock(Action<ILGenerator> filter)
        {
            return CatchBlock(null, filter);
        }

        /// <summary>
        /// Starts a new catch block which handles exceptions of the given type based on the filter created by the given action
        /// </summary>
        /// <typeparam name="T">The type of exception this catch block should handle</typeparam>
        /// <param name="filter">An action that writes the IL comprising the filter block</param>
        [PublicAPI]
        public CatchBlock CatchBlock<T>(Action<ILGenerator> filter)
        {
            return CatchBlock(typeof (T), filter);
        }

        /// <summary>
        /// Starts a new catch block which handles exceptions of the given type based on the filter created by the given action
        /// </summary>
        /// <param name="exceptionType">The type of exception this catch block should handle</param>
        /// <param name="filter">An action that writes the IL comprising the filter block</param>
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

                    generator
                        .Duplicate()
                        .IsInstanceOfType(exceptionType)
                        .BranchIfTrue(customFilter)

                        .Pop()
                        .LoadConstant(false)
                        .BranchTo(filterBlockEnd);

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

        /// <summary>
        /// Starts a fault block
        /// </summary>
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

        /// <summary>
        /// Starts a finally block
        /// </summary>
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

        /// <summary>
        /// Ends the current protected region - if no exception handling blocks have been specified, a catch block that suppresses all exceptions is emitted
        /// </summary>
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
