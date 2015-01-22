using System;
using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [UsedImplicitly]
    public static class MethodFlow
    {
        [UsedImplicitly]
        public static void JumpTo(this ILGenerator generator, MethodInfo method) => generator.Emit(OpCodes.Jmp, method);

        [UsedImplicitly]
        public static void Call(this ILGenerator generator, MethodInfo method) => generator.Emit(OpCodes.Call, method);

        [UsedImplicitly]
        public static void CallVirtual(this ILGenerator generator, MethodInfo method) => generator.Emit(OpCodes.Callvirt, method);

        [UsedImplicitly]
        public static void TailCall(this ILGenerator generator, MethodInfo method)
        {
            generator.Emit(OpCodes.Tailcall);
            generator.Emit(OpCodes.Call, method);
        }

        [UsedImplicitly]
        public static void TailCallVirtual(this ILGenerator generator, MethodInfo method)
        {
            generator.Emit(OpCodes.Tailcall);
            generator.Emit(OpCodes.Callvirt, method);
        }

        [UsedImplicitly]
        public static void ConstrainedCall<T>(this ILGenerator generator, MethodInfo method)
        {
            generator.ConstrainedCall(typeof (T), method);
        }

        [UsedImplicitly]
        public static void ConstrainedCall(this ILGenerator generator, Type constrainedType, MethodInfo method)
        {
            generator.Emit(OpCodes.Constrained, constrainedType);
            generator.Emit(OpCodes.Callvirt, method);
        }

        [UsedImplicitly]
        public static void ConstrainedTailCall<T>(this ILGenerator generator, MethodInfo method)
        {
            generator.ConstrainedTailCall(typeof(T), method);
        }

        [UsedImplicitly]
        public static void ConstrainedTailCall(this ILGenerator generator, Type constrainedType, MethodInfo method)
        {
            generator.Emit(OpCodes.Constrained, constrainedType);
            generator.Emit(OpCodes.Tailcall);
            generator.Emit(OpCodes.Callvirt, method);
        }

        [UsedImplicitly]
        public static void Return(this ILGenerator generator) => generator.Emit(OpCodes.Ret);
    }
}
