using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    public static partial class CompareAndBranch
    {
        [PublicAPI]
        public static void BranchIfNull(this ILGenerator generator, Label label)
        {
            generator.LoadNull();
            generator.BranchIfEqual(label);
        }

        [PublicAPI]
        public static void BranchIfNullShortForm(this ILGenerator generator, Label label)
        {
            generator.LoadNull();
            generator.BranchIfEqualShortForm(label);
        }
    }
}
