using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [UsedImplicitly]
    public static partial class Arguments
    {
        /// <summary>
        /// Loads the specified argument onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="argNum">The index of the argument to load</param>
        public static void LoadArgument(this ILGenerator generator, ushort argNum)
        {
            switch (argNum)
            {
                case 0:
                    generator.Emit(OpCodes.Ldarg_0);
                    break;
                case 1:
                    generator.Emit(OpCodes.Ldarg_1);
                    break;
                case 2:
                    generator.Emit(OpCodes.Ldarg_2);
                    break;
                case 3:
                    generator.Emit(OpCodes.Ldarg_3);
                    break;
                default:
                    if (argNum <= 255)
                    {
                        generator.Emit(OpCodes.Ldarg_S, (byte)argNum);
                    }
                    else
                    {
                        generator.Emit(OpCodes.Ldarg, argNum);
                    }
                    break;
            }
        }

        /// <summary>
        /// Short-cut to load the first argument - which is the this reference in instance methods
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        public static void LoadThis(this ILGenerator generator) => generator.Emit(OpCodes.Ldarg_0);

        /// <summary>
        /// Loads the address of the specified argument onto the evaluation stack
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="argNum"></param>
        public static void LoadArgumentAddress(this ILGenerator generator, ushort argNum)
        {
            if (argNum <= 255)
            {
                generator.Emit(OpCodes.Ldarga_S, (byte)argNum);
            }
            else
            {
                generator.Emit(OpCodes.Ldarga, argNum);
            }
        }

        /// <summary>
        /// Pop the value on the top of the evaluation stack and stores it in the specified argument
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="argNum">The index of the argument to store the value in</param>
        public static void StoreInArgument(this ILGenerator generator, ushort argNum)
        {
            if (argNum <= 255)
            {
                generator.Emit(OpCodes.Starg_S, (byte)argNum);
            }
            else
            {
                generator.Emit(OpCodes.Starg, argNum);
            }
        }
    }
}
