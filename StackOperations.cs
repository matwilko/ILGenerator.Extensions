using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public static class StackOperations
    {
        public static void Pop(this ILGenerator generator) => generator.Emit(OpCodes.Pop);

        public static void Pop(this ILGenerator generator, uint repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
                generator.Emit(OpCodes.Pop);
            }
        }

        public static void Duplicate(this ILGenerator generator) => generator.Emit(OpCodes.Dup);

        public static void Duplicate(this ILGenerator generator, uint repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
                generator.Emit(OpCodes.Dup);
            }
        }
    }
}
