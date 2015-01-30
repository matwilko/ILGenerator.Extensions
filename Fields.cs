using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    public static partial class Fields
    {
        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the value of the given field for that object
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to load</param>
        [PublicAPI]
        public static void LoadField(this ILGenerator generator, FieldInfo field)
            => generator.Emit(field.IsStatic ? OpCodes.Ldsfld : OpCodes.Ldfld, field);

        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the value of the given field for that object, with volatile semantics
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to load</param>
        [PublicAPI]
        public static void LoadFieldVolatile(this ILGenerator generator, FieldInfo field)
        {
            generator.Emit(OpCodes.Volatile);
            generator.LoadField(field);
        }

        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the address of the given field for that object
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to load</param>
        [PublicAPI]
        public static void LoadFieldAddress(this ILGenerator generator, FieldInfo field)
        {
            generator.Emit(field.IsStatic ? OpCodes.Ldsflda : OpCodes.Ldflda, field);
        }

        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the address of the given field for that object, with volatile semantics
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to load</param>
        [PublicAPI]
        public static void LoadFieldAddressVolatile(this ILGenerator generator, FieldInfo field)
        {
            generator.Emit(OpCodes.Volatile);
            generator.LoadFieldAddress(field);
        }

        /// <summary>
        /// Pops a reference and a value from the evaluation stack and stores the value in the given field for that object
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
        [PublicAPI]
        public static void StoreInField(this ILGenerator generator, FieldInfo field)
            => generator.Emit(field.IsStatic ? OpCodes.Stsfld : OpCodes.Stfld, field);

        /// <summary>
        /// Pops a reference and a value from the evaluation stack and stores the value in the given field for that object, with volatile semantics
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
        [PublicAPI]
        public static void StoreInFieldVolatile(this ILGenerator generator, FieldInfo field)
        {
            generator.Emit(OpCodes.Volatile);
            generator.StoreInField(field);
        }
    }
}
