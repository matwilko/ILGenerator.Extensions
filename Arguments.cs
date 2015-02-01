using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    /// <summary>
    /// Contains extension methods for dealing with arguments to the method
    /// </summary>
    [PublicAPI]
    public static partial class Arguments
    {
        /// <summary>
        /// Loads the specified argument onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="argNum">The index of the argument to load</param>
        [PublicAPI]
        public static ILGenerator LoadArgument(this ILGenerator generator, ushort argNum)
        {
            switch (argNum)
            {
                case 0:
                    return generator.FluentEmit(OpCodes.Ldarg_0);
                case 1:
                    return generator.FluentEmit(OpCodes.Ldarg_1);
                case 2:
                    return generator.FluentEmit(OpCodes.Ldarg_2);
                case 3:
                    return generator.FluentEmit(OpCodes.Ldarg_3);
                default:
                    return argNum <= 255
                        ? generator.FluentEmit(OpCodes.Ldarg_S, (byte)argNum)
                        : generator.FluentEmit(OpCodes.Ldarg, argNum);
            }
        }

        /// <summary>
        /// Short-cut to load the first argument - which is the this reference in instance methods
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator LoadThis(this ILGenerator generator) => generator.FluentEmit(OpCodes.Ldarg_0);

        /// <summary>
        /// Loads the address of the specified argument onto the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="argNum"></param>
        [PublicAPI]
        public static ILGenerator LoadArgumentAddress(this ILGenerator generator, ushort argNum)
        {
            return argNum <= 255
                ? generator.FluentEmit(OpCodes.Ldarga_S, (byte)argNum)
                : generator.FluentEmit(OpCodes.Ldarga, argNum);
        }

        /// <summary>
        /// Pop the value on the top of the evaluation stack and stores it in the specified argument
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="argNum">The index of the argument to store the value in</param>
        [PublicAPI]
        public static ILGenerator StoreInArgument(this ILGenerator generator, ushort argNum)
        {
            return argNum <= 255
                ? generator.FluentEmit(OpCodes.Starg_S, (byte)argNum)
                : generator.FluentEmit(OpCodes.Starg, argNum);
        }

        /// <summary>
        /// Pushes an unmanaged pointer to the argument list of the current method
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator LoadArgumentList(this ILGenerator generator) => generator.FluentEmit(OpCodes.Arglist);
    }
}
