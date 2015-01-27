using System;
using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    public static class ControlFlow
    {
        /// <summary>
        /// Branch unconditionally to the given label
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
        [PublicAPI]
        public static void BranchTo(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Br, label);

        /// <summary>
        /// Branch unconditionally to the given label
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
        [PublicAPI]
        public static void BranchToShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Br_S, label);

        /// <summary>
        /// Pops an integer value from the stack and branches to the corresponding zero-indexed label in the provided list, continuing to the next instruction if the value is outside the valid range
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="labels">The labels to form a jump table from</param>
        [PublicAPI]
        public static void Switch(this ILGenerator generator, params Label[] labels) => generator.Emit(OpCodes.Switch, labels);

        /// <summary>
        /// Branch to the given label, clearing the execution stack; can be used to leave a protected region
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
        [PublicAPI]
        public static void Leave(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Leave, label);

        /// <summary>
        /// Branch to the given label, clearing the execution stack; can be used to leave a protected region
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
        [PublicAPI]
        public static void LeaveShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Leave_S, label);

        /// <summary>
        /// Pops a reference to an exception off the execution stack and throws it
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void Throw(this ILGenerator generator) => generator.Emit(OpCodes.Throw);

        /// <summary>
        /// Throws an exception of the given type, using the default constructor
        /// </summary>
        /// <typeparam name="T">The type of the exception to throw</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        [PublicAPI]
        public static void Throw<T>(this ILGenerator generator) where T : Exception, new() => generator.ThrowException(typeof(T));

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
        public static void Throw<T>(this ILGenerator generator, string message) where T : Exception
        {
            var constructor = typeof (T).GetConstructor(BindingFlags.Public | BindingFlags.Instance, null, StringTypeArray, null);

            if (constructor == null)
            {
                throw new InvalidOperationException("Exception type " + typeof (T).Name + " does not have a public constructor taking only a string");
            }

            generator.LoadString(message);
            generator.NewObject(constructor);
            generator.Throw();
        }
    }
}
