using System;
using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    /// <summary>
    /// Contains extension methods for manipulation of type, method and field tokens
    /// </summary>
    [PublicAPI]
    public static class Tokens
    {
        /// <summary>
        /// Pushes the token for the given type onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type to load the token of</param>
        [PublicAPI]
        public static ILGenerator LoadTokenFor(this ILGenerator generator, Type type) => generator.FluentEmit(OpCodes.Ldtoken, type);

        /// <summary>
        /// Pushes the token for the given type onto the evaluation stack
        /// </summary>
        /// <typeparam name="T">The type to load the token of</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator LoadTokenFor<T>(this ILGenerator generator) => generator.FluentEmit(OpCodes.Ldtoken, typeof (T));

        private static readonly MethodInfo GetTypeFromHandle = typeof (Type).GetMethod("GetTypeFromHandle");

        /// <summary>
        /// Pushes the <see cref="Type" /> of the given type onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type to load the <see cref="Type" /> of</param>
        [PublicAPI]
        public static ILGenerator TypeOf(this ILGenerator generator, Type type)
        {
            return generator.LoadTokenFor(type)
                            .Call(GetTypeFromHandle);
        }

        /// <summary>
        /// Pushes the <see cref="Type" /> of the given type onto the evaluation stack
        /// </summary>
        /// <typeparam name="T">The type to load the <see cref="Type" /> of</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator TypeOf<T>(this ILGenerator generator) => generator.TypeOf(typeof (T));

        /// <summary>
        /// Pushes the token for the given method onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="method">The method to load the token of</param>
        [PublicAPI]
        public static ILGenerator LoadTokenFor(this ILGenerator generator, MethodInfo method) => generator.FluentEmit(OpCodes.Ldtoken, method);
        
        private static readonly MethodInfo GetMethodFromHandle = typeof(MethodBase).GetMethod("GetMethodFromHandle", new [] { typeof(RuntimeMethodHandle) });

        /// <summary>
        /// Pushes the <see cref="MethodInfo" /> of the given method onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="method">The method to load the <see cref="MethodInfo" /> of</param>
        [PublicAPI]
        public static ILGenerator MethodInfoFor(this ILGenerator generator, MethodInfo method)
        {
            return generator.LoadTokenFor(method)
                            .Call(GetMethodFromHandle);
        }

        /// <summary>
        /// Pushes the token for the given field onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="field">The field to load the token of</param>
        [PublicAPI]
        public static ILGenerator LoadTokenFor(this ILGenerator generator, FieldInfo field) => generator.FluentEmit(OpCodes.Ldtoken, field);

        private static readonly MethodInfo GetFieldFromHandle = typeof (FieldInfo).GetMethod("GetFieldFromHandle", new [] { typeof (RuntimeFieldHandle) });

        /// <summary>
        /// Pushes the <see cref="FieldInfo" /> of the given field onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="field">The field to load the <see cref="FieldInfo" /> of</param>
        [PublicAPI]
        public static ILGenerator FieldInfoFor(this ILGenerator generator, FieldInfo field)
        {
            return generator.LoadTokenFor(field)
                            .Call(GetFieldFromHandle);
        }
    }
}
