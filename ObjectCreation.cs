using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public static class ObjectCreation
    {
        public static void NewObject(this ILGenerator generator, ConstructorInfo constructor) => generator.Emit(OpCodes.Newobj, constructor);

        public static void NewObject<T>(this ILGenerator generator) where T : class, new() => generator.Emit(OpCodes.Newobj, typeof (T).GetConstructor(Type.EmptyTypes));
    }
}
