using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
	public static class BitOperations
	{
		#region And
		
		[UsedImplicitly]
		public static void And(this ILGenerator generator) => generator.Emit(OpCodes.And);

		[UsedImplicitly]
		public static void AndWith(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.And();
		}

		[UsedImplicitly]
		public static void AndWith(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.And();
		}

		[UsedImplicitly]
		public static void AndWith(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.And();
		}

		[UsedImplicitly]
		public static void AndWith(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.And();
		}


		#endregion
		#region Complement
		
		[UsedImplicitly]
		public static void Complement(this ILGenerator generator) => generator.Emit(OpCodes.Not);

		#endregion
		#region Not
		
		[UsedImplicitly]
		public static void Not(this ILGenerator generator) => generator.Emit(OpCodes.Not);

		#endregion
		#region Or
		
		[UsedImplicitly]
		public static void Or(this ILGenerator generator) => generator.Emit(OpCodes.Or);

		[UsedImplicitly]
		public static void OrWith(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.Or();
		}

		[UsedImplicitly]
		public static void OrWith(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.Or();
		}

		[UsedImplicitly]
		public static void OrWith(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.Or();
		}

		[UsedImplicitly]
		public static void OrWith(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.Or();
		}


		#endregion
		#region ShiftLeft
		
		[UsedImplicitly]
		public static void ShiftLeft(this ILGenerator generator) => generator.Emit(OpCodes.Shl);

		[UsedImplicitly]
		public static void ShiftLeftBy(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftLeft();
		}

		[UsedImplicitly]
		public static void ShiftLeftBy(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftLeft();
		}

		[UsedImplicitly]
		public static void ShiftLeftBy(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftLeft();
		}

		[UsedImplicitly]
		public static void ShiftLeftBy(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftLeft();
		}


		#endregion
		#region ShiftRight
		
		[UsedImplicitly]
		public static void ShiftRight(this ILGenerator generator) => generator.Emit(OpCodes.Shr);

		[UsedImplicitly]
		public static void ShiftRightBy(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRight();
		}

		[UsedImplicitly]
		public static void ShiftRightBy(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRight();
		}

		[UsedImplicitly]
		public static void ShiftRightBy(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRight();
		}

		[UsedImplicitly]
		public static void ShiftRightBy(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRight();
		}


		#endregion
		#region ShiftRightUnsigned
		
		[UsedImplicitly]
		public static void ShiftRightUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Shr_Un);

		[UsedImplicitly]
		public static void ShiftRightUnsignedBy(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRightUnsigned();
		}

		[UsedImplicitly]
		public static void ShiftRightUnsignedBy(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRightUnsigned();
		}

		[UsedImplicitly]
		public static void ShiftRightUnsignedBy(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRightUnsigned();
		}

		[UsedImplicitly]
		public static void ShiftRightUnsignedBy(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRightUnsigned();
		}


		#endregion
		#region Xor
		
		[UsedImplicitly]
		public static void Xor(this ILGenerator generator) => generator.Emit(OpCodes.Xor);

		[UsedImplicitly]
		public static void XorWith(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.Xor();
		}

		[UsedImplicitly]
		public static void XorWith(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.Xor();
		}

		[UsedImplicitly]
		public static void XorWith(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.Xor();
		}

		[UsedImplicitly]
		public static void XorWith(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.Xor();
		}


		#endregion
	}
}
