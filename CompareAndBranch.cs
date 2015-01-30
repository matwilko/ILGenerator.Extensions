using System.Reflection.Emit;
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
        public static void BranchIfNull(this ILGenerator generator, Label label)
        {
            generator.LoadNull();
            generator.BranchIfEqual(label);
        }

        /// <summary>
        /// Pops a reference from the evaluation stack and branches to the given label if it is the null reference
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
        [PublicAPI]
        public static void BranchIfNullShortForm(this ILGenerator generator, Label label)
        {
            generator.LoadNull();
            generator.BranchIfEqualShortForm(label);
        }

        /// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it interprets as true
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
        [PublicAPI]
        public static void BranchIfTrue(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Brtrue, label);

        /// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it interprets as true
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
        [PublicAPI]
        public static void BranchIfTrueShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Brtrue_S, label);

        /// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it interprets as false
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
        [PublicAPI]
        public static void BranchIfFalse(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Brfalse, label);

        /// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it interprets as false
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
        [PublicAPI]
        public static void BranchIfFalseShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Brfalse_S, label);
    }
}
