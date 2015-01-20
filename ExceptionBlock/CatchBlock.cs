using System;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public class CatchBlock : IDisposable
    {
        private readonly ILGenerator generator;
        private readonly Label endLabel;

        internal CatchBlock(ILGenerator generator, Label endLabel)
        {
            this.generator = generator;
            this.endLabel = endLabel;
        }

        public void Rethrow() => generator.Emit(OpCodes.Rethrow);

        public void Leave() => generator.Leave(endLabel);
        
        public void Dispose()
        {
        }
    }
}