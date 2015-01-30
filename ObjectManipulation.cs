﻿using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static class ObjectManipulation
    {
        [PublicAPI]
        public static void CopyObject(this ILGenerator generator, Type type)
        {
            if (!type.IsValueType)
            {
                throw new InvalidOperationException("Copying a non-value-type results in unspecified runtime behaviour");
            }

            generator.Emit(OpCodes.Cpobj, type);
        }

        [PublicAPI]
        public static void CopyObject<T>(this ILGenerator generator) where T : struct => generator.CopyObject(typeof (T));

        [PublicAPI]
        public static void CopyBlock(this ILGenerator generator) => generator.Emit(OpCodes.Cpblk);

        [PublicAPI]
        public static void CopyBlock(this ILGenerator generator, uint bytes)
        {
            generator.LoadConstant(bytes);
            generator.CopyBlock();
        }

        [PublicAPI]
        public static void CopyBlockVolatile(this ILGenerator generator)
        {
            generator.Emit(OpCodes.Volatile);
            generator.CopyBlock();
        }

        [PublicAPI]
        public static void CopyBlockVolatile(this ILGenerator generator, uint bytes)
        {
            generator.Emit(OpCodes.Volatile);
            generator.CopyBlock(bytes);
        }

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

        [PublicAPI]
        public static void LoadValueTypeOntoStack<T>(this ILGenerator generator) => generator.LoadValueTypeOntoStack(typeof (T));

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

        [PublicAPI]
        public static void LoadValueTypeOntoStackVolatile<T>(this ILGenerator generator) => generator.LoadValueTypeOntoStackVolatile(typeof(T));

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

        [PublicAPI]
        public static void StoreValueTypeFromStack<T>(this ILGenerator generator) where T : struct
            => generator.StoreValueTypeFromStack(typeof (T));

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

        [PublicAPI]
        public static void StoreValueTypeFromStackVolatile<T>(this ILGenerator generator) where T : struct
            => generator.StoreValueTypeFromStack(typeof(T));

        [PublicAPI]
        public static void LoadReferenceFromAddress(this ILGenerator generator, Type type)
        {
            if (type.IsValueType)
            {
                throw new InvalidOperationException("Cannot load reference for value type");
            }

            generator.Emit(OpCodes.Ldind_Ref, type);
        }

        [PublicAPI]
        public static void LoadReferenceFromAddress<T>(this ILGenerator generator)
            => generator.LoadReferenceFromAddress(typeof (T));


    }
}
