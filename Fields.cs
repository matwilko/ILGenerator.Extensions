using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    public static partial class Fields
    {
        [PublicAPI]
        public static void LoadField(this ILGenerator generator, FieldInfo field)
            => generator.Emit(field.IsStatic ? OpCodes.Ldsfld : OpCodes.Ldfld, field);

        [PublicAPI]
        public static void LoadFieldVolatile(this ILGenerator generator, FieldInfo field)
        {
            generator.Emit(OpCodes.Volatile);
            generator.LoadField(field);
        }

        [PublicAPI]
        public static void LoadFieldAddress(this ILGenerator generator, FieldInfo field)
        {
            generator.Emit(field.IsStatic ? OpCodes.Ldsflda : OpCodes.Ldflda, field);
        }

        [PublicAPI]
        public static void LoadFieldAddressVolatile(this ILGenerator generator, FieldInfo field)
        {
            generator.Emit(OpCodes.Volatile);
            generator.LoadFieldAddress(field);
        }

        [PublicAPI]
        public static void StoreInField(this ILGenerator generator, FieldInfo field)
            => generator.Emit(field.IsStatic ? OpCodes.Stsfld : OpCodes.Stfld, field);

        [PublicAPI]
        public static void StoreInFieldVolatile(this ILGenerator generator, FieldInfo field)
        {
            generator.Emit(OpCodes.Volatile);
            generator.StoreInField(field);
        }
    }
}
