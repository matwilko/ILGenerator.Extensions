using System;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
	public static class BitOperations
	{
		#region And

		public static void And(this ILGenerator generator) => generator.Emit(OpCodes.And);

		public static void AndWith(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.And();
		}

		public static void AndWith(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.And();
		}

		public static void AndWith(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.And();
		}

		public static void AndWith(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.And();
		}


		#endregion
		#region Complement

		public static void Complement(this ILGenerator generator) => generator.Emit(OpCodes.Not);

		#endregion
		#region Not

		public static void Not(this ILGenerator generator) => generator.Emit(OpCodes.Not);

		#endregion
		#region Or

		public static void Or(this ILGenerator generator) => generator.Emit(OpCodes.Or);

		public static void OrWith(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.Or();
		}

		public static void OrWith(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.Or();
		}

		public static void OrWith(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.Or();
		}

		public static void OrWith(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.Or();
		}


		#endregion
		#region ShiftLeft

		public static void ShiftLeft(this ILGenerator generator) => generator.Emit(OpCodes.Shl);

		public static void ShiftLeftBy(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftLeft();
		}

		public static void ShiftLeftBy(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftLeft();
		}

		public static void ShiftLeftBy(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftLeft();
		}

		public static void ShiftLeftBy(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftLeft();
		}


		#endregion
		#region ShiftRight

		public static void ShiftRight(this ILGenerator generator) => generator.Emit(OpCodes.Shr);

		public static void ShiftRightBy(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRight();
		}

		public static void ShiftRightBy(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRight();
		}

		public static void ShiftRightBy(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRight();
		}

		public static void ShiftRightBy(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRight();
		}


		#endregion
		#region ShiftRightUnsigned

		public static void ShiftRightUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Shr_Un);

		public static void ShiftRightUnsignedBy(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRightUnsigned();
		}

		public static void ShiftRightUnsignedBy(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRightUnsigned();
		}

		public static void ShiftRightUnsignedBy(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRightUnsigned();
		}

		public static void ShiftRightUnsignedBy(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRightUnsigned();
		}


		#endregion
		#region Xor

		public static void Xor(this ILGenerator generator) => generator.Emit(OpCodes.Xor);

		public static void XorWith(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.Xor();
		}

		public static void XorWith(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.Xor();
		}

		public static void XorWith(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.Xor();
		}

		public static void XorWith(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.Xor();
		}


		#endregion
	}
}
