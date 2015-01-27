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
        /// <param name="generator"></param>
        [PublicAPI]
        public static void Unaligned(this ILGenerator generator) => generator.Emit(OpCodes.Unaligned);
    }
}
