using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    /// <summary>
    /// Contains extension methods for the manipulation of objects
    /// </summary>
    [PublicAPI]
    public static class ObjectManipulation
    {
        /// <summary>
        /// Pops two addresses from the evaluation stack and copies the value type object (of the given type) in the first into the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of the value type object</param>
        [PublicAPI]
        public static ILGenerator CopyObject(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("Copying a non-value-type results in unspecified runtime behaviour");
            }

            return generator.FluentEmit(OpCodes.Cpobj, type);
        }

        /// <summary>
        /// Pops two addresses from the evaluation stack and copies the value type object (of the given type) in the first into the second
        /// </summary>
        /// <typeparam name="T">The type of the value type object</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator CopyObject<T>(this ILGenerator generator) where T : struct => generator.CopyObject(typeof (T));
        
        /// <summary>
        /// Pops two addresses and an integer from the evaluation stack, and copies that number of bytes from the first address to the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator CopyBlock(this ILGenerator generator) => generator.FluentEmit(OpCodes.Cpblk);

        /// <summary>
        /// Pops two address from the evaluation stack and copies the given number of bytes from the first to the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="bytes">The number of bytes to copy</param>
        [PublicAPI]
        public static ILGenerator CopyBlock(this ILGenerator generator, uint bytes)
        {
            return generator.LoadConstant(bytes)
                            .CopyBlock();
        }

        /// <summary>
        /// Pops two addresses and an integer from the evaluation stack, and copies that number of bytes from the first address to the second, with volatile semantics
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator CopyBlockVolatile(this ILGenerator generator)
        {
            return generator.FluentEmit(OpCodes.Volatile)
                            .CopyBlock();
        }

        /// <summary>
        /// Pops two address from the evaluation stack and copies the given number of bytes from the first to the second, with volatile semantics
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="bytes">The number of bytes to copy</param>
        [PublicAPI]
        public static ILGenerator CopyBlockVolatile(this ILGenerator generator, uint bytes)
        {
            return generator.FluentEmit(OpCodes.Volatile)
                            .CopyBlock(bytes);
        }

        /// <summary>
        /// Pops an address from the evaluation stack and pushes the value type object (of the given type) at that location onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of the value type object</param>
        [PublicAPI]
        public static ILGenerator LoadValueTypeOntoStack(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("This operation is not valid on reference types");
            }

            if (type == typeof (sbyte))
            {
                return generator.FluentEmit(OpCodes.Ldind_I1);
            }
            else if (type == typeof (byte))
            {
                return generator.FluentEmit(OpCodes.Ldind_U1);
            }
            else if (type == typeof (short))
            {
                return generator.FluentEmit(OpCodes.Ldind_I2);
            }
            else if (type == typeof (ushort))
            {
                return generator.FluentEmit(OpCodes.Ldind_U2);
            }
            else if (type == typeof (int))
            {
                return generator.FluentEmit(OpCodes.Ldind_I4);
            }
            else if (type == typeof (uint))
            {
                return generator.FluentEmit(OpCodes.Ldind_U4);
            }
            else if (type == typeof(long) || type == typeof(ulong))
            {
                return generator.FluentEmit(OpCodes.Ldind_I8);
            }
            else if (type == typeof (float))
            {
                return generator.FluentEmit(OpCodes.Ldind_R4);
            }
            else if (type == typeof (double))
            {
                return generator.FluentEmit(OpCodes.Ldind_R8);
            }
            else
            {
                return generator.FluentEmit(OpCodes.Ldobj, type);
            }
        }

        /// <summary>
        /// Pops an address from the evaluation stack and pushes the value type object (of the given type) at that location onto the evaluation stack
        /// </summary>
        /// <typeparam name="T">The type of the value type object</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator LoadValueTypeOntoStack<T>(this ILGenerator generator) where T : struct
            => generator.LoadValueTypeOntoStack(typeof (T));

        /// <summary>
        /// Pops an address from the evaluation stack and pushes the value type object (of the given type) at that location onto the evaluation stack, with volatile semantics
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of the value type object</param>
        [PublicAPI]
        public static ILGenerator LoadValueTypeOntoStackVolatile(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("This operation is not valid on reference types");
            }

            return generator.FluentEmit(OpCodes.Volatile)
                            .LoadValueTypeOntoStack(type);
        }

        /// <summary>
        /// Pops an address from the evaluation stack and pushes the value type object (of the given type) at that location onto the evaluation stack, with volatile semantics
        /// </summary>
        /// <typeparam name="T">The type of the value type object</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator LoadValueTypeOntoStackVolatile<T>(this ILGenerator generator) where T : struct
            => generator.LoadValueTypeOntoStackVolatile(typeof(T));

        /// <summary>
        /// Pops an address and a value type object (of the given type) from the evaluation stack, and copies the object into the address
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of the value type object</param>
        [PublicAPI]
        public static ILGenerator StoreValueTypeFromStack(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("This operation is not valid on reference types");
            }

            if (type == typeof(sbyte) || type == typeof(byte))
            {
                return generator.FluentEmit(OpCodes.Ldind_I1);
            }
            else if (type == typeof(short) || type == typeof(ushort))
            {
                return generator.FluentEmit(OpCodes.Ldind_I2);
            }
            else if (type == typeof(int) || type == typeof(uint))
            {
                return generator.FluentEmit(OpCodes.Ldind_I4);
            }
            else if (type == typeof(long) || type == typeof(ulong))
            {
                return generator.FluentEmit(OpCodes.Ldind_I8);
            }
            else if (type == typeof(float))
            {
                return generator.FluentEmit(OpCodes.Ldind_R4);
            }
            else if (type == typeof(double))
            {
                return generator.FluentEmit(OpCodes.Ldind_R8);
            }
            else
            {
                return generator.FluentEmit(OpCodes.Ldobj, type);
            }
        }

        /// <summary>
        /// Pops an address and a value type object (of the given type) from the evaluation stack, and copies the object into the address
        /// </summary>
        /// <typeparam name="T">The type of the value type object</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator StoreValueTypeFromStack<T>(this ILGenerator generator) where T : struct
            => generator.StoreValueTypeFromStack(typeof (T));

        /// <summary>
        /// Pops an address and a value type object (of the given type) from the evaluation stack, and copies the object into the address, with volatile semantics
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of the value type object</param>
        [PublicAPI]
        public static ILGenerator StoreValueTypeFromStackVolatile(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("This operation is not valid on a reference type");
            }

            return generator.FluentEmit(OpCodes.Volatile)
                            .FluentEmit(OpCodes.Stobj, type);
        }

        /// <summary>
        /// Pops an address and a value type object (of the given type) from the evaluation stack, and copies the object into the address, with volatile semantics
        /// </summary>
        /// <typeparam name="T">The type of the value type object</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator StoreValueTypeFromStackVolatile<T>(this ILGenerator generator) where T : struct
            => generator.StoreValueTypeFromStack(typeof(T));

        /// <summary>
        /// Pops an address from the evaluation stack, and pushes the object reference located at that address
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator LoadReferenceFromAddress(this ILGenerator generator) => generator.FluentEmit(OpCodes.Ldind_Ref);
    }
}
