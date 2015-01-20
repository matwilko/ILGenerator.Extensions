using System;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public static class TypeManipulation
    {
        public static void IsInstanceOfType<T>(this ILGenerator generator) => generator.IsInstanceOfType(typeof(T));

        public static void IsInstanceOfType(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Isinst, type);
    }
}
