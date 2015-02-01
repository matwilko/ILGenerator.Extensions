using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    /// <summary>
    /// Contains extension methods that emit instruction prefixes
    /// </summary>
    [PublicAPI]
    public static class Prefixes
    {
        /// <summary>
        /// Indicates that the next operation should not assume that its arguments are properly aligned
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator Unaligned(this ILGenerator generator) => generator.FluentEmit(OpCodes.Unaligned);
    }
}
