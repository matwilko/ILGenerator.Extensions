using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    /// <summary>
    /// Represents a catch block in a protected region
    /// </summary>
    public sealed class CatchBlock : IDisposable
    {
        private readonly ILGenerator generator;
        private readonly Label endLabel;

        internal CatchBlock(ILGenerator generator, Label endLabel)
        {
            this.generator = generator;
            this.endLabel = endLabel;
        }

        /// <summary>
        /// Rethrows the exception caught by this catch block
        /// </summary>
        [PublicAPI]
        public ILGenerator Rethrow() => generator.FluentEmit(OpCodes.Rethrow);

        /// <summary>
        /// Jumps to the instruction immediately after this protected region (after any finally block executes)
        /// </summary>
        [PublicAPI]
        public ILGenerator Leave() => generator.Leave(endLabel);
        
        /// <summary>
        /// End the catch block
        /// </summary>
        public void Dispose()
        {
        }
    }
}