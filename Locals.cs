using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    public static partial class Locals
    {
        /// <summary>
        /// Pushes the value of the given local onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="local">The local to get the value of</param>
        [PublicAPI]
        public static void LoadLocal(this ILGenerator generator, LocalBuilder local)
        {
            switch (local.LocalIndex)
            {
                case 0:
                    generator.Emit(OpCodes.Ldloc_0);
                    break;
                case 1:
                    generator.Emit(OpCodes.Ldloc_1);
                    break;
                case 2:
                    generator.Emit(OpCodes.Ldloc_2);
                    break;
                default:
                    if (local.LocalIndex <= 255)
                    {
                        generator.Emit(OpCodes.Ldloc_S, local);
                    }
                    else
                    {
                        generator.Emit(OpCodes.Ldloc, local);
                    }

                    break;
            }
        }

        /// <summary>
        /// Pushes the address of the given local onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="local">The local to get the address of</param>
        [PublicAPI]
        public static void LoadLocalAddress(this ILGenerator generator, LocalBuilder local)
        {
            if (local.LocalIndex <= 255)
            {
                generator.Emit(OpCodes.Ldloca_S, local);
            }
            else
            {
                generator.Emit(OpCodes.Ldloca, local);
            }
        }

        /// <summary>
        /// Pops a value from the evaluation stack and stores it in the given local
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="local">The local to store the evaluation stack value in</param>
        [PublicAPI]
        public static void StoreInLocal(this ILGenerator generator, LocalBuilder local)
        {
            switch (local.LocalIndex)
            {
                case 0:
                    generator.Emit(OpCodes.Stloc_0);
                    break;
                case 1:
                    generator.Emit(OpCodes.Stloc_1);
                    break;
                case 2:
                    generator.Emit(OpCodes.Stloc_2);
                    break;
                default:
                    if (local.LocalIndex <= 255)
                    {
                        generator.Emit(OpCodes.Stloc_S, local);
                    }
                    else
                    {
                        generator.Emit(OpCodes.Stloc, local);
                    }

                    break;
            }
        }
    }
}
