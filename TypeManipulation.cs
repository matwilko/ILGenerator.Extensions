using System;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public static class TypeManipulation
    {
        public static void IsInstanceOfType<T>(this ILGenerator generator) => generator.IsInstanceOfType(typeof(T));

        public static void IsInstanceOfType(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Isinst, type);

        public static void CastClass(this ILGenerator generator, Type type)
        {
            if (type.IsValueType)
            {
                throw new InvalidOperationException("Cannot cast to a value type");
            }

            generator.Emit(OpCodes.Castclass, type);
        }

        public static void CastClass<T>(this ILGenerator generator) where T : class => generator.CastClass(typeof (T));

        public static void Box(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("Can only box value types");
            }

            generator.Emit(OpCodes.Box, type);
        }

        public static void Box<T>(this ILGenerator generator) where T : struct => generator.Box(typeof (T));

        public static void Unbox(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("Cannot unbox non-value types");
            }

            generator.Emit(OpCodes.Unbox, type);
        }

        public static void Unbox<T>(this ILGenerator generator) where T : struct => generator.Unbox(typeof (T));

        public static void UnboxAny(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Unbox_Any, type);

        public static void UnboxAny<T>(this ILGenerator generator) => generator.UnboxAny(typeof (T));

        public static void SizeOf(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Sizeof, type);

        public static void SizeOf<T>(this ILGenerator generator) => generator.SizeOf(typeof(T));
    }
}
