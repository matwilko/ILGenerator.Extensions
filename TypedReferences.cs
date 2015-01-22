using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static class TypedReferences
    {
        [PublicAPI]
        public static void MakeTypedReference(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Mkrefany, type);

        [PublicAPI]
        public static void MakeTypedReference<T>(this ILGenerator generator) => generator.MakeTypedReference(typeof (T));

        [PublicAPI]
        public static void GetTypeOfTypedReference(this ILGenerator generator) => generator.Emit(OpCodes.Refanytype);

        [PublicAPI]
        public static void GetAddressOfTypedReference(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Refanyval, type);

        [PublicAPI]
        public static void GetAddressOfTypedReference<T>(this ILGenerator generator) => generator.GetAddressOfTypedReference(typeof (T));
    }
}
