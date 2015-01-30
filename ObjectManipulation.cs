using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static class ObjectManipulation
    {
        /// <summary>
        /// Pops two addresses from the execution stack and copies the value type object (of the given type) in the first into the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of the value type object</param>
        [PublicAPI]
        public static void CopyObject(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("Copying a non-value-type results in unspecified runtime behaviour");
            }

            generator.Emit(OpCodes.Cpobj, type);
        }

        /// <summary>
        /// Pops two addresses from the execution stack and copies the value type object (of the given type) in the first into the second
        /// </summary>
        /// <typeparam name="T">The type of the value type object</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void CopyObject<T>(this ILGenerator generator) where T : struct => generator.CopyObject(typeof (T));
        
        /// <summary>
        /// Pops two addresses and an integer from the execution stack, and copies that number of bytes from the first address to the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void CopyBlock(this ILGenerator generator) => generator.Emit(OpCodes.Cpblk);

        /// <summary>
        /// Pops two address from the execution stack and copies the given number of bytes from the first to the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="bytes">The number of bytes to copy</param>
        [PublicAPI]
        public static void CopyBlock(this ILGenerator generator, uint bytes)
        {
            generator.LoadConstant(bytes);
            generator.CopyBlock();
        }

        /// <summary>
        /// Pops two addresses and an integer from the execution stack, and copies that number of bytes from the first address to the second, with volatile semantics
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void CopyBlockVolatile(this ILGenerator generator)
        {
            generator.Emit(OpCodes.Volatile);
            generator.CopyBlock();
        }

        /// <summary>
        /// Pops two address from the execution stack and copies the given number of bytes from the first to the second, with volatile semantics
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="bytes">The number of bytes to copy</param>
        [PublicAPI]
        public static void CopyBlockVolatile(this ILGenerator generator, uint bytes)
        {
            generator.Emit(OpCodes.Volatile);
            generator.CopyBlock(bytes);
        }

        /// <summary>
        /// Pops an address from the execution stack and pushes the value type object (of the given type) at that location onto the execution stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of the value type object</param>
        [PublicAPI]
        public static void LoadValueTypeOntoStack(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("This operation is not valid on reference types");
            }

            if (type == typeof (sbyte))
            {
                generator.Emit(OpCodes.Ldind_I1);
            }
            else if (type == typeof (byte))
            {
                generator.Emit(OpCodes.Ldind_U1);
            }
            else if (type == typeof (short))
            {
                generator.Emit(OpCodes.Ldind_I2);
            }
            else if (type == typeof (ushort))
            {
                generator.Emit(OpCodes.Ldind_U2);
            }
            else if (type == typeof (int))
            {
                generator.Emit(OpCodes.Ldind_I4);
            }
            else if (type == typeof (uint))
            {
                generator.Emit(OpCodes.Ldind_U4);
            }
            else if (type == typeof(long) || type == typeof(ulong))
            {
                generator.Emit(OpCodes.Ldind_I8);
            }
            else if (type == typeof (float))
            {
                generator.Emit(OpCodes.Ldind_R4);
            }
            else if (type == typeof (double))
            {
                generator.Emit(OpCodes.Ldind_R8);
            }
            else
            {
                generator.Emit(OpCodes.Ldobj, type);
            }
        }

        /// <summary>
        /// Pops an address from the execution stack and pushes the value type object (of the given type) at that location onto the execution stack
        /// </summary>
        /// <typeparam name="T">The type of the value type object</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void LoadValueTypeOntoStack<T>(this ILGenerator generator) where T : struct
            => generator.LoadValueTypeOntoStack(typeof (T));

        /// <summary>
        /// Pops an address from the execution stack and pushes the value type object (of the given type) at that location onto the execution stack, with volatile semantics
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of the value type object</param>
        [PublicAPI]
        public static void LoadValueTypeOntoStackVolatile(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("This operation is not valid on reference types");
            }

            generator.Emit(OpCodes.Volatile);
            generator.LoadValueTypeOntoStack(type);
        }

        /// <summary>
        /// Pops an address from the execution stack and pushes the value type object (of the given type) at that location onto the execution stack, with volatile semantics
        /// </summary>
        /// <typeparam name="T">The type of the value type object</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void LoadValueTypeOntoStackVolatile<T>(this ILGenerator generator) where T : struct
            => generator.LoadValueTypeOntoStackVolatile(typeof(T));

        /// <summary>
        /// Pops an address and a value type object (of the given type) from the stack, and copies the object into the address
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of the value type object</param>
        [PublicAPI]
        public static void StoreValueTypeFromStack(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("This operation is not valid on reference types");
            }

            if (type == typeof(sbyte) || type == typeof(byte))
            {
                generator.Emit(OpCodes.Ldind_I1);
            }
            else if (type == typeof(short) || type == typeof(ushort))
            {
                generator.Emit(OpCodes.Ldind_I2);
            }
            else if (type == typeof(int) || type == typeof(uint))
            {
                generator.Emit(OpCodes.Ldind_I4);
            }
            else if (type == typeof(long) || type == typeof(ulong))
            {
                generator.Emit(OpCodes.Ldind_I8);
            }
            else if (type == typeof(float))
            {
                generator.Emit(OpCodes.Ldind_R4);
            }
            else if (type == typeof(double))
            {
                generator.Emit(OpCodes.Ldind_R8);
            }
            else
            {
                generator.Emit(OpCodes.Ldobj, type);
            }
        }

        /// <summary>
        /// Pops an address and a value type object (of the given type) from the stack, and copies the object into the address
        /// </summary>
        /// <typeparam name="T">The type of the value type object</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void StoreValueTypeFromStack<T>(this ILGenerator generator) where T : struct
            => generator.StoreValueTypeFromStack(typeof (T));

        /// <summary>
        /// Pops an address and a value type object (of the given type) from the stack, and copies the object into the address, with volatile semantics
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of the value type object</param>
        [PublicAPI]
        public static void StoreValueTypeFromStackVolatile(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("This operation is not valid on a reference type");
            }

            generator.Emit(OpCodes.Volatile);
            generator.Emit(OpCodes.Stobj, type);
        }

        /// <summary>
        /// Pops an address and a value type object (of the given type) from the stack, and copies the object into the address, with volatile semantics
        /// </summary>
        /// <typeparam name="T">The type of the value type object</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void StoreValueTypeFromStackVolatile<T>(this ILGenerator generator) where T : struct
            => generator.StoreValueTypeFromStack(typeof(T));

        /// <summary>
        /// Pops an address from the execution stack, and pushes the object reference located at that address
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void LoadReferenceFromAddress(this ILGenerator generator) => generator.Emit(OpCodes.Ldind_Ref);
    }
}
