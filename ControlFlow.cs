using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public static class ControlFlow
    {
        public static void BranchTo(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Br, label);

        public static void BranchToShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Br_S, label);

        public static void Switch(this ILGenerator generator, params Label[] labels) => generator.Emit(OpCodes.Switch, labels);
    }
}
