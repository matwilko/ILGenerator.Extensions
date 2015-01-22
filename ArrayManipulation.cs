using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [UsedImplicitly]
    public static partial class ArrayManipulation
    {
        [UsedImplicitly]
        public static void ArrayLength(this ILGenerator generator) => generator.Emit(OpCodes.Ldlen);

        [UsedImplicitly]
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

        [UsedImplicitly]
        public static void LoadElement<T>(this ILGenerator generator) => generator.LoadElement(typeof(T));

        [UsedImplicitly]
        public static void LoadElementAtIndex(this ILGenerator generator, Type type, uint index)
        {
            generator.LoadConstant(index);
            generator.LoadElement(type);
        }

        [UsedImplicitly]
        public static void LoadElementAtIndex<T>(this ILGenerator generator, uint index) => generator.LoadElementAtIndex(typeof(T), index);

        [UsedImplicitly]
        public static void LoadElementAddress(this ILGenerator generator, Type type) => generator.Emit(OpCodes.Ldelema, type);

        [UsedImplicitly]
        public static void LoadElementAddressAtIndex(this ILGenerator generator, Type type, uint index)
        {
            generator.LoadConstant(index);
            generator.LoadElementAddress(type);
        }

        [UsedImplicitly]
        public static void LoadElementAddress<T>(this ILGenerator generator) => generator.LoadElementAddress(typeof(T));

        [UsedImplicitly]
        public static void LoadElementAddressAtIndex<T>(this ILGenerator generator, uint index)
        {
            generator.LoadConstant(index);
            generator.LoadElementAddress(typeof(T));
        }

        [UsedImplicitly]
        public static void LoadElementAddressReadonly(this ILGenerator generator, Type type)
        {
            generator.Emit(OpCodes.Readonly);
            generator.Emit(OpCodes.Ldelema, type);
        }

        [UsedImplicitly]
        public static void LoadElementAddressAtIndexReadonly(this ILGenerator generator, Type type, uint index)
        {
            generator.LoadConstant(index);
            generator.LoadElementAddressReadonly(type);
        }

        [UsedImplicitly]
        public static void LoadElementAddressReadonly<T>(this ILGenerator generator) => generator.LoadElementAddressReadonly(typeof(T));

        [UsedImplicitly]
        public static void LoadElementAddressAtIndexReadonly<T>(this ILGenerator generator, uint index)
        {
            generator.LoadConstant(index);
            generator.LoadElementAddressReadonly(typeof(T));
        }

        [UsedImplicitly]
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

        [UsedImplicitly]
        public static void StoreElement<T>(this ILGenerator generator) => generator.StoreElement(typeof(T));
    }
}
