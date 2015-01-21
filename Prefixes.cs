using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public static class Prefixes
    {
        public static void Unaligned(this ILGenerator generator) => generator.Emit(OpCodes.Unaligned);
    }
}
