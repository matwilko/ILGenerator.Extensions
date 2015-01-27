﻿using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static class StackOperations
    {
        /// <summary>
        /// Pops the top value off the execution stack and discards it
        /// </summary>
        /// <param name="generator"></param>
        [PublicAPI]
        public static void Pop(this ILGenerator generator) => generator.Emit(OpCodes.Pop);

        /// <summary>
        /// Pops <paramref name="n"/> values off the execution stack and discards them
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="n">The number of stack values to discard</param>
        [PublicAPI]
        public static void Pop(this ILGenerator generator, uint n)
        {
            for (int i = 0; i < n; i++)
            {
                generator.Emit(OpCodes.Pop);
            }
        }

        /// <summary>
        /// Duplicates the value on the top of the stack
        /// </summary>
        /// <param name="generator"></param>
        [PublicAPI]
        public static void Duplicate(this ILGenerator generator) => generator.Emit(OpCodes.Dup);

        /// <summary>
        /// Duplicates the value on the top of the execution stack <paramref name="n"/> times
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="n">The number of times to duplicate the value</param>
        [PublicAPI]
        public static void Duplicate(this ILGenerator generator, uint n)
        {
            for (int i = 0; i < n; i++)
            {
                generator.Emit(OpCodes.Dup);
            }
        }
    }
}
