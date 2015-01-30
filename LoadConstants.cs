using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    public static class LoadConstants
    {
        /// <summary>
        /// Pushes the given value onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to push onto the evaluation stack</param>
        [PublicAPI]
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

        /// <summary>
        /// Pushes the given value onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to push onto the evaluation stack</param>
        [PublicAPI]
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

        /// <summary>
        /// Pushes the given value onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to push onto the evaluation stack</param>
        [PublicAPI]
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

        /// <summary>
        /// Pushes the given value onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to push onto the evaluation stack</param>
        [PublicAPI]
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

        /// <summary>
        /// Pushes the given value onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to push onto the evaluation stack</param>
        [PublicAPI]
        public static void LoadConstant(this ILGenerator generator, float value) => generator.Emit(OpCodes.Ldc_R4, value);

        /// <summary>
        /// Pushes the given value onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to push onto the evaluation stack</param>
        [PublicAPI]
        public static void LoadConstant(this ILGenerator generator, double value) => generator.Emit(OpCodes.Ldc_R8, value);

        /// <summary>
        /// Pushes the given value onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to push onto the evaluation stack</param>
        [PublicAPI]
        public static void LoadConstant(this ILGenerator generator, bool value) => generator.LoadConstant(value ? 1 : 0);

        /// <summary>
        /// Pushes the given value onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to push onto the evaluation stack</param>
        [PublicAPI]
        public static void LoadConstant(this ILGenerator generator, char value) => generator.LoadConstant((int) value);

        /// <summary>
        /// Pushes the null reference onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void LoadNull(this ILGenerator generator) => generator.Emit(OpCodes.Ldnull);

        /// <summary>
        /// Pushes the given string onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="str">The string to push onto the evaluation stack</param>
        [PublicAPI]
        public static void LoadString(this ILGenerator generator, string str) => generator.Emit(OpCodes.Ldstr, str);
    }
}