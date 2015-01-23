using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static partial class ArrayManipulation
    {
        /// <summary>
        /// Pops an array reference off the execution stack and pushes the length of the array
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void ArrayLength(this ILGenerator generator) => generator.Emit(OpCodes.Ldlen);

        /// <summary>
        /// Pops an array reference (containing elements of the given type) and an index off the execution stack and pushes the element at that array index
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of elements in the array</param>
        [PublicAPI]
        public static void LoadElement(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                generator.Emit(OpCodes.Ldelem_Ref);
            }
            else if (type == typeof(sbyte) || type == typeof(bool))
            {
                generator.Emit(OpCodes.Ldelem_I1);
            }
            else if (type == typeof(byte))
            {
                generator.Emit(OpCodes.Ldelem_U1);
            }
            else if (type == typeof(short))
            {
                generator.Emit(OpCodes.Ldelem_I2);
            }
            else if (type == typeof(ushort))
            {
                generator.Emit(OpCodes.Ldelem_U2);
            }
            else if (type == typeof(int))
            {
                generator.Emit(OpCodes.Ldelem_I4);
            }
            else if (type == typeof(uint))
            {
                generator.Emit(OpCodes.Ldelem_U4);
            }
            else if (type == typeof(long))
            {
                generator.Emit(OpCodes.Ldelem_I8);
            }
            else if (type == typeof(ulong))
            {
                // Not a mistake! ldelem.U8 is an alias for ldelem.I8
                generator.Emit(OpCodes.Ldelem_I8);
            }
            else if (type == typeof(float))
            {
                generator.Emit(OpCodes.Ldelem_R4);
            }
            else if (type == typeof(double))
            {
                generator.Emit(OpCodes.Ldelem_R8);
            }
            else
            {
                generator.Emit(OpCodes.Ldelem, type);
            }
        }

        /// <summary>
        /// Pops an array reference (containing elements of the given type) and an index off the execution stack and pushes the element at that array index
        /// </summary>
        /// <typeparam name="T">The type of elements in the array</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void LoadElement<T>(this ILGenerator generator) => generator.LoadElement(typeof(T));

        /// <summary>
        /// Pops an array reference (containing elements of the given type) off the execution stack and pushes the element at the given array index
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of elements in the array</param>
        /// <param name="index">The index of the element to load</param>
        [PublicAPI]
        public static void LoadElementAtIndex(this ILGenerator generator, Type type, uint index)
        {
            generator.LoadConstant(index);
            generator.LoadElement(type);
        }

        /// <summary>
        /// Pops an array reference (containing elements of the given type) off the execution stack and pushes the element at the given array index
        /// </summary>
        /// <typeparam name="T">The type of elements in the array</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="index">The index of the element to load</param>
        [PublicAPI]
        public static void LoadElementAtIndex<T>(this ILGenerator generator, uint index) => generator.LoadElementAtIndex(typeof(T), index);

        /// <summary>
        /// Pops an array reference (containing elements of the given type) and an index off the execution stack and pushes the address of the element
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of elements in the array</param>
        [PublicAPI]
        public static void LoadElementAddress(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Ldelema, type);

        /// <summary>
        /// Pops an array reference (containing elements of the given type) and pushes the address of the element at the given index
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of elements in the array</param>
        /// <param name="index">The index of the element to load the address of</param>
        [PublicAPI]
        public static void LoadElementAddressAtIndex(this ILGenerator generator, Type type, uint index)
        {
            generator.LoadConstant(index);
            generator.LoadElementAddress(type);
        }

        /// <summary>
        /// Pops an array reference (containing elements of the given type) and an index off the execution stack and pushes the address of the element at that array index
        /// </summary>
        /// <typeparam name="T">The type of elements in the array</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void LoadElementAddress<T>(this ILGenerator generator) => generator.LoadElementAddress(typeof(T));

        /// <summary>
        /// Pops an array reference (containing elements of the given type) off the execution stack and pushes the address of the element at the given index
        /// </summary>
        /// <typeparam name="T">The type of elements in the array</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="index">The index of the element to load the address of</param>
        [PublicAPI]
        public static void LoadElementAddressAtIndex<T>(this ILGenerator generator, uint index)
        {
            generator.LoadConstant(index);
            generator.LoadElementAddress(typeof(T));
        }

        /// <summary>
        /// Pops an array reference (containing elements of the given type) and an index off the execution stack and pushes the address of the element at that array index, with restrictions on its use by other code
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of elements in the array</param>
        [PublicAPI]
        public static void LoadElementAddressReadonly(this ILGenerator generator, Type type)
        {
            generator.Emit(OpCodes.Readonly);
            generator.Emit(OpCodes.Ldelema, type);
        }

        /// <summary>
        /// Pops an array reference (containing elements of the given type) and an index off the execution stack and pushes the address of the element at the given index, with restrictions on its use by other code
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of elements in the array</param>
        /// <param name="index">The index of the element to load the address of</param>
        [PublicAPI]
        public static void LoadElementAddressAtIndexReadonly(this ILGenerator generator, Type type, uint index)
        {
            generator.LoadConstant(index);
            generator.LoadElementAddressReadonly(type);
        }

        /// <summary>
        /// Pops an array reference (containing elements of the given type) and an index off the execution stack and pushes the address of the element at that array index, with restrictions on its use by other code
        /// </summary>
        /// <typeparam name="T">The type of elements in the array</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void LoadElementAddressReadonly<T>(this ILGenerator generator) => generator.LoadElementAddressReadonly(typeof(T));

        /// <summary>
        /// Pops an array reference (containing elements of the given type) and an index off the execution stack and pushes the address of the element at the given index, with restrictions on its use by other code
        /// </summary>
        /// <typeparam name="T">The type of elements in the array</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="index">The index of the element to load the address of</param>
        [PublicAPI]
        public static void LoadElementAddressAtIndexReadonly<T>(this ILGenerator generator, uint index)
        {
            generator.LoadConstant(index);
            generator.LoadElementAddressReadonly(typeof(T));
        }

        /// <summary>
        /// Pops an array reference (containing elements of the given type), and index and a value of the given type, and stores the value in the array at that index
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of elements in the array</param>
        [PublicAPI]
        public static void StoreElement(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                generator.Emit(OpCodes.Stelem_Ref);
            }
            else if (type == typeof(sbyte) || type == typeof(byte) || type == typeof(bool))
            {
                generator.Emit(OpCodes.Stelem_I1);
            }
            else if (type == typeof(short) || type == typeof(ushort))
            {
                generator.Emit(OpCodes.Stelem_I2);
            }
            else if (type == typeof(int) || type == typeof(uint))
            {
                generator.Emit(OpCodes.Stelem_I4);
            }
            else if (type == typeof(long) || type == typeof(ulong))
            {
                generator.Emit(OpCodes.Ldelem_I8);
            }
            else if (type == typeof(float))
            {
                generator.Emit(OpCodes.Stelem_R4);
            }
            else if (type == typeof(double))
            {
                generator.Emit(OpCodes.Stelem_R8);
            }
            else
            {
                generator.Emit(OpCodes.Stelem, type);
            }
        }

        /// <summary>
        /// Pops an array reference (containing elements of the given type), and index and a value of the given type, and stores the value in the array at that index
        /// </summary>
        /// <typeparam name="T">The type of elements in the array</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void StoreElement<T>(this ILGenerator generator) => generator.StoreElement(typeof(T));
    }
}
