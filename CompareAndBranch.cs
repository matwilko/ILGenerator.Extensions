using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public static partial class CompareAndBranch
    {
        public static void BranchIfNull(this ILGenerator generator, Label label)
        {
            generator.LoadNull();
            generator.BranchIfEqual(label);
        }

        public static void BranchIfNullShortForm(this ILGenerator generator, Label label)
        {
            generator.LoadNull();
            generator.BranchIfEqualShortForm(label);
        }
    }
}
