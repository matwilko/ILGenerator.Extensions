using System;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public static class LoadConstants
    {
        public static void LoadConstant(this ILGenerator generator, Int32 value)
        {
            switch (value)
            {
                case -1:
                    generator.Emit(OpCodes.Ldc_I4_M1);
                    break;
                case 0:
                    generator.Emit(OpCodes.Ldc_I4_0);
                    break;
                case 1:
                    generator.Emit(OpCodes.Ldc_I4_1);
                    break;
                case 2:
                    generator.Emit(OpCodes.Ldc_I4_2);
                    break;
                case 3:
                    generator.Emit(OpCodes.Ldc_I4_3);
                    break;
                case 4:
                    generator.Emit(OpCodes.Ldc_I4_4);
                    break;
                case 5:
                    generator.Emit(OpCodes.Ldc_I4_5);
                    break;
                case 6:
                    generator.Emit(OpCodes.Ldc_I4_6);
                    break;
                case 7:
                    generator.Emit(OpCodes.Ldc_I4_7);
                    break;
                case 8:
                    generator.Emit(OpCodes.Ldc_I4_8);
                    break;
                default:
                    if (value <= 127 && value >= -128)
                    {
                        generator.Emit(OpCodes.Ldc_I4_S, value);
                    }
                    else
                    {
                        generator.Emit(OpCodes.Ldc_I4, value);
                    }
                    break;
            }
        }

        public static void LoadConstant(this ILGenerator generator, UInt32 value)
        {
            switch (value)
            {
                case 0:
                    generator.Emit(OpCodes.Ldc_I4_0);
                    break;
                case 1:
                    generator.Emit(OpCodes.Ldc_I4_1);
                    break;
                case 2:
                    generator.Emit(OpCodes.Ldc_I4_2);
                    break;
                case 3:
                    generator.Emit(OpCodes.Ldc_I4_3);
                    break;
                case 4:
                    generator.Emit(OpCodes.Ldc_I4_4);
                    break;
                case 5:
                    generator.Emit(OpCodes.Ldc_I4_5);
                    break;
                case 6:
                    generator.Emit(OpCodes.Ldc_I4_6);
                    break;
                case 7:
                    generator.Emit(OpCodes.Ldc_I4_7);
                    break;
                case 8:
                    generator.Emit(OpCodes.Ldc_I4_8);
                    break;
                default:
                    if (value <= 127)
                    {
                        generator.Emit(OpCodes.Ldc_I4_S, value);
                    }
                    else
                    {
                        generator.Emit(OpCodes.Ldc_I4, value);
                    }
                    break;
            }
        }

        public static void LoadConstant(this ILGenerator generator, long value)
        {
            if (value <= int.MaxValue && value >= int.MinValue)
            {
                generator.LoadConstant((int)value);
                generator.ConvertToInt64();
            }
            else
            {
                generator.Emit(OpCodes.Ldc_I8, value);
            }
        }

        public static void LoadConstant(this ILGenerator generator, ulong value)
        {
            if (value <= uint.MaxValue)
            {
                generator.LoadConstant((uint)value);
                generator.ConvertToUInt64();
            }
            else
            {
                generator.Emit(OpCodes.Ldc_I8, value);
            }
        }

        public static void LoadConstant(this ILGenerator generator, float value) => generator.Emit(OpCodes.Ldc_R4, value);

        public static void LoadConstant(this ILGenerator generator, double value) => generator.Emit(OpCodes.Ldc_R8, value);

        public static void LoadNull(this ILGenerator generator) => generator.Emit(OpCodes.Ldnull);

        public static void LoadString(this ILGenerator generator, string str) => generator.Emit(OpCodes.Ldstr, str);
    }
}