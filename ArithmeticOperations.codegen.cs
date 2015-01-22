using System;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
	public static partial class ArithmeticOperations
	{
		#region Add

		/// <summary>
        /// Pops two values from the top of the evaluation stack and adds them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void Add(this ILGenerator generator) => generator.Emit(OpCodes.Add);

		/// <summary>
        /// Pops two values from the top of the evaluation stack and adds them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddWithOverflowCheck(this ILGenerator generator) => generator.Emit(OpCodes.Add_Ovf);

		/// <summary>
        /// Pops two values from the top of the evaluation stack and adds them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddUnsignedWithOverflowCheck(this ILGenerator generator) => generator.Emit(OpCodes.Add_Ovf_Un);

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddTo(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.Add();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddToWithOverflowCheck(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.AddWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value adds them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddToUnsignedWithOverflowCheck(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.AddUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddTo(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.Add();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddToWithOverflowCheck(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.AddWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value adds them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddToUnsignedWithOverflowCheck(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.AddUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddTo(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.Add();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddToWithOverflowCheck(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.AddWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value adds them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddToUnsignedWithOverflowCheck(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.AddUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddTo(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.Add();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddToWithOverflowCheck(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.AddWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value adds them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddToUnsignedWithOverflowCheck(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.AddUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddTo(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.Add();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddToWithOverflowCheck(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.AddWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value adds them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddToUnsignedWithOverflowCheck(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.AddUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddTo(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.Add();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value adds them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddToWithOverflowCheck(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.AddWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value adds them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void AddToUnsignedWithOverflowCheck(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.AddUnsignedWithOverflowCheck();
		}


		#endregion

		#region Divide

		/// <summary>
        /// Pops two values from the top of the evaluation stack and divides the first by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void Divide(this ILGenerator generator) => generator.Emit(OpCodes.Div);

		/// <summary>
        /// Pops two values from the top of the evaluation stack and divides the first by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void DivideUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Div_Un);

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void DivideBy(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.Divide();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void DivideByUnsigned(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.DivideUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void DivideBy(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.Divide();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void DivideByUnsigned(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.DivideUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void DivideBy(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.Divide();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void DivideByUnsigned(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.DivideUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void DivideBy(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.Divide();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void DivideByUnsigned(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.DivideUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void DivideBy(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.Divide();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void DivideByUnsigned(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.DivideUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void DivideBy(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.Divide();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value divides the first by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void DivideByUnsigned(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.DivideUnsigned();
		}


		#endregion

		#region Multiply

		/// <summary>
        /// Pops two values from the top of the evaluation stack and multiples them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void Multiply(this ILGenerator generator) => generator.Emit(OpCodes.Mul);

		/// <summary>
        /// Pops two values from the top of the evaluation stack and multiples them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyWithOverflowCheck(this ILGenerator generator) => generator.Emit(OpCodes.Mul_Ovf);

		/// <summary>
        /// Pops two values from the top of the evaluation stack and multiples them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyUnsignedWithOverflowCheck(this ILGenerator generator) => generator.Emit(OpCodes.Mul_Ovf_Un);

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyBy(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.Multiply();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyByWithOverflowCheck(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.MultiplyWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value multiples them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyByUnsignedWithOverflowCheck(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.MultiplyUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyBy(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.Multiply();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyByWithOverflowCheck(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.MultiplyWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value multiples them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyByUnsignedWithOverflowCheck(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.MultiplyUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyBy(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.Multiply();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyByWithOverflowCheck(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.MultiplyWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value multiples them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyByUnsignedWithOverflowCheck(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.MultiplyUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyBy(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.Multiply();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyByWithOverflowCheck(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.MultiplyWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value multiples them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyByUnsignedWithOverflowCheck(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.MultiplyUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyBy(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.Multiply();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyByWithOverflowCheck(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.MultiplyWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value multiples them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyByUnsignedWithOverflowCheck(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.MultiplyUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyBy(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.Multiply();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value multiples them together with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyByWithOverflowCheck(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.MultiplyWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value multiples them together without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void MultiplyByUnsignedWithOverflowCheck(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.MultiplyUnsignedWithOverflowCheck();
		}


		#endregion

		#region Remainder

		/// <summary>
        /// Pops two values from the top of the evaluation stack and finds the remainder when the first is divided by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void Remainder(this ILGenerator generator) => generator.Emit(OpCodes.Rem);

		/// <summary>
        /// Pops two values from the top of the evaluation stack and finds the remainder when the first is divided by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void RemainderUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Rem_Un);

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void RemainderFrom(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.Remainder();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void RemainderFromUnsigned(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.RemainderUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void RemainderFrom(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.Remainder();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void RemainderFromUnsigned(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.RemainderUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void RemainderFrom(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.Remainder();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void RemainderFromUnsigned(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.RemainderUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void RemainderFrom(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.Remainder();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void RemainderFromUnsigned(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.RemainderUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void RemainderFrom(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.Remainder();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void RemainderFromUnsigned(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.RemainderUnsigned();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void RemainderFrom(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.Remainder();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value finds the remainder when the first is divided by the second without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void RemainderFromUnsigned(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.RemainderUnsigned();
		}


		#endregion

		#region Subtract

		/// <summary>
        /// Pops two values from the top of the evaluation stack and subtracts the second from the first
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void Subtract(this ILGenerator generator) => generator.Emit(OpCodes.Sub);

		/// <summary>
        /// Pops two values from the top of the evaluation stack and subtracts the second from the first with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void SubtractWithOverflowCheck(this ILGenerator generator) => generator.Emit(OpCodes.Sub_Ovf);

		/// <summary>
        /// Pops two values from the top of the evaluation stack and subtracts the second from the first without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void SubtractUnsignedWithOverflowCheck(this ILGenerator generator) => generator.Emit(OpCodes.Sub_Ovf_Un);

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void Subtract(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.Subtract();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void SubtractWithOverflowCheck(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.SubtractWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value subtracts the second from the first without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void SubtractUnsignedWithOverflowCheck(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.SubtractUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void Subtract(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.Subtract();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void SubtractWithOverflowCheck(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.SubtractWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value subtracts the second from the first without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void SubtractUnsignedWithOverflowCheck(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.SubtractUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void Subtract(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.Subtract();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void SubtractWithOverflowCheck(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.SubtractWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value subtracts the second from the first without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void SubtractUnsignedWithOverflowCheck(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.SubtractUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void Subtract(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.Subtract();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void SubtractWithOverflowCheck(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.SubtractWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value subtracts the second from the first without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void SubtractUnsignedWithOverflowCheck(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.SubtractUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void Subtract(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.Subtract();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void SubtractWithOverflowCheck(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.SubtractWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value subtracts the second from the first without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void SubtractUnsignedWithOverflowCheck(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.SubtractUnsignedWithOverflowCheck();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void Subtract(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.Subtract();
		}

		/// <summary>
        /// Pops a value from the top of the evaluation stack, and with the given value subtracts the second from the first with a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void SubtractWithOverflowCheck(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.SubtractWithOverflowCheck();
		}

		/// <summary>
        /// Pop a value from the top of the evaluation stack, and with the given value subtracts the second from the first without regard for sign, and a check for overflow
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		public static void SubtractUnsignedWithOverflowCheck(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.SubtractUnsignedWithOverflowCheck();
		}


		#endregion
	}
}
