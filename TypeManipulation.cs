using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static class TypeManipulation
    {
        [PublicAPI]
        public static void IsInstanceOfType<T>(this ILGenerator generator) => generator.IsInstanceOfType(typeof(T));

        [PublicAPI]
        public static void IsInstanceOfType(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Isinst, type);

        [PublicAPI]
        public static void CastClass(this ILGenerator generator, Type type)
        {
            if (type.IsValueType)
            {
                throw new InvalidOperationException("Cannot cast to a value type");
            }

            generator.Emit(OpCodes.Castclass, type);
        }

        [PublicAPI]
        public static void CastClass<T>(this ILGenerator generator) where T : class => generator.CastClass(typeof (T));

        [PublicAPI]
        public static void Box(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("Can only box value types");
            }

            generator.Emit(OpCodes.Box, type);
        }

        [PublicAPI]
        public static void Box<T>(this ILGenerator generator) where T : struct => generator.Box(typeof (T));

        [PublicAPI]
        public static void Unbox(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("Cannot unbox non-value types");
            }

            generator.Emit(OpCodes.Unbox, type);
        }

        [PublicAPI]
        public static void Unbox<T>(this ILGenerator generator) where T : struct => generator.Unbox(typeof (T));

        [PublicAPI]
        public static void UnboxAny(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Unbox_Any, type);

        [PublicAPI]
        public static void UnboxAny<T>(this ILGenerator generator) => generator.UnboxAny(typeof (T));

        [PublicAPI]
        public static void SizeOf(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Sizeof, type);

        [PublicAPI]
        public static void SizeOf<T>(this ILGenerator generator) => generator.SizeOf(typeof(T));
    }
}
