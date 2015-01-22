using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [UsedImplicitly]
    public static class StackOperations
    {
        [UsedImplicitly]
        public static void Pop(this ILGenerator generator) => generator.Emit(OpCodes.Pop);

        [UsedImplicitly]
        public static void Pop(this ILGenerator generator, uint repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
                generator.Emit(OpCodes.Pop);
            }
        }

        [UsedImplicitly]
        public static void Duplicate(this ILGenerator generator) => generator.Emit(OpCodes.Dup);

        [UsedImplicitly]
        public static void Duplicate(this ILGenerator generator, uint repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
                generator.Emit(OpCodes.Dup);
            }
        }
    }
}
