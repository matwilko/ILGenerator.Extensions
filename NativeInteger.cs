using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [UsedImplicitly]
    public static class NativeInteger
    {
        [UsedImplicitly]
        public static void LoadNativeIntegerFromAddress(this ILGenerator generator) => generator.Emit(OpCodes.Ldind_I);

        [UsedImplicitly]
        public static void StoreNativeIntegerFromStack(this ILGenerator generator) => generator.Emit(OpCodes.Stind_I);

        [UsedImplicitly]
        public static void StoreNativeIntegerElement(this ILGenerator generator) => generator.Emit(OpCodes.Stelem_I);

        [UsedImplicitly]
        public static void LoadNativeIntegerElement(this ILGenerator generator) => generator.Emit(OpCodes.Ldelem_I);

        [UsedImplicitly]
        public static void ConvertToNativeInteger(this ILGenerator generator) => generator.Emit(OpCodes.Conv_I);

        [UsedImplicitly]
        public static void ConvertToUnsignedNativeInteger(this ILGenerator generator) => generator.Emit(OpCodes.Conv_U);

        [UsedImplicitly]
        public static void ConvertToNativeIntegerWithOverflow(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_I);

        [UsedImplicitly]
        public static void ConvertToUnsignedNativeIntegerWithOverflow(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_U);
    }
}
