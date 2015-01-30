using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
	public static class BitOperations
	{
		#region And

		/// <summary>
        /// Pop two integer values from the evaluation stack and perform a bitwise and operation on them
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static void And(this ILGenerator generator) => generator.Emit(OpCodes.And);

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise and operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise and the evaluation stack value with</param>
		[PublicAPI]
		public static void AndWith(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.And();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise and operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise and the evaluation stack value with</param>
		[PublicAPI]
		public static void AndWith(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.And();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise and operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise and the evaluation stack value with</param>
		[PublicAPI]
		public static void AndWith(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.And();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise and operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise and the evaluation stack value with</param>
		[PublicAPI]
		public static void AndWith(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.And();
		}

		#endregion
		#region Complement

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise complement operation on it
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static void Complement(this ILGenerator generator) => generator.Emit(OpCodes.Not);

		#endregion
		#region Not

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise not operation on it
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static void Not(this ILGenerator generator) => generator.Emit(OpCodes.Not);

		#endregion
		#region Or

		/// <summary>
        /// Pop two integer values from the evaluation stack and perform a bitwise or operation on them
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static void Or(this ILGenerator generator) => generator.Emit(OpCodes.Or);

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise or operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise or the evaluation stack value with</param>
		[PublicAPI]
		public static void OrWith(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.Or();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise or operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise or the evaluation stack value with</param>
		[PublicAPI]
		public static void OrWith(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.Or();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise or operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise or the evaluation stack value with</param>
		[PublicAPI]
		public static void OrWith(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.Or();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise or operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise or the evaluation stack value with</param>
		[PublicAPI]
		public static void OrWith(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.Or();
		}

		#endregion
		#region ShiftLeft

		/// <summary>
        /// Pop two integer values from the evaluation stack and perform a bitwise shiftleft operation on them
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static void ShiftLeft(this ILGenerator generator) => generator.Emit(OpCodes.Shl);

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftleft operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftleft the evaluation stack value by</param>
		[PublicAPI]
		public static void ShiftLeftBy(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftLeft();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftleft operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftleft the evaluation stack value by</param>
		[PublicAPI]
		public static void ShiftLeftBy(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftLeft();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftleft operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftleft the evaluation stack value by</param>
		[PublicAPI]
		public static void ShiftLeftBy(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftLeft();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftleft operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftleft the evaluation stack value by</param>
		[PublicAPI]
		public static void ShiftLeftBy(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftLeft();
		}

		#endregion
		#region ShiftRight

		/// <summary>
        /// Pop two integer values from the evaluation stack and perform a bitwise shiftright operation on them
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static void ShiftRight(this ILGenerator generator) => generator.Emit(OpCodes.Shr);

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftright operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftright the evaluation stack value by</param>
		[PublicAPI]
		public static void ShiftRightBy(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRight();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftright operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftright the evaluation stack value by</param>
		[PublicAPI]
		public static void ShiftRightBy(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRight();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftright operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftright the evaluation stack value by</param>
		[PublicAPI]
		public static void ShiftRightBy(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRight();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftright operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftright the evaluation stack value by</param>
		[PublicAPI]
		public static void ShiftRightBy(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRight();
		}

		#endregion
		#region ShiftRightUnsigned

		/// <summary>
        /// Pop two integer values from the evaluation stack and perform a bitwise shiftrightunsigned operation on them
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static void ShiftRightUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Shr_Un);

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftrightunsigned operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftrightunsigned the evaluation stack value by</param>
		[PublicAPI]
		public static void ShiftRightUnsignedBy(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRightUnsigned();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftrightunsigned operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftrightunsigned the evaluation stack value by</param>
		[PublicAPI]
		public static void ShiftRightUnsignedBy(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRightUnsigned();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftrightunsigned operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftrightunsigned the evaluation stack value by</param>
		[PublicAPI]
		public static void ShiftRightUnsignedBy(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRightUnsigned();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftrightunsigned operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftrightunsigned the evaluation stack value by</param>
		[PublicAPI]
		public static void ShiftRightUnsignedBy(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.ShiftRightUnsigned();
		}

		#endregion
		#region Xor

		/// <summary>
        /// Pop two integer values from the evaluation stack and perform a bitwise xor operation on them
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static void Xor(this ILGenerator generator) => generator.Emit(OpCodes.Xor);

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise xor operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise xor the evaluation stack value with</param>
		[PublicAPI]
		public static void XorWith(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.Xor();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise xor operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise xor the evaluation stack value with</param>
		[PublicAPI]
		public static void XorWith(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.Xor();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise xor operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise xor the evaluation stack value with</param>
		[PublicAPI]
		public static void XorWith(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.Xor();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise xor operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise xor the evaluation stack value with</param>
		[PublicAPI]
		public static void XorWith(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.Xor();
		}

		#endregion
	}
}
