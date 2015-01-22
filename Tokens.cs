using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public static class Tokens
    {
        public static void LoadTokenFor(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Ldtoken, type);

        public static void LoadTokenFor<T>(this ILGenerator generator) => generator.Emit(OpCodes.Ldtoken, typeof (T));

        private static readonly MethodInfo GetTypeFromHandle = typeof (Type).GetMethod("GetTypeFromHandle");

        public static void TypeOf(this ILGenerator generator, Type type)
        {
            generator.LoadTokenFor(type);
            generator.Call(GetTypeFromHandle);
        }

        public static void TypeOf<T>(this ILGenerator generator) => generator.TypeOf(typeof (T));

        public static void LoadTokenFor(this ILGenerator generator, MethodInfo method) => generator.Emit(OpCodes.Ldtoken, method);
        
        private static readonly MethodInfo GetMethodFromHandle = typeof(MethodBase).GetMethod("GetMethodFromHandle", new [] { typeof(RuntimeMethodHandle) });

        public static void MethodInfoFor(this ILGenerator generator, MethodInfo method)
        {
            generator.LoadTokenFor(method);
            generator.Call(GetMethodFromHandle);
        }

        public static void LoadTokenFor(this ILGenerator generator, FieldInfo field) => generator.Emit(OpCodes.Ldtoken, field);

        private static readonly MethodInfo GetFieldFromHandle = typeof (FieldInfo).GetMethod("GetFieldFromHandle", new [] { typeof (RuntimeFieldHandle) });

        public static void FieldInfoFor(this ILGenerator generator, FieldInfo field)
        {
            generator.LoadTokenFor(field);
            generator.Call(GetFieldFromHandle);
        }
    }
}
