using System;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public static class ObjectManipulation
    {
        public static void CopyObject(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("Copying a non-value-type results in unspecified runtime behaviour! If you absolutely must copy this type, use CopyObjectWithTypeOverride");
            }

            generator.Emit(OpCodes.Cpobj, type);
        }
        
        public static void CopyObject<T>(this ILGenerator generator) where T : struct => generator.CopyObject(typeof (T));

        public static void CopyObjectWithTypeOverride(this ILGenerator generator, Type type)
        {
            generator.Emit(OpCodes.Cpobj);
        }
        
        public static void CopyBlock(this ILGenerator generator) => generator.Emit(OpCodes.Cpblk);

        public static void CopyBlock(this ILGenerator generator, uint bytes)
        {
            generator.LoadConstant(bytes);
            generator.CopyBlock();
        }

        public static void CopyBlockVolatile(this ILGenerator generator)
        {
            generator.Emit(OpCodes.Volatile);
            generator.CopyBlock();
        }

        public static void CopyBlockVolatile(this ILGenerator generator, uint bytes)
        {
            generator.Emit(OpCodes.Volatile);
            generator.CopyBlock(bytes);
        }

        public static void LoadValueTypeOntoStack(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("This operation is not valid on reference types");
            }

            generator.Emit(OpCodes.Ldobj, type);
        }

        public static void LoadValueTypeOntoStack<T>(this ILGenerator generator) => generator.LoadValueTypeOntoStack(typeof (T));

        public static void LoadValueTypeOntoStackVolatile(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("This operation is not valid on reference types");
            }

            generator.Emit(OpCodes.Volatile);
            generator.Emit(OpCodes.Ldobj, type);
        }

        public static void LoadValueTypeOntoStackVolatile<T>(this ILGenerator generator) => generator.LoadValueTypeOntoStackVolatile(typeof(T));

        public static void StoreValueTypeFromStack(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("This operation is not valid on a reference type");
            }

            generator.Emit(OpCodes.Stobj, type);
        }

        public static void StoreValueTypeFromStack<T>(this ILGenerator generator) where T : struct
            => generator.StoreValueTypeFromStack(typeof (T));

        public static void StoreValueTypeFromStackVolatile(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("This operation is not valid on a reference type");
            }

            generator.Emit(OpCodes.Volatile);
            generator.Emit(OpCodes.Stobj, type);
        }

        public static void StoreValueTypeFromStackVolatile<T>(this ILGenerator generator) where T : struct
            => generator.StoreValueTypeFromStack(typeof(T));
    }
}
