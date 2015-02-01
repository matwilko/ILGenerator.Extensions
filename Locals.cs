using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    /// <summary>
    /// Contains extension methods for the manipulation of local variables
    /// </summary>
    public static partial class Locals
    {
        /// <summary>
        /// Pushes the value of the given local onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="local">The local to get the value of</param>
        [PublicAPI]
        public static ILGenerator LoadLocal(this ILGenerator generator, LocalBuilder local)
        {
            switch (local.LocalIndex)
            {
                case 0:
                    return generator.FluentEmit(OpCodes.Ldloc_0);
                case 1:
                    return generator.FluentEmit(OpCodes.Ldloc_1);
                case 2:
                    return generator.FluentEmit(OpCodes.Ldloc_2);
                default:
                    return local.LocalIndex <= 255
                        ? generator.FluentEmit(OpCodes.Ldloc_S, local)
                        : generator.FluentEmit(OpCodes.Ldloc, local);
            }
        }

        /// <summary>
        /// Pushes the value of the given local onto the evaluation stack
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="localName">The name of the fluently-specified local</param>
        public static ILGenerator LoadLocal(this ILGenerator generator, string localName)
            => generator.LoadLocal(generator.GetLocal(localName));

        /// <summary>
        /// Pushes the address of the given local onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="local">The local to get the address of</param>
        [PublicAPI]
        public static ILGenerator LoadLocalAddress(this ILGenerator generator, LocalBuilder local)
        {
            return local.LocalIndex <= 255
                ? generator.FluentEmit(OpCodes.Ldloca_S, local)
                : generator.FluentEmit(OpCodes.Ldloca, local);
        }

        /// <summary>
        /// Pushes the address of the given local onto the evaluation stack
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="localName">The name of the fluently-specified local</param>
        public static ILGenerator LoadLocalAddress(this ILGenerator generator, string localName)
            => generator.LoadLocalAddress(generator.GetLocal(localName));

        /// <summary>
        /// Pops a value from the evaluation stack and stores it in the given local
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="local">The local to store the evaluation stack value in</param>
        [PublicAPI]
        public static ILGenerator StoreInLocal(this ILGenerator generator, LocalBuilder local)
        {
            switch (local.LocalIndex)
            {
                case 0:
                    return generator.FluentEmit(OpCodes.Stloc_0);
                case 1:
                    return generator.FluentEmit(OpCodes.Stloc_1);
                case 2:
                    return generator.FluentEmit(OpCodes.Stloc_2);
                default:
                    return (local.LocalIndex <= 255)
                        ? generator.FluentEmit(OpCodes.Stloc_S, local)
                        : generator.FluentEmit(OpCodes.Stloc, local);
            }
        }

        /// <summary>
        /// Pops a value from the evaluation stack and stores it in the given local
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="localName">The name of the fluently-specified local</param>
        public static ILGenerator StoreInLocal(this ILGenerator generator, string localName)
            => generator.StoreInLocal(generator.GetLocal(localName));
    }
}
