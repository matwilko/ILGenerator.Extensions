using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    public static partial class CompareAndBranch
    {
        [UsedImplicitly]
        public static void BranchIfNull(this ILGenerator generator, Label label)
        {
            generator.LoadNull();
            generator.BranchIfEqual(label);
        }

        [UsedImplicitly]
        public static void BranchIfNullShortForm(this ILGenerator generator, Label label)
        {
            generator.LoadNull();
            generator.BranchIfEqualShortForm(label);
        }
    }
}
