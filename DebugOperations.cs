using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static class DebugOperations
    {
        [PublicAPI]
        public static void NoOp(this ILGenerator generator) => generator.Emit(OpCodes.Nop);

        [PublicAPI]
        public static void NoOperation(this ILGenerator generator) => generator.NoOp();

        [PublicAPI]
        public static void Break(this ILGenerator generator) => generator.Emit(OpCodes.Break);

        [PublicAPI]
        public static void BreakInDebugger(this ILGenerator generator) => generator.Break();
    }
}
