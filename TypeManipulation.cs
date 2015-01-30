﻿using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static class TypeManipulation
    {
        /// <summary>
        /// Pops a reference from the execution stack, and pushes a reference of the given type if the object is an instance of that type, otherwise the null reference is pushed
        /// </summary>
        /// <typeparam name="T">The type to attempt to cast to</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void IsInstanceOfType<T>(this ILGenerator generator) => generator.IsInstanceOfType(typeof(T));

        /// <summary>
        /// Pops a reference from the execution stack, and pushes a reference of the given type if the object is an instance of the given type, otherwise the null reference is pushed
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type to attempt to cast to</param>
        [PublicAPI]
        public static void IsInstanceOfType(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Isinst, type);

        /// <summary>
        /// Pops a reference from the execution stack, and pushes a reference of the given type if the object is an instance of that type, otherwise an <see cref="InvalidCastException" /> is thrown
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type to attempt to cast to</param>
        [PublicAPI]
        public static void CastClass(this ILGenerator generator, Type type)
        {
            if (type.IsValueType)
            {
                throw new InvalidOperationException("Cannot cast to a value type");
            }

            generator.Emit(OpCodes.Castclass, type);
        }

        /// <summary>
        /// Pops a reference from the execution stack, and pushes a reference of the given type if the object is an instance of that type, otherwise an <see cref="InvalidCastException" /> is thrown
        /// </summary>
        /// <typeparam name="T">The type to attempt to cast to</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void CastClass<T>(this ILGenerator generator) where T : class => generator.CastClass(typeof (T));

        /// <summary>
        /// Pops a value type object from the execution stack, and pushes a reference to a new boxed instance of the object onto the execution stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of the value type object</param>
        [PublicAPI]
        public static void Box(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("Can only box value types");
            }

            generator.Emit(OpCodes.Box, type);
        }

        /// <summary>
        /// Pops a value type object from the execution stack, and pushes a reference to a new boxed instance of the object onto the execution stack
        /// </summary>
        /// <typeparam name="T">The type of the value type object</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void Box<T>(this ILGenerator generator) where T : struct => generator.Box(typeof (T));

        /// <summary>
        /// Pops a reference from the execution stack, and pushes the address of the boxed value type of the given type
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of the boxed value type</param>
        [PublicAPI]
        public static void Unbox(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("Cannot unbox non-value types");
            }

            generator.Emit(OpCodes.Unbox, type);
        }

        /// <summary>
        /// Pops a reference from the execution stack, and pushes the address of the boxed value type of the given type
        /// </summary>
        /// <typeparam name="T">The type of the boxed value type</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void Unbox<T>(this ILGenerator generator) where T : struct => generator.Unbox(typeof (T));

        /// <summary>
        /// Pops a reference from the execution stack, and pushes the value type object if the object is a boxed value type, or a reference of the given type if the object is a reference type and is an instance of that type
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type to unbox to</param>
        [PublicAPI]
        public static void UnboxAny(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Unbox_Any, type);

        /// <summary>
        /// Pops a reference from the execution stack, and pushes the value type object if the object is a boxed value type, or a reference of the given type if the object is a reference type and is an instance of that type
        /// </summary>
        /// <typeparam name="T">The type to unbox to</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void UnboxAny<T>(this ILGenerator generator) => generator.UnboxAny(typeof (T));

        /// <summary>
        /// Pushes the number of bytes required to store the given type, for reference types this will always be the size of a reference, not the size of an object of that type itself
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type to get the size of</param>
        [PublicAPI]
        public static void SizeOf(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Sizeof, type);

        /// <summary>
        /// Pushes the number of bytes required to store the given type, for reference types this will always be the size of a reference, not the size of an object of that type itself
        /// </summary>
        /// <typeparam name="T">The type to get the size of</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void SizeOf<T>(this ILGenerator generator) => generator.SizeOf(typeof(T));
    }
}
