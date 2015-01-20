using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public static class ObjectCreation
    {
        public static void NewObject(this ILGenerator generator, ConstructorInfo constructor) => generator.Emit(OpCodes.Newobj, constructor);

        public static void NewObject<T>(this ILGenerator generator) where T : new()
            => generator.Emit(OpCodes.Newobj, typeof (T).GetConstructor(Type.EmptyTypes));

        public static void InitializeValueType<T>(this ILGenerator generator) where T : struct
            => generator.Emit(OpCodes.Initobj, typeof (T));
        
        public static void InitialiseBlock(this ILGenerator generator) => generator.Emit(OpCodes.Initblk);

        public static void InitialiseBlock(this ILGenerator generator, byte value, uint bytes)
        {
            generator.LoadConstant(value);
            generator.LoadConstant(bytes);
            generator.InitialiseBlock();
        }

        public static void InitialiseBlockVolatile(this ILGenerator generator)
        {
            generator.Emit(OpCodes.Volatile);
            generator.InitialiseBlock();
        } 

        public static void InitialiseBlockVolatile(this ILGenerator generator, byte value, uint bytes)
        {
            generator.Emit(OpCodes.Volatile);
            generator.InitialiseBlock(value, bytes);
        }
        
        public static void NewArray(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Newarr);

        public static void NewArray<T>(this ILGenerator generator) => generator.NewArray(typeof (T));

        public static void NewArray(this ILGenerator generator, Type type, uint length)
        {
            generator.LoadConstant(length);
            generator.NewArray(type);
        }

        public static void NewArray<T>(this ILGenerator generator, uint length) => generator.NewArray(typeof(T), length);
    }
}
