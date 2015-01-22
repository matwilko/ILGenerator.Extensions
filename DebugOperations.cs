using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [UsedImplicitly]
    public static class DebugOperations
    {
        [UsedImplicitly]
        public static void NoOp(this ILGenerator generator) => generator.Emit(OpCodes.Nop);

        [UsedImplicitly]
        public static void NoOperation(this ILGenerator generator) => generator.NoOp();

        [UsedImplicitly]
        public static void Break(this ILGenerator generator) => generator.Emit(OpCodes.Break);

        [UsedImplicitly]
        public static void BreakInDebugger(this ILGenerator generator) => generator.Break();
    }
}
