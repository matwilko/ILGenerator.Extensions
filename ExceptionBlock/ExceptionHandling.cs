using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static class ExceptionHandling
    {
        /// <summary>
        /// Starts a protected region
        /// </summary>
        /// <param name="generator"></param>
        /// <returns>An <see cref="ExceptionBlock" /> instance from which the various exception handling blocks can be accessed</returns>
        [PublicAPI]
        public static ExceptionBlock ExceptionBlock(this ILGenerator generator) => new ExceptionBlock(generator);
    }
}
