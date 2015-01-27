using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static class DebugOperations
    {
        /// <summary>
        /// Performs no operation
        /// </summary>
        /// <param name="generator"></param>
        [PublicAPI]
        public static void NoOp(this ILGenerator generator) => generator.Emit(OpCodes.Nop);

        /// <summary>
        /// Performs no operation
        /// </summary>
        /// <param name="generator"></param>
        [PublicAPI]
        public static void NoOperation(this ILGenerator generator) => generator.NoOp();

        /// <summary>
        /// Signals an attached debugger to break execution
        /// </summary>
        /// <param name="generator"></param>
        [PublicAPI]
        public static void Break(this ILGenerator generator) => generator.Emit(OpCodes.Break);

        /// <summary>
        /// Signals an attached debugger to break execution
        /// </summary>
        /// <param name="generator"></param>
        [PublicAPI]
        public static void BreakInDebugger(this ILGenerator generator) => generator.Break();
    }
}
