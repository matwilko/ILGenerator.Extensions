using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static class NativeInteger
    {
        /// <summary>
        /// Pops an address off the evaluation stack, loads a native integer from it and pushes it onto the evaluation stack 
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void LoadNativeIntegerFromAddress(this ILGenerator generator) => generator.Emit(OpCodes.Ldind_I);

        /// <summary>
        /// Pops an address and a native integer off the evaluation stack and stores the native integer at the address
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void StoreNativeIntegerFromStack(this ILGenerator generator) => generator.Emit(OpCodes.Stind_I);

        /// <summary>
        /// Pops an array reference, an array index and a native integer off the evaluation stack, storing it in the array at the index
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void StoreNativeIntegerElement(this ILGenerator generator) => generator.Emit(OpCodes.Stelem_I);

        /// <summary>
        /// Pops an array reference and an array index, pushing the native integer stored in the array at that index onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void LoadNativeIntegerElement(this ILGenerator generator) => generator.Emit(OpCodes.Ldelem_I);

        /// <summary>
        /// Pops an integer off the evaluation stack and pushes the equivalent native integer
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void ConvertToNativeInteger(this ILGenerator generator) => generator.Emit(OpCodes.Conv_I);

        /// <summary>
        /// Pops an integer off the evaluation stack and pushes the equivalent unsigned native integer
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void ConvertToUnsignedNativeInteger(this ILGenerator generator) => generator.Emit(OpCodes.Conv_U);

        /// <summary>
        /// Pops an integer off the evaluation stack and pushes the equivalent native integer, with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void ConvertToNativeIntegerWithOverflow(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_I);

        /// <summary>
        /// Pops an integer off the evaluation stack and pushes the equivalent unsigned native integer, with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void ConvertToUnsignedNativeIntegerWithOverflow(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_U);
    }
}
