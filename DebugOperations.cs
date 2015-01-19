using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public static class DebugOperations
    {
        public static void NoOp(this ILGenerator generator) => generator.Emit(OpCodes.Nop);
        public static void NoOperation(this ILGenerator generator) => generator.NoOp();

        public static void Break(this ILGenerator generator) => generator.Emit(OpCodes.Break);
        public static void BreakInDebugger(this ILGenerator generator) => generator.Break();

    }
}
