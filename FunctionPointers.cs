using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    public static class FunctionPointers
    {
        /// <summary>
        /// Pushes an unmanaged pointer (type native int) to the native code implementing the given method onto the evaluation stack.
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="method">The method to load the pointer for</param>
        [PublicAPI]
        public static void LoadFunctionPointer(this ILGenerator generator, MethodInfo method)
            => generator.Emit(OpCodes.Ldftn, method);

        /// <summary>
        /// Pops a reference off the evaluation stack, and pushes an unmanaged pointer (type native int) to the native code implementing the given virtual method for that object onto the evaluation stack.
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="method">The method to load the pointer for</param>
        [PublicAPI]
        public static void LoadVirtualFunctionPointer(this ILGenerator generator, MethodInfo method)
            => generator.Emit(OpCodes.Ldvirtftn, method);
    }
}
