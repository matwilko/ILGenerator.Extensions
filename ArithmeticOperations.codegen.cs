using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
	[PublicAPI]
	public static partial class ArithmeticOperations
	{
		#region Add

		/// <summary>
        /// Pops two values from the top of the evaluation stack and adds them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator Add(this ILGenerator generator) => generator.FluentEmit(OpCodes.Add);

		/// <summary>
        /// Pops two values from the top of the evaluation stack and adds them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator AddWithOverflowCheck(this ILGenerator generator) => generator.FluentEmit(OpCodes.Add_Ovf);

		/// <summary>
        /// Pops two values from the top of the evaluation stack and adds them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator AddUnsignedWithOverflowCheck(this ILGenerator generator) => generator.FluentEmit(OpCodes.Add_Ovf_Un);

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to add the evaluation stack value to</param>
		[PublicAPI]
		public static ILGenerator AddTo(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.Add();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to add the evaluation stack value to</param>
		[PublicAPI]
		public static ILGenerator AddToWithOverflowCheck(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.AddWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value adds them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to add the evaluation stack value to</param>
		[PublicAPI]
		public static ILGenerator AddToUnsignedWithOverflowCheck(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.AddUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to add the evaluation stack value to</param>
		[PublicAPI]
		public static ILGenerator AddTo(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.Add();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to add the evaluation stack value to</param>
		[PublicAPI]
		public static ILGenerator AddToWithOverflowCheck(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.AddWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value adds them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to add the evaluation stack value to</param>
		[PublicAPI]
		public static ILGenerator AddToUnsignedWithOverflowCheck(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.AddUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to add the evaluation stack value to</param>
		[PublicAPI]
		public static ILGenerator AddTo(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.Add();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to add the evaluation stack value to</param>
		[PublicAPI]
		public static ILGenerator AddToWithOverflowCheck(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.AddWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value adds them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to add the evaluation stack value to</param>
		[PublicAPI]
		public static ILGenerator AddToUnsignedWithOverflowCheck(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.AddUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to add the evaluation stack value to</param>
		[PublicAPI]
		public static ILGenerator AddTo(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.Add();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to add the evaluation stack value to</param>
		[PublicAPI]
		public static ILGenerator AddToWithOverflowCheck(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.AddWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value adds them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to add the evaluation stack value to</param>
		[PublicAPI]
		public static ILGenerator AddToUnsignedWithOverflowCheck(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.AddUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to add the evaluation stack value to</param>
		[PublicAPI]
		public static ILGenerator AddTo(this ILGenerator generator, Single value)
		{
			return generator.LoadConstant(value)
							.Add();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to add the evaluation stack value to</param>
		[PublicAPI]
		public static ILGenerator AddToWithOverflowCheck(this ILGenerator generator, Single value)
		{
			return generator.LoadConstant(value)
							.AddWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value adds them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to add the evaluation stack value to</param>
		[PublicAPI]
		public static ILGenerator AddToUnsignedWithOverflowCheck(this ILGenerator generator, Single value)
		{
			return generator.LoadConstant(value)
							.AddUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to add the evaluation stack value to</param>
		[PublicAPI]
		public static ILGenerator AddTo(this ILGenerator generator, Double value)
		{
			return generator.LoadConstant(value)
							.Add();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to add the evaluation stack value to</param>
		[PublicAPI]
		public static ILGenerator AddToWithOverflowCheck(this ILGenerator generator, Double value)
		{
			return generator.LoadConstant(value)
							.AddWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value adds them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to add the evaluation stack value to</param>
		[PublicAPI]
		public static ILGenerator AddToUnsignedWithOverflowCheck(this ILGenerator generator, Double value)
		{
			return generator.LoadConstant(value)
							.AddUnsignedWithOverflowCheck();
		}


		#endregion

		#region Divide

		/// <summary>
        /// Pops two values from the top of the evaluation stack and divides the first by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator Divide(this ILGenerator generator) => generator.FluentEmit(OpCodes.Div);

		/// <summary>
        /// Pops two values from the top of the evaluation stack and divides the first by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator DivideUnsigned(this ILGenerator generator) => generator.FluentEmit(OpCodes.Div_Un);

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator DivideBy(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.Divide();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator DivideByUnsigned(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.DivideUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator DivideBy(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.Divide();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator DivideByUnsigned(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.DivideUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator DivideBy(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.Divide();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator DivideByUnsigned(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.DivideUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator DivideBy(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.Divide();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator DivideByUnsigned(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.DivideUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator DivideBy(this ILGenerator generator, Single value)
		{
			return generator.LoadConstant(value)
							.Divide();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator DivideByUnsigned(this ILGenerator generator, Single value)
		{
			return generator.LoadConstant(value)
							.DivideUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator DivideBy(this ILGenerator generator, Double value)
		{
			return generator.LoadConstant(value)
							.Divide();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator DivideByUnsigned(this ILGenerator generator, Double value)
		{
			return generator.LoadConstant(value)
							.DivideUnsigned();
		}


		#endregion

		#region Multiply

		/// <summary>
        /// Pops two values from the top of the evaluation stack and multiples them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator Multiply(this ILGenerator generator) => generator.FluentEmit(OpCodes.Mul);

		/// <summary>
        /// Pops two values from the top of the evaluation stack and multiples them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator MultiplyWithOverflowCheck(this ILGenerator generator) => generator.FluentEmit(OpCodes.Mul_Ovf);

		/// <summary>
        /// Pops two values from the top of the evaluation stack and multiples them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator MultiplyUnsignedWithOverflowCheck(this ILGenerator generator) => generator.FluentEmit(OpCodes.Mul_Ovf_Un);

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to multiply with the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator MultiplyBy(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.Multiply();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to multiply with the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator MultiplyByWithOverflowCheck(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.MultiplyWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value multiples them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to multiply with the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator MultiplyByUnsignedWithOverflowCheck(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.MultiplyUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to multiply with the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator MultiplyBy(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.Multiply();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to multiply with the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator MultiplyByWithOverflowCheck(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.MultiplyWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value multiples them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to multiply with the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator MultiplyByUnsignedWithOverflowCheck(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.MultiplyUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to multiply with the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator MultiplyBy(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.Multiply();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to multiply with the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator MultiplyByWithOverflowCheck(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.MultiplyWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value multiples them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to multiply with the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator MultiplyByUnsignedWithOverflowCheck(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.MultiplyUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to multiply with the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator MultiplyBy(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.Multiply();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to multiply with the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator MultiplyByWithOverflowCheck(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.MultiplyWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value multiples them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to multiply with the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator MultiplyByUnsignedWithOverflowCheck(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.MultiplyUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to multiply with the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator MultiplyBy(this ILGenerator generator, Single value)
		{
			return generator.LoadConstant(value)
							.Multiply();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to multiply with the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator MultiplyByWithOverflowCheck(this ILGenerator generator, Single value)
		{
			return generator.LoadConstant(value)
							.MultiplyWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value multiples them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to multiply with the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator MultiplyByUnsignedWithOverflowCheck(this ILGenerator generator, Single value)
		{
			return generator.LoadConstant(value)
							.MultiplyUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to multiply with the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator MultiplyBy(this ILGenerator generator, Double value)
		{
			return generator.LoadConstant(value)
							.Multiply();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to multiply with the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator MultiplyByWithOverflowCheck(this ILGenerator generator, Double value)
		{
			return generator.LoadConstant(value)
							.MultiplyWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value multiples them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to multiply with the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator MultiplyByUnsignedWithOverflowCheck(this ILGenerator generator, Double value)
		{
			return generator.LoadConstant(value)
							.MultiplyUnsignedWithOverflowCheck();
		}


		#endregion

		#region Remainder

		/// <summary>
        /// Pops two values from the top of the evaluation stack and finds the remainder when the first is divided by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator Remainder(this ILGenerator generator) => generator.FluentEmit(OpCodes.Rem);

		/// <summary>
        /// Pops two values from the top of the evaluation stack and finds the remainder when the first is divided by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator RemainderUnsigned(this ILGenerator generator) => generator.FluentEmit(OpCodes.Rem_Un);

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator RemainderFrom(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.Remainder();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator RemainderFromUnsigned(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.RemainderUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator RemainderFrom(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.Remainder();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator RemainderFromUnsigned(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.RemainderUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator RemainderFrom(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.Remainder();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator RemainderFromUnsigned(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.RemainderUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator RemainderFrom(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.Remainder();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator RemainderFromUnsigned(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.RemainderUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator RemainderFrom(this ILGenerator generator, Single value)
		{
			return generator.LoadConstant(value)
							.Remainder();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator RemainderFromUnsigned(this ILGenerator generator, Single value)
		{
			return generator.LoadConstant(value)
							.RemainderUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator RemainderFrom(this ILGenerator generator, Double value)
		{
			return generator.LoadConstant(value)
							.Remainder();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to divide the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator RemainderFromUnsigned(this ILGenerator generator, Double value)
		{
			return generator.LoadConstant(value)
							.RemainderUnsigned();
		}


		#endregion

		#region Subtract

		/// <summary>
        /// Pops two values from the top of the evaluation stack and subtracts the second from the first
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator Subtract(this ILGenerator generator) => generator.FluentEmit(OpCodes.Sub);

		/// <summary>
        /// Pops two values from the top of the evaluation stack and subtracts the second from the first with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator SubtractWithOverflowCheck(this ILGenerator generator) => generator.FluentEmit(OpCodes.Sub_Ovf);

		/// <summary>
        /// Pops two values from the top of the evaluation stack and subtracts the second from the first without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator SubtractUnsignedWithOverflowCheck(this ILGenerator generator) => generator.FluentEmit(OpCodes.Sub_Ovf_Un);

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to subtract from the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator Subtract(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.Subtract();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to subtract from the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator SubtractWithOverflowCheck(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.SubtractWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value subtracts the second from the first without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to subtract from the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator SubtractUnsignedWithOverflowCheck(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.SubtractUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to subtract from the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator Subtract(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.Subtract();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to subtract from the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator SubtractWithOverflowCheck(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.SubtractWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value subtracts the second from the first without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to subtract from the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator SubtractUnsignedWithOverflowCheck(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.SubtractUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to subtract from the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator Subtract(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.Subtract();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to subtract from the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator SubtractWithOverflowCheck(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.SubtractWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value subtracts the second from the first without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to subtract from the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator SubtractUnsignedWithOverflowCheck(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.SubtractUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to subtract from the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator Subtract(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.Subtract();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to subtract from the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator SubtractWithOverflowCheck(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.SubtractWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value subtracts the second from the first without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to subtract from the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator SubtractUnsignedWithOverflowCheck(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.SubtractUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to subtract from the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator Subtract(this ILGenerator generator, Single value)
		{
			return generator.LoadConstant(value)
							.Subtract();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to subtract from the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator SubtractWithOverflowCheck(this ILGenerator generator, Single value)
		{
			return generator.LoadConstant(value)
							.SubtractWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value subtracts the second from the first without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to subtract from the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator SubtractUnsignedWithOverflowCheck(this ILGenerator generator, Single value)
		{
			return generator.LoadConstant(value)
							.SubtractUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to subtract from the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator Subtract(this ILGenerator generator, Double value)
		{
			return generator.LoadConstant(value)
							.Subtract();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to subtract from the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator SubtractWithOverflowCheck(this ILGenerator generator, Double value)
		{
			return generator.LoadConstant(value)
							.SubtractWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value subtracts the second from the first without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to subtract from the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator SubtractUnsignedWithOverflowCheck(this ILGenerator generator, Double value)
		{
			return generator.LoadConstant(value)
							.SubtractUnsignedWithOverflowCheck();
		}


		#endregion

	}
}
