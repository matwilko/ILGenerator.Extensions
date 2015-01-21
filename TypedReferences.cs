using System;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public static class TypedReferences
    {
        public static void MakeTypedReference(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Mkrefany, type);

        public static void MakeTypedReference<T>(this ILGenerator generator) => generator.MakeTypedReference(typeof (T));

        public static void GetTypeOfTypedReference(this ILGenerator generator) => generator.Emit(OpCodes.Refanytype);

        public static void GetAddressOfTypedReference(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Refanyval, type);

        public static void GetAddressOfTypedReference<T>(this ILGenerator generator) => generator.GetAddressOfTypedReference(typeof (T));
    }
}
