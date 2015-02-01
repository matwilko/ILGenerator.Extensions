using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static partial class ArrayManipulation
    {
        /// <summary>
        /// Pops an array reference off the evaluation stack and pushes the length of the array
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator ArrayLength(this ILGenerator generator) => generator.FluentEmit(OpCodes.Ldlen);

        /// <summary>
        /// Pops an array reference (containing elements of the given type) and an index off the evaluation stack and pushes the element at that array index
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of elements in the array</param>
        [PublicAPI]
        public static ILGenerator LoadElement(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                return generator.FluentEmit(OpCodes.Ldelem_Ref);
            }
            else if (type == typeof(sbyte) || type == typeof(bool))
            {
                return generator.FluentEmit(OpCodes.Ldelem_I1);
            }
            else if (type == typeof(byte))
            {
                return generator.FluentEmit(OpCodes.Ldelem_U1);
            }
            else if (type == typeof(short))
            {
                return generator.FluentEmit(OpCodes.Ldelem_I2);
            }
            else if (type == typeof(ushort))
            {
                return generator.FluentEmit(OpCodes.Ldelem_U2);
            }
            else if (type == typeof(int))
            {
                return generator.FluentEmit(OpCodes.Ldelem_I4);
            }
            else if (type == typeof(uint))
            {
                return generator.FluentEmit(OpCodes.Ldelem_U4);
            }
            else if (type == typeof(long))
            {
                return generator.FluentEmit(OpCodes.Ldelem_I8);
            }
            else if (type == typeof(ulong))
            {
                // Not a mistake! ldelem.U8 is an alias for ldelem.I8
                return generator.FluentEmit(OpCodes.Ldelem_I8);
            }
            else if (type == typeof(float))
            {
                return generator.FluentEmit(OpCodes.Ldelem_R4);
            }
            else if (type == typeof(double))
            {
                return generator.FluentEmit(OpCodes.Ldelem_R8);
            }
            else
            {
                return generator.FluentEmit(OpCodes.Ldelem, type);
            }
        }

        /// <summary>
        /// Pops an array reference (containing elements of the given type) and an index off the evaluation stack and pushes the element at that array index
        /// </summary>
        /// <typeparam name="T">The type of elements in the array</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator LoadElement<T>(this ILGenerator generator) => generator.LoadElement(typeof(T));

        /// <summary>
        /// Pops an array reference (containing elements of the given type) off the evaluation stack and pushes the element at the given array index
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of elements in the array</param>
        /// <param name="index">The index of the element to load</param>
        [PublicAPI]
        public static ILGenerator LoadElementAtIndex(this ILGenerator generator, Type type, uint index)
        {
            return generator.LoadConstant(index)
                            .LoadElement(type);
        }

        /// <summary>
        /// Pops an array reference (containing elements of the given type) off the evaluation stack and pushes the element at the given array index
        /// </summary>
        /// <typeparam name="T">The type of elements in the array</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="index">The index of the element to load</param>
        [PublicAPI]
        public static ILGenerator LoadElementAtIndex<T>(this ILGenerator generator, uint index) => generator.LoadElementAtIndex(typeof(T), index);

        /// <summary>
        /// Pops an array reference (containing elements of the given type) and an index off the evaluation stack and pushes the address of the element
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of elements in the array</param>
        [PublicAPI]
        public static ILGenerator LoadElementAddress(this ILGenerator generator, Type type) => generator.FluentEmit(OpCodes.Ldelema, type);

        /// <summary>
        /// Pops an array reference (containing elements of the given type) and pushes the address of the element at the given index
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of elements in the array</param>
        /// <param name="index">The index of the element to load the address of</param>
        [PublicAPI]
        public static ILGenerator LoadElementAddressAtIndex(this ILGenerator generator, Type type, uint index)
        {
            return generator.LoadConstant(index)
                            .LoadElementAddress(type);
        }

        /// <summary>
        /// Pops an array reference (containing elements of the given type) and an index off the evaluation stack and pushes the address of the element at that array index
        /// </summary>
        /// <typeparam name="T">The type of elements in the array</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator LoadElementAddress<T>(this ILGenerator generator) => generator.LoadElementAddress(typeof(T));

        /// <summary>
        /// Pops an array reference (containing elements of the given type) off the evaluation stack and pushes the address of the element at the given index
        /// </summary>
        /// <typeparam name="T">The type of elements in the array</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="index">The index of the element to load the address of</param>
        [PublicAPI]
        public static ILGenerator LoadElementAddressAtIndex<T>(this ILGenerator generator, uint index)
        {
            return generator.LoadConstant(index)
                            .LoadElementAddress(typeof(T));
        }

        /// <summary>
        /// Pops an array reference (containing elements of the given type) and an index off the evaluation stack and pushes the address of the element at that array index, with restrictions on its use by other code
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of elements in the array</param>
        [PublicAPI]
        public static ILGenerator LoadElementAddressReadonly(this ILGenerator generator, Type type)
        {
            return generator.FluentEmit(OpCodes.Readonly)
                            .FluentEmit(OpCodes.Ldelema, type);
        }

        /// <summary>
        /// Pops an array reference (containing elements of the given type) and an index off the evaluation stack and pushes the address of the element at the given index, with restrictions on its use by other code
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of elements in the array</param>
        /// <param name="index">The index of the element to load the address of</param>
        [PublicAPI]
        public static ILGenerator LoadElementAddressAtIndexReadonly(this ILGenerator generator, Type type, uint index)
        {
            return generator.LoadConstant(index)
                            .LoadElementAddressReadonly(type);
        }

        /// <summary>
        /// Pops an array reference (containing elements of the given type) and an index off the evaluation stack and pushes the address of the element at that array index, with restrictions on its use by other code
        /// </summary>
        /// <typeparam name="T">The type of elements in the array</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator LoadElementAddressReadonly<T>(this ILGenerator generator) => generator.LoadElementAddressReadonly(typeof(T));

        /// <summary>
        /// Pops an array reference (containing elements of the given type) and an index off the evaluation stack and pushes the address of the element at the given index, with restrictions on its use by other code
        /// </summary>
        /// <typeparam name="T">The type of elements in the array</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="index">The index of the element to load the address of</param>
        [PublicAPI]
        public static ILGenerator LoadElementAddressAtIndexReadonly<T>(this ILGenerator generator, uint index)
        {
            return generator.LoadConstant(index)
                            .LoadElementAddressReadonly(typeof(T));
        }

        /// <summary>
        /// Pops an array reference (containing elements of the given type), and index and a value of the given type, and stores the value in the array at that index
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of elements in the array</param>
        [PublicAPI]
        public static ILGenerator StoreElement(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                return generator.FluentEmit(OpCodes.Stelem_Ref);
            }
            else if (type == typeof(sbyte) || type == typeof(byte) || type == typeof(bool))
            {
                return generator.FluentEmit(OpCodes.Stelem_I1);
            }
            else if (type == typeof(short) || type == typeof(ushort))
            {
                return generator.FluentEmit(OpCodes.Stelem_I2);
            }
            else if (type == typeof(int) || type == typeof(uint))
            {
                return generator.FluentEmit(OpCodes.Stelem_I4);
            }
            else if (type == typeof(long) || type == typeof(ulong))
            {
                return generator.FluentEmit(OpCodes.Ldelem_I8);
            }
            else if (type == typeof(float))
            {
                return generator.FluentEmit(OpCodes.Stelem_R4);
            }
            else if (type == typeof(double))
            {
                return generator.FluentEmit(OpCodes.Stelem_R8);
            }
            else
            {
                return generator.FluentEmit(OpCodes.Stelem, type);
            }
        }

        /// <summary>
        /// Pops an array reference (containing elements of the given type), and index and a value of the given type, and stores the value in the array at that index
        /// </summary>
        /// <typeparam name="T">The type of elements in the array</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator StoreElement<T>(this ILGenerator generator) => generator.StoreElement(typeof(T));
    }
}
