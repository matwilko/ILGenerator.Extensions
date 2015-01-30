using System;
using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static class ObjectCreation
    {
        /// <summary>
        /// Creates a new object or instance of a value type, calling the given constructor (and popping the requisite arguments from the evaluation stack) and pushing the reference or value (respectively) onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constructor">The constructor to call</param>
        [PublicAPI]
        public static void NewObject(this ILGenerator generator, ConstructorInfo constructor) => generator.Emit(OpCodes.Newobj, constructor);

        /// <summary>
        /// Creates a new object or instance of a value type, calling the default constructor and pushing the reference or value (respectively) onto the evaluation stack
        /// </summary>
        /// <typeparam name="T">The type of object/value type to create</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void NewObject<T>(this ILGenerator generator) where T : new()
            => generator.Emit(OpCodes.Newobj, typeof (T).GetConstructor(Type.EmptyTypes));

        /// <summary>
        /// Pops the address of the storage location of a value type and initializes each field of the type at that location
        /// </summary>
        /// <typeparam name="T">The type to initialize</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void InitializeValueType<T>(this ILGenerator generator) where T : struct
            => generator.Emit(OpCodes.Initobj, typeof (T));

        /// <summary>
        /// Pops an address, initialization value and number of bytes off the evaluation stack, and initializes the block of memory at the address with the value to that size
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void InitialiseBlock(this ILGenerator generator) => generator.Emit(OpCodes.Initblk);

        /// <summary>
        /// Pops an address off the evaluation stack and initializes the block of memory at the address with the given value to the given size
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The initialization value</param>
        /// <param name="bytes">The number of bytes to initialize</param>
        [PublicAPI]
        public static void InitialiseBlock(this ILGenerator generator, byte value, uint bytes)
        {
            generator.LoadConstant(value);
            generator.LoadConstant(bytes);
            generator.InitialiseBlock();
        }

        /// <summary>
        /// Pops an address, initialization value and number of bytes off the evaluation stack, and initializes the block of memory at the address with the value to that size, with volatile semantics
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void InitialiseBlockVolatile(this ILGenerator generator)
        {
            generator.Emit(OpCodes.Volatile);
            generator.InitialiseBlock();
        }

        /// <summary>
        /// Pops an address off the evaluation stack and initializes the block of memory at the address with the given value to the given size, with volatile semantics
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The initialization value</param>
        /// <param name="bytes">The number of bytes to initialize</param>
        [PublicAPI]
        public static void InitialiseBlockVolatile(this ILGenerator generator, byte value, uint bytes)
        {
            generator.Emit(OpCodes.Volatile);
            generator.InitialiseBlock(value, bytes);
        }

        /// <summary>
        /// Pops an integer off the evaluation stack and creates an array of the given type with that length, pushing the reference onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of the array</param>
        [PublicAPI]
        public static void NewArray(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Newarr);

        /// <summary>
        /// Pops an integer off the evaluation stack and creates an array of the given type with that length, pushing the reference onto the evaluation stack
        /// </summary>
        /// <typeparam name="T">The type of the array</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void NewArray<T>(this ILGenerator generator) => generator.NewArray(typeof (T));

        /// <summary>
        /// Creates an array of the given type with the given length, pushing the reference onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type of the array</param>
        /// <param name="length">The length of the array</param>
        [PublicAPI]
        public static void NewArray(this ILGenerator generator, Type type, uint length)
        {
            generator.LoadConstant(length);
            generator.NewArray(type);
        }

        /// <summary>
        /// Creates an array of the given type with the given length, pushing the reference onto the evaluation stack
        /// </summary>
        /// <typeparam name="T">The type of the array</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="length">The length of the array</param>
        [PublicAPI]
        public static void NewArray<T>(this ILGenerator generator, uint length) => generator.NewArray(typeof(T), length);

        /// <summary>
        /// Pops an unsigned native integer from the evaluation stack, and allocates that number of bytes from the local dynamic memory pool, pushing the address onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void AllocateFromLocalMemoryPool(this ILGenerator generator) => generator.Emit(OpCodes.Localloc);

        /// <summary>
        /// Allocates the given number of bytes from the local dynamic memory pool, pushing the address onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="size"></param>
        [PublicAPI]
        public static void AllocateFromLocalMemoryPool(this ILGenerator generator, uint size)
        {
            generator.LoadConstant(size);
            generator.ConvertToUnsignedNativeInteger();
            generator.AllocateFromLocalMemoryPool();
        }
    }
}
