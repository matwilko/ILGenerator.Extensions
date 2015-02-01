﻿using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    public static partial class CompareAndBranch
    {
        /// <summary>
        /// Pops a reference from the evaluation stack and branches to the given label if it is the null reference
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
        [PublicAPI]
        public static ILGenerator BranchIfNull(this ILGenerator generator, Label label)
        {
            return generator.LoadNull()
                            .BranchIfEqual(label);
        }

        /// <summary>
        /// Pops a reference from the evaluation stack and branches to the given label if it is the null reference
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
        [PublicAPI]
        public static ILGenerator BranchIfNullShortForm(this ILGenerator generator, Label label)
        {
            return generator.LoadNull()
                            .BranchIfEqualShortForm(label);
        }

        /// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it interprets as true
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
        [PublicAPI]
        public static ILGenerator BranchIfTrue(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Brtrue, label);

        /// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it interprets as true
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
        [PublicAPI]
        public static ILGenerator BranchIfTrueShortForm(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Brtrue_S, label);

        /// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it interprets as false
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
        [PublicAPI]
        public static ILGenerator BranchIfFalse(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Brfalse, label);

        /// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it interprets as false
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
        [PublicAPI]
        public static ILGenerator BranchIfFalseShortForm(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Brfalse_S, label);
    }
}
