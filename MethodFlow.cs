using System;
using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    [PublicAPI]
    public static partial class MethodFlow
    {
        /// <summary>
        /// Exits the current method and jumps immediately to the given method, using the same arguments
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="method">The method to jump to</param>
        [PublicAPI]
        public static ILGenerator JumpTo(this ILGenerator generator, MethodInfo method) => generator.FluentEmit(OpCodes.Jmp, method);

        /// <summary>
        /// Calls the given method, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="method">The method to call</param>
        [PublicAPI]
        public static ILGenerator Call(this ILGenerator generator, MethodInfo method) => generator.FluentEmit(OpCodes.Call, method);

        /// <summary>
        /// Calls the given method with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="method">The method to call</param>
        [PublicAPI]
        public static ILGenerator CallVirtual(this ILGenerator generator, MethodInfo method) => generator.FluentEmit(OpCodes.Callvirt, method);

        /// <summary>
        /// Performs a tail call to the given method, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="method">The method to call</param>
        [PublicAPI]
        public static ILGenerator TailCall(this ILGenerator generator, MethodInfo method)
        {
            return generator.FluentEmit(OpCodes.Tailcall)
                            .FluentEmit(OpCodes.Call, method);
        }

        /// <summary>
        /// Performs a tail call to the given method with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="method">The method to call</param>
        [PublicAPI]
        public static ILGenerator TailCallVirtual(this ILGenerator generator, MethodInfo method)
        {
            return generator.FluentEmit(OpCodes.Tailcall)
                            .FluentEmit(OpCodes.Callvirt, method);
        }

        /// <summary>
        /// Performs a constrained virtual call to the given method, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <typeparam name="T">The type to constrain the call to</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="method">The method to call</param>
        [PublicAPI]
        public static ILGenerator ConstrainedCall<T>(this ILGenerator generator, MethodInfo method)
            => generator.ConstrainedCall(typeof (T), method);

        /// <summary>
        /// Performs a constrained virtual call to the given method, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="method">The method to call</param>
        [PublicAPI]
        public static ILGenerator ConstrainedCall(this ILGenerator generator, Type constrainedType, MethodInfo method)
        {
            return generator.FluentEmit(OpCodes.Constrained, constrainedType)
                            .FluentEmit(OpCodes.Callvirt, method);
        }

        /// <summary>
        /// Performs a constrained virtual tail call to the given method, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <typeparam name="T">The type to constrain the call to</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="method">The method to call</param>
        [PublicAPI]
        public static ILGenerator ConstrainedTailCall<T>(this ILGenerator generator, MethodInfo method)
            => generator.ConstrainedTailCall(typeof(T), method);

        /// <summary>
        /// Performs a constrained virtual tail call to the given method, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="method">The method to call</param>
        [PublicAPI]
        public static ILGenerator ConstrainedTailCall(this ILGenerator generator, Type constrainedType, MethodInfo method)
        {
            return generator.FluentEmit(OpCodes.Constrained, constrainedType)
                            .FluentEmit(OpCodes.Tailcall)
                            .FluentEmit(OpCodes.Callvirt, method);
        }

        /// <summary>
        /// Pops a value from the evaluation stack and returns it to the calling method
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator Return(this ILGenerator generator) => generator.FluentEmit(OpCodes.Ret);
    }
}
