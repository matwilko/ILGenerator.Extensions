using System.Reflection;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public static class FunctionPointers
    {
        public static void LoadFunctionPointer(this ILGenerator generator, MethodInfo method)
            => generator.Emit(OpCodes.Ldftn, method);

        public static void LoadVirtualFunctionPointer(this ILGenerator generator, MethodInfo method)
            => generator.Emit(OpCodes.Ldvirtftn, method);
    }
}
