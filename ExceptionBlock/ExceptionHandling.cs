using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static class ExceptionHandling
    {
        [PublicAPI]
        public static ExceptionBlock ExceptionBlock(this ILGenerator generator) => new ExceptionBlock(generator);
    }
}
