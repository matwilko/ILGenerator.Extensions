using System;
using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static class ObjectCreation
    {
        [PublicAPI]
        public static void NewObject(this ILGenerator generator, ConstructorInfo constructor) => generator.Emit(OpCodes.Newobj, constructor);

        [PublicAPI]
        public static void NewObject<T>(this ILGenerator generator) where T : new()
            => generator.Emit(OpCodes.Newobj, typeof (T).GetConstructor(Type.EmptyTypes));

        [PublicAPI]
        public static void InitializeValueType<T>(this ILGenerator generator) where T : struct
            => generator.Emit(OpCodes.Initobj, typeof (T));

        [PublicAPI]
        public static void InitialiseBlock(this ILGenerator generator) => generator.Emit(OpCodes.Initblk);

        [PublicAPI]
        public static void InitialiseBlock(this ILGenerator generator, byte value, uint bytes)
        {
            generator.LoadConstant(value);
            generator.LoadConstant(bytes);
            generator.InitialiseBlock();
        }

        [PublicAPI]
        public static void InitialiseBlockVolatile(this ILGenerator generator)
        {
            generator.Emit(OpCodes.Volatile);
            generator.InitialiseBlock();
        }

        [PublicAPI]
        public static void InitialiseBlockVolatile(this ILGenerator generator, byte value, uint bytes)
        {
            generator.Emit(OpCodes.Volatile);
            generator.InitialiseBlock(value, bytes);
        }

        [PublicAPI]
        public static void NewArray(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Newarr);

        [PublicAPI]
        public static void NewArray<T>(this ILGenerator generator) => generator.NewArray(typeof (T));

        [PublicAPI]
        public static void NewArray(this ILGenerator generator, Type type, uint length)
        {
            generator.LoadConstant(length);
            generator.NewArray(type);
        }

        [PublicAPI]
        public static void NewArray<T>(this ILGenerator generator, uint length) => generator.NewArray(typeof(T), length);

        [PublicAPI]
        public static void AllocateFromLocalMemoryPool(this ILGenerator generator) => generator.Emit(OpCodes.Localloc);

        [PublicAPI]
        public static void AllocateFromLocalMemoryPool(this ILGenerator generator, uint size)
        {
            generator.LoadConstant(size);
            generator.AllocateFromLocalMemoryPool();
        }
    }
}
