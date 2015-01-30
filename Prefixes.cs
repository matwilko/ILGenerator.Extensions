using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static class Prefixes
    {
        /// <summary>
        /// Indicates that the next operation should not assume that its arguments are properly aligned
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void Unaligned(this ILGenerator generator) => generator.Emit(OpCodes.Unaligned);
    }
}
