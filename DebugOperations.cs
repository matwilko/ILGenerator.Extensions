using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    /// <summary>
    /// Contains extension methods for operations useful to debuggers
    /// </summary>
    [PublicAPI]
    public static class DebugOperations
    {
        /// <summary>
        /// Performs no operation
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator NoOp(this ILGenerator generator) => generator.FluentEmit(OpCodes.Nop);

        /// <summary>
        /// Performs no operation
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator NoOperation(this ILGenerator generator) => generator.NoOp();

        /// <summary>
        /// Signals an attached debugger to break execution
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator Break(this ILGenerator generator) => generator.FluentEmit(OpCodes.Break);

        /// <summary>
        /// Signals an attached debugger to break execution
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator BreakInDebugger(this ILGenerator generator) => generator.Break();
    }
}
