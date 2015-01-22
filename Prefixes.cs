using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [UsedImplicitly]
    public static class Prefixes
    {
        [UsedImplicitly]
        public static void Unaligned(this ILGenerator generator) => generator.Emit(OpCodes.Unaligned);
    }
}
