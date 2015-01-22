using System;
using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    public static class ControlFlow
    {
        [UsedImplicitly]
        public static void BranchTo(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Br, label);

        [UsedImplicitly]
        public static void BranchToShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Br_S, label);

        [UsedImplicitly]
        public static void Switch(this ILGenerator generator, params Label[] labels) => generator.Emit(OpCodes.Switch, labels);

        [UsedImplicitly]
        public static void Leave(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Leave, label);

        [UsedImplicitly]
        public static void LeaveShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Leave_S, label);

        [UsedImplicitly]
        public static void Throw(this ILGenerator generator) => generator.Emit(OpCodes.Throw);

        [UsedImplicitly]
        public static void Throw<T>(this ILGenerator generator) where T : Exception, new() => generator.ThrowException(typeof(T));

        [UsedImplicitly]
        private static readonly Type[] StringTypeArray = { typeof (string) };

        [UsedImplicitly]
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
