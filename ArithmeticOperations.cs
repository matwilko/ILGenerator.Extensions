using System;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
	public static class ArithmeticOperations
	{
		#region Add

		public static void Add(this ILGenerator generator) => generator.Emit(OpCodes.Add);

		public static void AddTo(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.Add();
		}

		public static void AddTo(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.Add();
		}

		public static void AddTo(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.Add();
		}

		public static void AddTo(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.Add();
		}

		public static void AddTo(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.Add();
		}

		public static void AddTo(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.Add();
		}


		#endregion

		#region Divide

		public static void Divide(this ILGenerator generator) => generator.Emit(OpCodes.Div);

		public static void DivideBy(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.Divide();
		}

		public static void DivideBy(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.Divide();
		}

		public static void DivideBy(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.Divide();
		}

		public static void DivideBy(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.Divide();
		}

		public static void DivideBy(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.Divide();
		}

		public static void DivideBy(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.Divide();
		}


		#endregion

		#region Multiply

		public static void Multiply(this ILGenerator generator) => generator.Emit(OpCodes.Mul);

		public static void MultiplyBy(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.Multiply();
		}

		public static void MultiplyBy(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.Multiply();
		}

		public static void MultiplyBy(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.Multiply();
		}

		public static void MultiplyBy(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.Multiply();
		}

		public static void MultiplyBy(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.Multiply();
		}

		public static void MultiplyBy(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.Multiply();
		}


		#endregion

		#region Negate

		public static void Negate(this ILGenerator generator) => generator.Emit(OpCodes.Neg);

		#endregion

		#region Remainder

		public static void Remainder(this ILGenerator generator) => generator.Emit(OpCodes.Rem);

		public static void RemainderFrom(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.Remainder();
		}

		public static void RemainderFrom(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.Remainder();
		}

		public static void RemainderFrom(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.Remainder();
		}

		public static void RemainderFrom(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.Remainder();
		}

		public static void RemainderFrom(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.Remainder();
		}

		public static void RemainderFrom(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.Remainder();
		}


		#endregion

		#region Subtract

		public static void Subtract(this ILGenerator generator) => generator.Emit(OpCodes.Sub);

		public static void Subtract(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.Subtract();
		}

		public static void Subtract(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.Subtract();
		}

		public static void Subtract(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.Subtract();
		}

		public static void Subtract(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.Subtract();
		}

		public static void Subtract(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.Subtract();
		}

		public static void Subtract(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.Subtract();
		}


		#endregion

	}
}
