using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public static class ExceptionHandling
    {
        public static ExceptionBlock.ExceptionBlock ExceptionBlock(this ILGenerator generator) => new ExceptionBlock.ExceptionBlock(generator);
    }
}
