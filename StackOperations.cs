using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static class StackOperations
    {
        [PublicAPI]
        public static void Pop(this ILGenerator generator) => generator.Emit(OpCodes.Pop);

        [PublicAPI]
        public static void Pop(this ILGenerator generator, uint repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
                generator.Emit(OpCodes.Pop);
            }
        }

        [PublicAPI]
        public static void Duplicate(this ILGenerator generator) => generator.Emit(OpCodes.Dup);

        [PublicAPI]
        public static void Duplicate(this ILGenerator generator, uint repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
                generator.Emit(OpCodes.Dup);
            }
        }
    }
}
