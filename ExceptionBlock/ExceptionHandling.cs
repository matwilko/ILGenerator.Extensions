using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    /// <summary>
    /// Contains extension methods for creating protected regions
    /// </summary>
    [PublicAPI]
    public static class ExceptionHandling
    {
        /// <summary>
        /// Starts a protected region
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <returns>An <see cref="ExceptionBlock" /> instance from which the various exception handling blocks can be accessed</returns>
        [PublicAPI]
        public static ExceptionBlock ExceptionBlock(this ILGenerator generator) => new ExceptionBlock(generator);
    }
}
