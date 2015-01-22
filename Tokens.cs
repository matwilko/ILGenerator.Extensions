using System;
using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static class Tokens
    {
        [PublicAPI]
        public static void LoadTokenFor(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Ldtoken, type);

        [PublicAPI]
        public static void LoadTokenFor<T>(this ILGenerator generator) => generator.Emit(OpCodes.Ldtoken, typeof (T));

        private static readonly MethodInfo GetTypeFromHandle = typeof (Type).GetMethod("GetTypeFromHandle");

        [PublicAPI]
        public static void TypeOf(this ILGenerator generator, Type type)
        {
            generator.LoadTokenFor(type);
            generator.Call(GetTypeFromHandle);
        }

        [PublicAPI]
        public static void TypeOf<T>(this ILGenerator generator) => generator.TypeOf(typeof (T));

        [PublicAPI]
        public static void LoadTokenFor(this ILGenerator generator, MethodInfo method) => generator.Emit(OpCodes.Ldtoken, method);
        
        private static readonly MethodInfo GetMethodFromHandle = typeof(MethodBase).GetMethod("GetMethodFromHandle", new [] { typeof(RuntimeMethodHandle) });

        [PublicAPI]
        public static void MethodInfoFor(this ILGenerator generator, MethodInfo method)
        {
            generator.LoadTokenFor(method);
            generator.Call(GetMethodFromHandle);
        }

        [PublicAPI]
        public static void LoadTokenFor(this ILGenerator generator, FieldInfo field) => generator.Emit(OpCodes.Ldtoken, field);

        private static readonly MethodInfo GetFieldFromHandle = typeof (FieldInfo).GetMethod("GetFieldFromHandle", new [] { typeof (RuntimeFieldHandle) });

        [PublicAPI]
        public static void FieldInfoFor(this ILGenerator generator, FieldInfo field)
        {
            generator.LoadTokenFor(field);
            generator.Call(GetFieldFromHandle);
        }
    }
}
