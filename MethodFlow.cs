using System;
using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static class MethodFlow
    {
        /// <summary>
        /// Exits the current method and jumps immediately to the given method, using the same arguments
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="method">The method to jump to</param>
        [PublicAPI]
        public static void JumpTo(this ILGenerator generator, MethodInfo method) => generator.Emit(OpCodes.Jmp, method);

        /// <summary>
        /// Calls the given method, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="method">The method to call</param>
        [PublicAPI]
        public static void Call(this ILGenerator generator, MethodInfo method) => generator.Emit(OpCodes.Call, method);

        /// <summary>
        /// Calls the given method with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="method">The method to call</param>
        [PublicAPI]
        public static void CallVirtual(this ILGenerator generator, MethodInfo method) => generator.Emit(OpCodes.Callvirt, method);

        /// <summary>
        /// Performs a tail call to the given method, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="method">The method to call</param>
        [PublicAPI]
        public static void TailCall(this ILGenerator generator, MethodInfo method)
        {
            generator.Emit(OpCodes.Tailcall);
            generator.Emit(OpCodes.Call, method);
        }

        /// <summary>
        /// Performs a tail call to the given method with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="method">The method to call</param>
        [PublicAPI]
        public static void TailCallVirtual(this ILGenerator generator, MethodInfo method)
        {
            generator.Emit(OpCodes.Tailcall);
            generator.Emit(OpCodes.Callvirt, method);
        }

        /// <summary>
        /// Performs a constrained virtual call to the given method, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <typeparam name="T">The type to constrain the call to</typeparam>
        /// <param name="generator"></param>
        /// <param name="method">The method to call</param>
        [PublicAPI]
        public static void ConstrainedCall<T>(this ILGenerator generator, MethodInfo method)
        {
            generator.ConstrainedCall(typeof (T), method);
        }

        /// <summary>
        /// Performs a constrained virtual call to the given method, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="method">The method to call</param>
        [PublicAPI]
        public static void ConstrainedCall(this ILGenerator generator, Type constrainedType, MethodInfo method)
        {
            generator.Emit(OpCodes.Constrained, constrainedType);
            generator.Emit(OpCodes.Callvirt, method);
        }

        /// <summary>
        /// Performs a constrained virtual tail call to the given method, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <typeparam name="T">The type to constrain the call to</typeparam>
        /// <param name="generator"></param>
        /// <param name="method">The method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall<T>(this ILGenerator generator, MethodInfo method)
        {
            generator.ConstrainedTailCall(typeof(T), method);
        }

        /// <summary>
        /// Performs a constrained virtual tail call to the given method, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="method">The method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall(this ILGenerator generator, Type constrainedType, MethodInfo method)
        {
            generator.Emit(OpCodes.Constrained, constrainedType);
            generator.Emit(OpCodes.Tailcall);
            generator.Emit(OpCodes.Callvirt, method);
        }

        /// <summary>
        /// Pops a value from the evaluation stack and returns it to the calling method
        /// </summary>
        /// <param name="generator"></param>
        [PublicAPI]
        public static void Return(this ILGenerator generator) => generator.Emit(OpCodes.Ret);
    }
}
