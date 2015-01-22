using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [UsedImplicitly]
    public static class TypedReferences
    {
        [UsedImplicitly]
        public static void MakeTypedReference(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Mkrefany, type);

        [UsedImplicitly]
        public static void MakeTypedReference<T>(this ILGenerator generator) => generator.MakeTypedReference(typeof (T));

        [UsedImplicitly]
        public static void GetTypeOfTypedReference(this ILGenerator generator) => generator.Emit(OpCodes.Refanytype);

        [UsedImplicitly]
        public static void GetAddressOfTypedReference(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Refanyval, type);

        [UsedImplicitly]
        public static void GetAddressOfTypedReference<T>(this ILGenerator generator) => generator.GetAddressOfTypedReference(typeof (T));
    }
}
