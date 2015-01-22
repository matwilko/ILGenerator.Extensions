using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    public static partial class Fields
    {
        [UsedImplicitly]
        public static void LoadField(this ILGenerator generator, FieldInfo field)
            => generator.Emit(field.IsStatic ? OpCodes.Ldsfld : OpCodes.Ldfld, field);

        [UsedImplicitly]
        public static void LoadFieldVolatile(this ILGenerator generator, FieldInfo field)
        {
            generator.Emit(OpCodes.Volatile);
            generator.LoadField(field);
        }

        [UsedImplicitly]
        public static void LoadFieldAddress(this ILGenerator generator, FieldInfo field)
        {
            generator.Emit(field.IsStatic ? OpCodes.Ldsflda : OpCodes.Ldflda, field);
        }

        [UsedImplicitly]
        public static void LoadFieldAddressVolatile(this ILGenerator generator, FieldInfo field)
        {
            generator.Emit(OpCodes.Volatile);
            generator.LoadFieldAddress(field);
        }

        [UsedImplicitly]
        public static void StoreInField(this ILGenerator generator, FieldInfo field)
            => generator.Emit(field.IsStatic ? OpCodes.Stsfld : OpCodes.Stfld, field);

        [UsedImplicitly]
        public static void StoreInFieldVolatile(this ILGenerator generator, FieldInfo field)
        {
            generator.Emit(OpCodes.Volatile);
            generator.StoreInField(field);
        }
    }
}
