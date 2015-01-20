using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
    public static class ControlFlow
    {
        public static void BranchTo(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Br, label);

        public static void BranchToShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Br_S, label);

        public static void Switch(this ILGenerator generator, params Label[] labels) => generator.Emit(OpCodes.Switch, labels);

        public static void Leave(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Leave, label);
        public static void LeaveShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Leave_S, label);

        public static void Throw(this ILGenerator generator) => generator.Emit(OpCodes.Throw);

        public static void Throw<T>(this ILGenerator generator) where T : Exception, new() => generator.ThrowException(typeof(T));

        private static readonly Type[] StringTypeArray = { typeof (string) };

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
