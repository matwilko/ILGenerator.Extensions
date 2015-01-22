using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    public sealed class CatchBlock : IDisposable
    {
        private readonly ILGenerator generator;
        private readonly Label endLabel;

        internal CatchBlock(ILGenerator generator, Label endLabel)
        {
            this.generator = generator;
            this.endLabel = endLabel;
        }

        [PublicAPI]
        public void Rethrow() => generator.Emit(OpCodes.Rethrow);

        [PublicAPI]
        public void Leave() => generator.Leave(endLabel);
        
        public void Dispose()
        {
        }
    }
}