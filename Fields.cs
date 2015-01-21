using System.Reflection;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public static partial class Fields
    {
        public static void LoadField(this ILGenerator generator, FieldInfo field)
            => generator.Emit(field.IsStatic ? OpCodes.Ldsfld : OpCodes.Ldfld, field);

        public static void LoadFieldVolatile(this ILGenerator generator, FieldInfo field)
        {
            generator.Emit(OpCodes.Volatile);
            generator.LoadField(field);
        }

        public static void LoadFieldAddress(this ILGenerator generator, FieldInfo field)
        {
            generator.Emit(field.IsStatic ? OpCodes.Ldsflda : OpCodes.Ldflda, field);
        }

        public static void LoadFieldAddressVolatile(this ILGenerator generator, FieldInfo field)
        {
            generator.Emit(OpCodes.Volatile);
            generator.LoadFieldAddress(field);
        }

        public static void StoreInField(this ILGenerator generator, FieldInfo field)
            => generator.Emit(field.IsStatic ? OpCodes.Stsfld : OpCodes.Stfld, field);

        public static void StoreInFieldVolatile(this ILGenerator generator, FieldInfo field)
        {
            generator.Emit(OpCodes.Volatile);
            generator.StoreInField(field);
        }
    }
}
