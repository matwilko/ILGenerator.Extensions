using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static class Prefixes
    {
        [PublicAPI]
        public static void Unaligned(this ILGenerator generator) => generator.Emit(OpCodes.Unaligned);
    }
}
