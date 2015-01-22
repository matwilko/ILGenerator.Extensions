using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static class NativeInteger
    {
        [PublicAPI]
        public static void LoadNativeIntegerFromAddress(this ILGenerator generator) => generator.Emit(OpCodes.Ldind_I);

        [PublicAPI]
        public static void StoreNativeIntegerFromStack(this ILGenerator generator) => generator.Emit(OpCodes.Stind_I);

        [PublicAPI]
        public static void StoreNativeIntegerElement(this ILGenerator generator) => generator.Emit(OpCodes.Stelem_I);

        [PublicAPI]
        public static void LoadNativeIntegerElement(this ILGenerator generator) => generator.Emit(OpCodes.Ldelem_I);

        [PublicAPI]
        public static void ConvertToNativeInteger(this ILGenerator generator) => generator.Emit(OpCodes.Conv_I);

        [PublicAPI]
        public static void ConvertToUnsignedNativeInteger(this ILGenerator generator) => generator.Emit(OpCodes.Conv_U);

        [PublicAPI]
        public static void ConvertToNativeIntegerWithOverflow(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_I);

        [PublicAPI]
        public static void ConvertToUnsignedNativeIntegerWithOverflow(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_U);
    }
}
