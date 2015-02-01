using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    /// <summary>
    /// Contains extension methods for creating and manipulating typed references
    /// </summary>
    [PublicAPI]
    public static class TypedReferences
    {
        /// <summary>
        /// Pops a pointer to a piece of data off the evaluation stack and pushes a typed reference (of the given type)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of the resulting reference</param>
        [PublicAPI]
        public static ILGenerator MakeTypedReference(this ILGenerator generator, Type type) => generator.FluentEmit(OpCodes.Mkrefany, type);

        /// <summary>
        /// Pops a pointer to a piece of data off the evaluation stack and pushes a typed reference (of the given type)
        /// </summary>
        /// <typeparam name="T">The type of the resulting reference</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator MakeTypedReference<T>(this ILGenerator generator) => generator.MakeTypedReference(typeof (T));

        /// <summary>
        /// Pops a typed reference from the evaluation stack and pushes the type token of its type
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator GetTypeOfTypedReference(this ILGenerator generator) => generator.FluentEmit(OpCodes.Refanytype);

        /// <summary>
        /// Pops a typed reference (of the given type) from the evaluation stack and pushes the address of the reference
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of the reference</param>
        [PublicAPI]
        public static ILGenerator GetAddressOfTypedReference(this ILGenerator generator, Type type) => generator.FluentEmit(OpCodes.Refanyval, type);

        /// <summary>
        /// Pops a typed reference (of the given type) from the evaluation stack and pushes the address of the reference
        /// </summary>
        /// <typeparam name="T">The type of the reference</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator GetAddressOfTypedReference<T>(this ILGenerator generator) => generator.GetAddressOfTypedReference(typeof (T));
    }
}
