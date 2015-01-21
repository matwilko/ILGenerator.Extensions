using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public static class NativeInteger
    {
        public static void LoadNativeIntegerFromAddress(this ILGenerator generator) => generator.Emit(OpCodes.Ldind_I);

        public static void StoreNativeIntegerFromStack(this ILGenerator generator) => generator.Emit(OpCodes.Stind_I);

        public static void StoreNativeIntegerElement(this ILGenerator generator) => generator.Emit(OpCodes.Stelem_I);

        public static void LoadNativeIntegerElement(this ILGenerator generator) => generator.Emit(OpCodes.Ldelem_I);

        public static void ConvertToNativeInteger(this ILGenerator generator) => generator.Emit(OpCodes.Conv_I);

        public static void ConvertToUnsignedNativeInteger(this ILGenerator generator) => generator.Emit(OpCodes.Conv_U);

        public static void ConvertToNativeIntegerWithOverflow(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_I);

        public static void ConvertToUnsignedNativeIntegerWithOverflow(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_U);
    }
}
