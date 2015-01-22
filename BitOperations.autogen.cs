using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
	public static class BitOperations
	{
		#region And
		
		[PublicAPI]
		public static void And(this ILGenerator generator) => generator.Emit(OpCodes.And);

		[PublicAPI]
		public static void AndWith(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.And();
		}

		[PublicAPI]
		public static void AndWith(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.And();
		}

		[PublicAPI]
		public static void AndWith(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.And();
		}

		[PublicAPI]
		public static void AndWith(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.And();
		}


		#endregion
		#region Complement
		
		[PublicAPI]
		public static void Complement(this ILGenerator generator) => generator.Emit(OpCodes.Not);

		#endregion
		#region Not
		
		[PublicAPI]
		public static void Not(this ILGenerator generator) => generator.Emit(OpCodes.Not);

		#endregion
		#region Or
		
		[PublicAPI]
		public static void Or(this ILGenerator generator) => generator.Emit(OpCodes.Or);

		[PublicAPI]
		public static void OrWith(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.Or();
		}

		[PublicAPI]
		public static void OrWith(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.Or();
		}

		[PublicAPI]
		public static void OrWith(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.Or();
		}

		[PublicAPI]
		public static void OrWith(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.Or();
		}


		#endregion
		#region ShiftLeft
		
		[PublicAPI]
		public static void ShiftLeft(this ILGenerator generator) => generator.Emit(OpCodes.Shl);

		[PublicAPI]
		public static void ShiftLeftBy(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftLeft();
		}

		[PublicAPI]
		public static void ShiftLeftBy(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftLeft();
		}

		[PublicAPI]
		public static void ShiftLeftBy(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftLeft();
		}

		[PublicAPI]
		public static void ShiftLeftBy(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftLeft();
		}


		#endregion
		#region ShiftRight
		
		[PublicAPI]
		public static void ShiftRight(this ILGenerator generator) => generator.Emit(OpCodes.Shr);

		[PublicAPI]
		public static void ShiftRightBy(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRight();
		}

		[PublicAPI]
		public static void ShiftRightBy(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRight();
		}

		[PublicAPI]
		public static void ShiftRightBy(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRight();
		}

		[PublicAPI]
		public static void ShiftRightBy(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRight();
		}


		#endregion
		#region ShiftRightUnsigned
		
		[PublicAPI]
		public static void ShiftRightUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Shr_Un);

		[PublicAPI]
		public static void ShiftRightUnsignedBy(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRightUnsigned();
		}

		[PublicAPI]
		public static void ShiftRightUnsignedBy(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRightUnsigned();
		}

		[PublicAPI]
		public static void ShiftRightUnsignedBy(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRightUnsigned();
		}

		[PublicAPI]
		public static void ShiftRightUnsignedBy(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRightUnsigned();
		}


		#endregion
		#region Xor
		
		[PublicAPI]
		public static void Xor(this ILGenerator generator) => generator.Emit(OpCodes.Xor);

		[PublicAPI]
		public static void XorWith(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.Xor();
		}

		[PublicAPI]
		public static void XorWith(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.Xor();
		}

		[PublicAPI]
		public static void XorWith(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.Xor();
		}

		[PublicAPI]
		public static void XorWith(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.Xor();
		}


		#endregion
	}
}
