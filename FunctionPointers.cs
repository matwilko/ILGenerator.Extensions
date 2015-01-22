using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    public static class FunctionPointers
    {
        [PublicAPI]
        public static void LoadFunctionPointer(this ILGenerator generator, MethodInfo method)
            => generator.Emit(OpCodes.Ldftn, method);

        [PublicAPI]
        public static void LoadVirtualFunctionPointer(this ILGenerator generator, MethodInfo method)
            => generator.Emit(OpCodes.Ldvirtftn, method);
    }
}
