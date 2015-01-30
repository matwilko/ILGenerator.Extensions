using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    public static partial class MethodFlow
    {
		/// <summary>
        /// Calls the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
		[PublicAPI]
		public static void Call<T>(this ILGenerator generator, Expression<Action<T>> methodExpression)
			=> generator.Call(GetMethodInfo(methodExpression));

		/// <summary>
        /// Calls the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void CallVirtual<T>(this ILGenerator generator, Expression<Action<T>> methodExpression)
			=> generator.CallVirtual(GetMethodInfo(methodExpression));


        /// <summary>
        /// Performs a tail call to the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCall<T>(this ILGenerator generator, Expression<Action<T>> methodExpression)
			=> generator.TailCall(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a tail call to the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCallVirtual<T>(this ILGenerator generator, Expression<Action<T>> methodExpression)
			=> generator.TailCallVirtual(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedCall<T>(this ILGenerator generator, Type constrainedType, Expression<Action<T>> methodExpression)
			=> generator.ConstrainedCall(constrainedType, GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual tail call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall<T>(this ILGenerator generator, Type constrainedType, Expression<Action<T>> methodExpression)
			=> generator.ConstrainedTailCall(constrainedType, GetMethodInfo(methodExpression));

		private static MethodInfo GetMethodInfo<T>(Expression<Action<T>> methodExpression)
		{
			var method = (methodExpression?.Body as MethodCallExpression)?.Method;

			if (method == null)
			{
				throw new InvalidOperationException("Expression does not represent a method call");
			}

			return method;
		}
		/// <summary>
        /// Calls the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
		[PublicAPI]
		public static void Call(this ILGenerator generator, Expression<Action> methodExpression)
			=> generator.Call(GetMethodInfo(methodExpression));

		/// <summary>
        /// Calls the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void CallVirtual(this ILGenerator generator, Expression<Action> methodExpression)
			=> generator.CallVirtual(GetMethodInfo(methodExpression));


        /// <summary>
        /// Performs a tail call to the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCall(this ILGenerator generator, Expression<Action> methodExpression)
			=> generator.TailCall(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a tail call to the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCallVirtual(this ILGenerator generator, Expression<Action> methodExpression)
			=> generator.TailCallVirtual(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedCall(this ILGenerator generator, Type constrainedType, Expression<Action> methodExpression)
			=> generator.ConstrainedCall(constrainedType, GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual tail call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall(this ILGenerator generator, Type constrainedType, Expression<Action> methodExpression)
			=> generator.ConstrainedTailCall(constrainedType, GetMethodInfo(methodExpression));

		private static MethodInfo GetMethodInfo(Expression<Action> methodExpression)
		{
			var method = (methodExpression?.Body as MethodCallExpression)?.Method;

			if (method == null)
			{
				throw new InvalidOperationException("Expression does not represent a method call");
			}

			return method;
		}
		/// <summary>
        /// Calls the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
		[PublicAPI]
		public static void Call<T1, T2>(this ILGenerator generator, Expression<Action<T1, T2>> methodExpression)
			=> generator.Call(GetMethodInfo(methodExpression));

		/// <summary>
        /// Calls the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void CallVirtual<T1, T2>(this ILGenerator generator, Expression<Action<T1, T2>> methodExpression)
			=> generator.CallVirtual(GetMethodInfo(methodExpression));


        /// <summary>
        /// Performs a tail call to the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCall<T1, T2>(this ILGenerator generator, Expression<Action<T1, T2>> methodExpression)
			=> generator.TailCall(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a tail call to the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCallVirtual<T1, T2>(this ILGenerator generator, Expression<Action<T1, T2>> methodExpression)
			=> generator.TailCallVirtual(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedCall<T1, T2>(this ILGenerator generator, Type constrainedType, Expression<Action<T1, T2>> methodExpression)
			=> generator.ConstrainedCall(constrainedType, GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual tail call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall<T1, T2>(this ILGenerator generator, Type constrainedType, Expression<Action<T1, T2>> methodExpression)
			=> generator.ConstrainedTailCall(constrainedType, GetMethodInfo(methodExpression));

		private static MethodInfo GetMethodInfo<T1, T2>(Expression<Action<T1, T2>> methodExpression)
		{
			var method = (methodExpression?.Body as MethodCallExpression)?.Method;

			if (method == null)
			{
				throw new InvalidOperationException("Expression does not represent a method call");
			}

			return method;
		}
		/// <summary>
        /// Calls the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
		[PublicAPI]
		public static void Call<T1, T2, T3>(this ILGenerator generator, Expression<Action<T1, T2, T3>> methodExpression)
			=> generator.Call(GetMethodInfo(methodExpression));

		/// <summary>
        /// Calls the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void CallVirtual<T1, T2, T3>(this ILGenerator generator, Expression<Action<T1, T2, T3>> methodExpression)
			=> generator.CallVirtual(GetMethodInfo(methodExpression));


        /// <summary>
        /// Performs a tail call to the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCall<T1, T2, T3>(this ILGenerator generator, Expression<Action<T1, T2, T3>> methodExpression)
			=> generator.TailCall(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a tail call to the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCallVirtual<T1, T2, T3>(this ILGenerator generator, Expression<Action<T1, T2, T3>> methodExpression)
			=> generator.TailCallVirtual(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedCall<T1, T2, T3>(this ILGenerator generator, Type constrainedType, Expression<Action<T1, T2, T3>> methodExpression)
			=> generator.ConstrainedCall(constrainedType, GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual tail call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall<T1, T2, T3>(this ILGenerator generator, Type constrainedType, Expression<Action<T1, T2, T3>> methodExpression)
			=> generator.ConstrainedTailCall(constrainedType, GetMethodInfo(methodExpression));

		private static MethodInfo GetMethodInfo<T1, T2, T3>(Expression<Action<T1, T2, T3>> methodExpression)
		{
			var method = (methodExpression?.Body as MethodCallExpression)?.Method;

			if (method == null)
			{
				throw new InvalidOperationException("Expression does not represent a method call");
			}

			return method;
		}
		/// <summary>
        /// Calls the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
		[PublicAPI]
		public static void Call<T1, T2, T3, T4>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4>> methodExpression)
			=> generator.Call(GetMethodInfo(methodExpression));

		/// <summary>
        /// Calls the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void CallVirtual<T1, T2, T3, T4>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4>> methodExpression)
			=> generator.CallVirtual(GetMethodInfo(methodExpression));


        /// <summary>
        /// Performs a tail call to the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCall<T1, T2, T3, T4>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4>> methodExpression)
			=> generator.TailCall(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a tail call to the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCallVirtual<T1, T2, T3, T4>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4>> methodExpression)
			=> generator.TailCallVirtual(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedCall<T1, T2, T3, T4>(this ILGenerator generator, Type constrainedType, Expression<Action<T1, T2, T3, T4>> methodExpression)
			=> generator.ConstrainedCall(constrainedType, GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual tail call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall<T1, T2, T3, T4>(this ILGenerator generator, Type constrainedType, Expression<Action<T1, T2, T3, T4>> methodExpression)
			=> generator.ConstrainedTailCall(constrainedType, GetMethodInfo(methodExpression));

		private static MethodInfo GetMethodInfo<T1, T2, T3, T4>(Expression<Action<T1, T2, T3, T4>> methodExpression)
		{
			var method = (methodExpression?.Body as MethodCallExpression)?.Method;

			if (method == null)
			{
				throw new InvalidOperationException("Expression does not represent a method call");
			}

			return method;
		}
		/// <summary>
        /// Calls the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
		[PublicAPI]
		public static void Call<TResult>(this ILGenerator generator, Expression<Func<TResult>> methodExpression)
			=> generator.Call(GetMethodInfo(methodExpression));

		/// <summary>
        /// Calls the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void CallVirtual<TResult>(this ILGenerator generator, Expression<Func<TResult>> methodExpression)
			=> generator.CallVirtual(GetMethodInfo(methodExpression));


        /// <summary>
        /// Performs a tail call to the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCall<TResult>(this ILGenerator generator, Expression<Func<TResult>> methodExpression)
			=> generator.TailCall(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a tail call to the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCallVirtual<TResult>(this ILGenerator generator, Expression<Func<TResult>> methodExpression)
			=> generator.TailCallVirtual(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedCall<TResult>(this ILGenerator generator, Type constrainedType, Expression<Func<TResult>> methodExpression)
			=> generator.ConstrainedCall(constrainedType, GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual tail call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall<TResult>(this ILGenerator generator, Type constrainedType, Expression<Func<TResult>> methodExpression)
			=> generator.ConstrainedTailCall(constrainedType, GetMethodInfo(methodExpression));

		private static MethodInfo GetMethodInfo<TResult>(Expression<Func<TResult>> methodExpression)
		{
			var method = (methodExpression?.Body as MethodCallExpression)?.Method;

			if (method == null)
			{
				throw new InvalidOperationException("Expression does not represent a method call");
			}

			return method;
		}
		/// <summary>
        /// Calls the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
		[PublicAPI]
		public static void Call<T, TResult>(this ILGenerator generator, Expression<Func<T, TResult>> methodExpression)
			=> generator.Call(GetMethodInfo(methodExpression));

		/// <summary>
        /// Calls the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void CallVirtual<T, TResult>(this ILGenerator generator, Expression<Func<T, TResult>> methodExpression)
			=> generator.CallVirtual(GetMethodInfo(methodExpression));


        /// <summary>
        /// Performs a tail call to the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCall<T, TResult>(this ILGenerator generator, Expression<Func<T, TResult>> methodExpression)
			=> generator.TailCall(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a tail call to the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCallVirtual<T, TResult>(this ILGenerator generator, Expression<Func<T, TResult>> methodExpression)
			=> generator.TailCallVirtual(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedCall<T, TResult>(this ILGenerator generator, Type constrainedType, Expression<Func<T, TResult>> methodExpression)
			=> generator.ConstrainedCall(constrainedType, GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual tail call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall<T, TResult>(this ILGenerator generator, Type constrainedType, Expression<Func<T, TResult>> methodExpression)
			=> generator.ConstrainedTailCall(constrainedType, GetMethodInfo(methodExpression));

		private static MethodInfo GetMethodInfo<T, TResult>(Expression<Func<T, TResult>> methodExpression)
		{
			var method = (methodExpression?.Body as MethodCallExpression)?.Method;

			if (method == null)
			{
				throw new InvalidOperationException("Expression does not represent a method call");
			}

			return method;
		}
		/// <summary>
        /// Calls the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
		[PublicAPI]
		public static void Call<T1, T2, TResult>(this ILGenerator generator, Expression<Func<T1, T2, TResult>> methodExpression)
			=> generator.Call(GetMethodInfo(methodExpression));

		/// <summary>
        /// Calls the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void CallVirtual<T1, T2, TResult>(this ILGenerator generator, Expression<Func<T1, T2, TResult>> methodExpression)
			=> generator.CallVirtual(GetMethodInfo(methodExpression));


        /// <summary>
        /// Performs a tail call to the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCall<T1, T2, TResult>(this ILGenerator generator, Expression<Func<T1, T2, TResult>> methodExpression)
			=> generator.TailCall(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a tail call to the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCallVirtual<T1, T2, TResult>(this ILGenerator generator, Expression<Func<T1, T2, TResult>> methodExpression)
			=> generator.TailCallVirtual(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedCall<T1, T2, TResult>(this ILGenerator generator, Type constrainedType, Expression<Func<T1, T2, TResult>> methodExpression)
			=> generator.ConstrainedCall(constrainedType, GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual tail call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall<T1, T2, TResult>(this ILGenerator generator, Type constrainedType, Expression<Func<T1, T2, TResult>> methodExpression)
			=> generator.ConstrainedTailCall(constrainedType, GetMethodInfo(methodExpression));

		private static MethodInfo GetMethodInfo<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> methodExpression)
		{
			var method = (methodExpression?.Body as MethodCallExpression)?.Method;

			if (method == null)
			{
				throw new InvalidOperationException("Expression does not represent a method call");
			}

			return method;
		}
		/// <summary>
        /// Calls the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
		[PublicAPI]
		public static void Call<T1, T2, T3, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, TResult>> methodExpression)
			=> generator.Call(GetMethodInfo(methodExpression));

		/// <summary>
        /// Calls the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void CallVirtual<T1, T2, T3, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, TResult>> methodExpression)
			=> generator.CallVirtual(GetMethodInfo(methodExpression));


        /// <summary>
        /// Performs a tail call to the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCall<T1, T2, T3, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, TResult>> methodExpression)
			=> generator.TailCall(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a tail call to the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCallVirtual<T1, T2, T3, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, TResult>> methodExpression)
			=> generator.TailCallVirtual(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedCall<T1, T2, T3, TResult>(this ILGenerator generator, Type constrainedType, Expression<Func<T1, T2, T3, TResult>> methodExpression)
			=> generator.ConstrainedCall(constrainedType, GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual tail call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall<T1, T2, T3, TResult>(this ILGenerator generator, Type constrainedType, Expression<Func<T1, T2, T3, TResult>> methodExpression)
			=> generator.ConstrainedTailCall(constrainedType, GetMethodInfo(methodExpression));

		private static MethodInfo GetMethodInfo<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> methodExpression)
		{
			var method = (methodExpression?.Body as MethodCallExpression)?.Method;

			if (method == null)
			{
				throw new InvalidOperationException("Expression does not represent a method call");
			}

			return method;
		}
		/// <summary>
        /// Calls the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
		[PublicAPI]
		public static void Call<T1, T2, T3, T4, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, TResult>> methodExpression)
			=> generator.Call(GetMethodInfo(methodExpression));

		/// <summary>
        /// Calls the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void CallVirtual<T1, T2, T3, T4, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, TResult>> methodExpression)
			=> generator.CallVirtual(GetMethodInfo(methodExpression));


        /// <summary>
        /// Performs a tail call to the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCall<T1, T2, T3, T4, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, TResult>> methodExpression)
			=> generator.TailCall(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a tail call to the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCallVirtual<T1, T2, T3, T4, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, TResult>> methodExpression)
			=> generator.TailCallVirtual(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedCall<T1, T2, T3, T4, TResult>(this ILGenerator generator, Type constrainedType, Expression<Func<T1, T2, T3, T4, TResult>> methodExpression)
			=> generator.ConstrainedCall(constrainedType, GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual tail call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall<T1, T2, T3, T4, TResult>(this ILGenerator generator, Type constrainedType, Expression<Func<T1, T2, T3, T4, TResult>> methodExpression)
			=> generator.ConstrainedTailCall(constrainedType, GetMethodInfo(methodExpression));

		private static MethodInfo GetMethodInfo<T1, T2, T3, T4, TResult>(Expression<Func<T1, T2, T3, T4, TResult>> methodExpression)
		{
			var method = (methodExpression?.Body as MethodCallExpression)?.Method;

			if (method == null)
			{
				throw new InvalidOperationException("Expression does not represent a method call");
			}

			return method;
		}
		/// <summary>
        /// Calls the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
		[PublicAPI]
		public static void Call<T1, T2, T3, T4, T5>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4, T5>> methodExpression)
			=> generator.Call(GetMethodInfo(methodExpression));

		/// <summary>
        /// Calls the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void CallVirtual<T1, T2, T3, T4, T5>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4, T5>> methodExpression)
			=> generator.CallVirtual(GetMethodInfo(methodExpression));


        /// <summary>
        /// Performs a tail call to the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCall<T1, T2, T3, T4, T5>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4, T5>> methodExpression)
			=> generator.TailCall(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a tail call to the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCallVirtual<T1, T2, T3, T4, T5>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4, T5>> methodExpression)
			=> generator.TailCallVirtual(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedCall<T1, T2, T3, T4, T5>(this ILGenerator generator, Type constrainedType, Expression<Action<T1, T2, T3, T4, T5>> methodExpression)
			=> generator.ConstrainedCall(constrainedType, GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual tail call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall<T1, T2, T3, T4, T5>(this ILGenerator generator, Type constrainedType, Expression<Action<T1, T2, T3, T4, T5>> methodExpression)
			=> generator.ConstrainedTailCall(constrainedType, GetMethodInfo(methodExpression));

		private static MethodInfo GetMethodInfo<T1, T2, T3, T4, T5>(Expression<Action<T1, T2, T3, T4, T5>> methodExpression)
		{
			var method = (methodExpression?.Body as MethodCallExpression)?.Method;

			if (method == null)
			{
				throw new InvalidOperationException("Expression does not represent a method call");
			}

			return method;
		}
		/// <summary>
        /// Calls the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
		[PublicAPI]
		public static void Call<T1, T2, T3, T4, T5, T6>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4, T5, T6>> methodExpression)
			=> generator.Call(GetMethodInfo(methodExpression));

		/// <summary>
        /// Calls the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void CallVirtual<T1, T2, T3, T4, T5, T6>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4, T5, T6>> methodExpression)
			=> generator.CallVirtual(GetMethodInfo(methodExpression));


        /// <summary>
        /// Performs a tail call to the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCall<T1, T2, T3, T4, T5, T6>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4, T5, T6>> methodExpression)
			=> generator.TailCall(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a tail call to the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCallVirtual<T1, T2, T3, T4, T5, T6>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4, T5, T6>> methodExpression)
			=> generator.TailCallVirtual(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedCall<T1, T2, T3, T4, T5, T6>(this ILGenerator generator, Type constrainedType, Expression<Action<T1, T2, T3, T4, T5, T6>> methodExpression)
			=> generator.ConstrainedCall(constrainedType, GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual tail call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall<T1, T2, T3, T4, T5, T6>(this ILGenerator generator, Type constrainedType, Expression<Action<T1, T2, T3, T4, T5, T6>> methodExpression)
			=> generator.ConstrainedTailCall(constrainedType, GetMethodInfo(methodExpression));

		private static MethodInfo GetMethodInfo<T1, T2, T3, T4, T5, T6>(Expression<Action<T1, T2, T3, T4, T5, T6>> methodExpression)
		{
			var method = (methodExpression?.Body as MethodCallExpression)?.Method;

			if (method == null)
			{
				throw new InvalidOperationException("Expression does not represent a method call");
			}

			return method;
		}
		/// <summary>
        /// Calls the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
		[PublicAPI]
		public static void Call<T1, T2, T3, T4, T5, T6, T7>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4, T5, T6, T7>> methodExpression)
			=> generator.Call(GetMethodInfo(methodExpression));

		/// <summary>
        /// Calls the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void CallVirtual<T1, T2, T3, T4, T5, T6, T7>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4, T5, T6, T7>> methodExpression)
			=> generator.CallVirtual(GetMethodInfo(methodExpression));


        /// <summary>
        /// Performs a tail call to the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCall<T1, T2, T3, T4, T5, T6, T7>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4, T5, T6, T7>> methodExpression)
			=> generator.TailCall(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a tail call to the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCallVirtual<T1, T2, T3, T4, T5, T6, T7>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4, T5, T6, T7>> methodExpression)
			=> generator.TailCallVirtual(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedCall<T1, T2, T3, T4, T5, T6, T7>(this ILGenerator generator, Type constrainedType, Expression<Action<T1, T2, T3, T4, T5, T6, T7>> methodExpression)
			=> generator.ConstrainedCall(constrainedType, GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual tail call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall<T1, T2, T3, T4, T5, T6, T7>(this ILGenerator generator, Type constrainedType, Expression<Action<T1, T2, T3, T4, T5, T6, T7>> methodExpression)
			=> generator.ConstrainedTailCall(constrainedType, GetMethodInfo(methodExpression));

		private static MethodInfo GetMethodInfo<T1, T2, T3, T4, T5, T6, T7>(Expression<Action<T1, T2, T3, T4, T5, T6, T7>> methodExpression)
		{
			var method = (methodExpression?.Body as MethodCallExpression)?.Method;

			if (method == null)
			{
				throw new InvalidOperationException("Expression does not represent a method call");
			}

			return method;
		}
		/// <summary>
        /// Calls the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
		[PublicAPI]
		public static void Call<T1, T2, T3, T4, T5, T6, T7, T8>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> methodExpression)
			=> generator.Call(GetMethodInfo(methodExpression));

		/// <summary>
        /// Calls the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void CallVirtual<T1, T2, T3, T4, T5, T6, T7, T8>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> methodExpression)
			=> generator.CallVirtual(GetMethodInfo(methodExpression));


        /// <summary>
        /// Performs a tail call to the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCall<T1, T2, T3, T4, T5, T6, T7, T8>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> methodExpression)
			=> generator.TailCall(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a tail call to the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCallVirtual<T1, T2, T3, T4, T5, T6, T7, T8>(this ILGenerator generator, Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> methodExpression)
			=> generator.TailCallVirtual(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedCall<T1, T2, T3, T4, T5, T6, T7, T8>(this ILGenerator generator, Type constrainedType, Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> methodExpression)
			=> generator.ConstrainedCall(constrainedType, GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual tail call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall<T1, T2, T3, T4, T5, T6, T7, T8>(this ILGenerator generator, Type constrainedType, Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> methodExpression)
			=> generator.ConstrainedTailCall(constrainedType, GetMethodInfo(methodExpression));

		private static MethodInfo GetMethodInfo<T1, T2, T3, T4, T5, T6, T7, T8>(Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> methodExpression)
		{
			var method = (methodExpression?.Body as MethodCallExpression)?.Method;

			if (method == null)
			{
				throw new InvalidOperationException("Expression does not represent a method call");
			}

			return method;
		}
		/// <summary>
        /// Calls the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
		[PublicAPI]
		public static void Call<T1, T2, T3, T4, T5, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, T5, TResult>> methodExpression)
			=> generator.Call(GetMethodInfo(methodExpression));

		/// <summary>
        /// Calls the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void CallVirtual<T1, T2, T3, T4, T5, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, T5, TResult>> methodExpression)
			=> generator.CallVirtual(GetMethodInfo(methodExpression));


        /// <summary>
        /// Performs a tail call to the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCall<T1, T2, T3, T4, T5, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, T5, TResult>> methodExpression)
			=> generator.TailCall(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a tail call to the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCallVirtual<T1, T2, T3, T4, T5, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, T5, TResult>> methodExpression)
			=> generator.TailCallVirtual(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedCall<T1, T2, T3, T4, T5, TResult>(this ILGenerator generator, Type constrainedType, Expression<Func<T1, T2, T3, T4, T5, TResult>> methodExpression)
			=> generator.ConstrainedCall(constrainedType, GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual tail call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall<T1, T2, T3, T4, T5, TResult>(this ILGenerator generator, Type constrainedType, Expression<Func<T1, T2, T3, T4, T5, TResult>> methodExpression)
			=> generator.ConstrainedTailCall(constrainedType, GetMethodInfo(methodExpression));

		private static MethodInfo GetMethodInfo<T1, T2, T3, T4, T5, TResult>(Expression<Func<T1, T2, T3, T4, T5, TResult>> methodExpression)
		{
			var method = (methodExpression?.Body as MethodCallExpression)?.Method;

			if (method == null)
			{
				throw new InvalidOperationException("Expression does not represent a method call");
			}

			return method;
		}
		/// <summary>
        /// Calls the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
		[PublicAPI]
		public static void Call<T1, T2, T3, T4, T5, T6, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> methodExpression)
			=> generator.Call(GetMethodInfo(methodExpression));

		/// <summary>
        /// Calls the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void CallVirtual<T1, T2, T3, T4, T5, T6, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> methodExpression)
			=> generator.CallVirtual(GetMethodInfo(methodExpression));


        /// <summary>
        /// Performs a tail call to the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCall<T1, T2, T3, T4, T5, T6, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> methodExpression)
			=> generator.TailCall(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a tail call to the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCallVirtual<T1, T2, T3, T4, T5, T6, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> methodExpression)
			=> generator.TailCallVirtual(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedCall<T1, T2, T3, T4, T5, T6, TResult>(this ILGenerator generator, Type constrainedType, Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> methodExpression)
			=> generator.ConstrainedCall(constrainedType, GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual tail call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall<T1, T2, T3, T4, T5, T6, TResult>(this ILGenerator generator, Type constrainedType, Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> methodExpression)
			=> generator.ConstrainedTailCall(constrainedType, GetMethodInfo(methodExpression));

		private static MethodInfo GetMethodInfo<T1, T2, T3, T4, T5, T6, TResult>(Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> methodExpression)
		{
			var method = (methodExpression?.Body as MethodCallExpression)?.Method;

			if (method == null)
			{
				throw new InvalidOperationException("Expression does not represent a method call");
			}

			return method;
		}
		/// <summary>
        /// Calls the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
		[PublicAPI]
		public static void Call<T1, T2, T3, T4, T5, T6, T7, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> methodExpression)
			=> generator.Call(GetMethodInfo(methodExpression));

		/// <summary>
        /// Calls the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void CallVirtual<T1, T2, T3, T4, T5, T6, T7, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> methodExpression)
			=> generator.CallVirtual(GetMethodInfo(methodExpression));


        /// <summary>
        /// Performs a tail call to the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCall<T1, T2, T3, T4, T5, T6, T7, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> methodExpression)
			=> generator.TailCall(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a tail call to the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCallVirtual<T1, T2, T3, T4, T5, T6, T7, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> methodExpression)
			=> generator.TailCallVirtual(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedCall<T1, T2, T3, T4, T5, T6, T7, TResult>(this ILGenerator generator, Type constrainedType, Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> methodExpression)
			=> generator.ConstrainedCall(constrainedType, GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual tail call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall<T1, T2, T3, T4, T5, T6, T7, TResult>(this ILGenerator generator, Type constrainedType, Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> methodExpression)
			=> generator.ConstrainedTailCall(constrainedType, GetMethodInfo(methodExpression));

		private static MethodInfo GetMethodInfo<T1, T2, T3, T4, T5, T6, T7, TResult>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> methodExpression)
		{
			var method = (methodExpression?.Body as MethodCallExpression)?.Method;

			if (method == null)
			{
				throw new InvalidOperationException("Expression does not represent a method call");
			}

			return method;
		}
		/// <summary>
        /// Calls the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
		[PublicAPI]
		public static void Call<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> methodExpression)
			=> generator.Call(GetMethodInfo(methodExpression));

		/// <summary>
        /// Calls the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void CallVirtual<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> methodExpression)
			=> generator.CallVirtual(GetMethodInfo(methodExpression));


        /// <summary>
        /// Performs a tail call to the method represented by the given expression, popping the requisite number of arguments from the evaluation stack (including the this reference if it is an instance method)
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCall<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> methodExpression)
			=> generator.TailCall(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a tail call to the method represented by the given expression with virtual semantics, popping a reference (and performing a null check) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void TailCallVirtual<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this ILGenerator generator, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> methodExpression)
			=> generator.TailCallVirtual(GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedCall<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this ILGenerator generator, Type constrainedType, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> methodExpression)
			=> generator.ConstrainedCall(constrainedType, GetMethodInfo(methodExpression));

        /// <summary>
        /// Performs a constrained virtual tail call to the method represented by the given expression, popping an address to storage location of the value or reference (and performing a null check if necessary) and the requisite number of arguments from the evaluation stack
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="constrainedType">The type to constrain the call to</param>
        /// <param name="methodExpression">The expression representing the method to call</param>
        [PublicAPI]
        public static void ConstrainedTailCall<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this ILGenerator generator, Type constrainedType, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> methodExpression)
			=> generator.ConstrainedTailCall(constrainedType, GetMethodInfo(methodExpression));

		private static MethodInfo GetMethodInfo<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> methodExpression)
		{
			var method = (methodExpression?.Body as MethodCallExpression)?.Method;

			if (method == null)
			{
				throw new InvalidOperationException("Expression does not represent a method call");
			}

			return method;
		}
	}
}	