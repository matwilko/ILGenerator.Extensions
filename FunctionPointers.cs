using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    public static class FunctionPointers
    {
        [UsedImplicitly]
        public static void LoadFunctionPointer(this ILGenerator generator, MethodInfo method)
            => generator.Emit(OpCodes.Ldftn, method);

        [UsedImplicitly]
        public static void LoadVirtualFunctionPointer(this ILGenerator generator, MethodInfo method)
            => generator.Emit(OpCodes.Ldvirtftn, method);
    }
}
