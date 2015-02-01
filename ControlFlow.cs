using System;
using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    /// <summary>
    /// Contains extension methods for controlling the flow of the method
    /// </summary>
    public static class ControlFlow
    {
        /// <summary>
        /// Branch unconditionally to the given label
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
        [PublicAPI]
        public static ILGenerator BranchTo(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Br, label);

        /// <summary>
        /// Branch unconditionally to the given label
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
        [PublicAPI]
        public static ILGenerator BranchToShortForm(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Br_S, label);

        /// <summary>
        /// Pops an integer value from the evaluation stack and branches to the corresponding zero-indexed label in the provided list, continuing to the next instruction if the value is outside the valid range
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="labels">The labels to form a jump table from</param>
        [PublicAPI]
        public static ILGenerator Switch(this ILGenerator generator, params Label[] labels) => generator.FluentEmit(OpCodes.Switch, labels);

        /// <summary>
        /// Branch to the given label, clearing the evaluation stack; can be used to leave a protected region
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
        [PublicAPI]
        public static ILGenerator Leave(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Leave, label);

        /// <summary>
        /// Branch to the given label, clearing the evaluation stack; can be used to leave a protected region
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
        [PublicAPI]
        public static ILGenerator LeaveShortForm(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Leave_S, label);

        /// <summary>
        /// Pops a reference to an exception off the evaluation stack and throws it
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator Throw(this ILGenerator generator) => generator.FluentEmit(OpCodes.Throw);

        /// <summary>
        /// Throws an exception of the given type, using the default constructor
        /// </summary>
        /// <typeparam name="T">The type of the exception to throw</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static ILGenerator Throw<T>(this ILGenerator generator) where T : Exception, new()
        {
            generator.ThrowException(typeof (T));
            return generator;
        }

        [PublicAPI]
        private static readonly Type[] StringTypeArray = { typeof (string) };

        /// <summary>
        /// Throws an exception of the given type with the given message
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="message">The message to give the exception</param>
        /// <exception cref="InvalidOperationException">Exception type <typeparamref name="T"/> does not have a public constructor taking only a string</exception>
        [PublicAPI]
        public static ILGenerator Throw<T>(this ILGenerator generator, string message) where T : Exception
        {
            var constructor = typeof (T).GetConstructor(BindingFlags.Public | BindingFlags.Instance, null, StringTypeArray, null);

            if (constructor == null)
            {
                throw new InvalidOperationException("Exception type " + typeof (T).Name + " does not have a public constructor taking only a string");
            }

            return generator.LoadString(message)
                            .NewObject(constructor)
                            .Throw();
        }
    }
}
