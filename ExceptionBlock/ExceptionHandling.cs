using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [UsedImplicitly]
    public static class ExceptionHandling
    {
        [UsedImplicitly]
        public static ExceptionBlock ExceptionBlock(this ILGenerator generator) => new ExceptionBlock(generator);
    }
}
