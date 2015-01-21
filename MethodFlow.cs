using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public static class MethodFlow
    {
        public static void JumpTo(this ILGenerator generator, MethodInfo method) => generator.Emit(OpCodes.Jmp, method);

        public static void Call(this ILGenerator generator, MethodInfo method) => generator.Emit(OpCodes.Call, method);

        public static void CallVirtual(this ILGenerator generator, MethodInfo method) => generator.Emit(OpCodes.Callvirt, method);

        public static void TailCall(this ILGenerator generator, MethodInfo method)
        {
            generator.Emit(OpCodes.Tailcall);
            generator.Emit(OpCodes.Call, method);
        }

        public static void TailCallVirtual(this ILGenerator generator, MethodInfo method)
        {
            generator.Emit(OpCodes.Tailcall);
            generator.Emit(OpCodes.Callvirt, method);
        }

        public static void ConstrainedCall<T>(this ILGenerator generator, MethodInfo method)
        {
            generator.ConstrainedCall(typeof (T), method);
        }

        public static void ConstrainedCall(this ILGenerator generator, Type constrainedType, MethodInfo method)
        {
            generator.Emit(OpCodes.Constrained, constrainedType);
            generator.Emit(OpCodes.Callvirt, method);
        }

        public static void ConstrainedTailCall<T>(this ILGenerator generator, MethodInfo method)
        {
            generator.ConstrainedTailCall(typeof(T), method);
        }

        public static void ConstrainedTailCall(this ILGenerator generator, Type constrainedType, MethodInfo method)
        {
            generator.Emit(OpCodes.Constrained, constrainedType);
            generator.Emit(OpCodes.Tailcall);
            generator.Emit(OpCodes.Callvirt, method);
        }

        public static void Return(this ILGenerator generator) => generator.Emit(OpCodes.Ret);
    }
}
