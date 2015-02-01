using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    /// <summary>
    /// Contains extension methods for performing arithmetic operations on integers and floating point values
    /// </summary>
    public static partial class ArithmeticOperations
    {
        /// <summary>
        /// Negates the integer value on the top of the evaluation stack, with no overflow check
        /// </summary>
        /// <remarks>
        /// If you need to check for overflow (as in the case of int.MinValue), you need to subtract the value from 0 instead.
        /// </remarks>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator Negate(this ILGenerator generator) => generator.FluentEmit(OpCodes.Neg);
    }
}
