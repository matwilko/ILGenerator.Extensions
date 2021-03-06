﻿using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
	/// <summary>
    /// Contains extension methods for perofmring bitwise operations on integers
    /// </summary>
	public static class BitOperations
	{
		#region And

		/// <summary>
        /// Pop two integer values from the evaluation stack and perform a bitwise and operation on them
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator And(this ILGenerator generator) => generator.FluentEmit(OpCodes.And);

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise and operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise and the evaluation stack value with</param>
		[PublicAPI]
		public static ILGenerator AndWith(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.And();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise and operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise and the evaluation stack value with</param>
		[PublicAPI]
		public static ILGenerator AndWith(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.And();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise and operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise and the evaluation stack value with</param>
		[PublicAPI]
		public static ILGenerator AndWith(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.And();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise and operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise and the evaluation stack value with</param>
		[PublicAPI]
		public static ILGenerator AndWith(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.And();
		}

		#endregion
		#region Complement

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise complement operation on it
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator Complement(this ILGenerator generator) => generator.FluentEmit(OpCodes.Not);

		#endregion
		#region Not

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise not operation on it
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator Not(this ILGenerator generator) => generator.FluentEmit(OpCodes.Not);

		#endregion
		#region Or

		/// <summary>
        /// Pop two integer values from the evaluation stack and perform a bitwise or operation on them
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator Or(this ILGenerator generator) => generator.FluentEmit(OpCodes.Or);

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise or operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise or the evaluation stack value with</param>
		[PublicAPI]
		public static ILGenerator OrWith(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.Or();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise or operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise or the evaluation stack value with</param>
		[PublicAPI]
		public static ILGenerator OrWith(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.Or();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise or operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise or the evaluation stack value with</param>
		[PublicAPI]
		public static ILGenerator OrWith(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.Or();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise or operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise or the evaluation stack value with</param>
		[PublicAPI]
		public static ILGenerator OrWith(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.Or();
		}

		#endregion
		#region ShiftLeft

		/// <summary>
        /// Pop two integer values from the evaluation stack and perform a bitwise shiftleft operation on them
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator ShiftLeft(this ILGenerator generator) => generator.FluentEmit(OpCodes.Shl);

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftleft operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftleft the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator ShiftLeftBy(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.ShiftLeft();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftleft operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftleft the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator ShiftLeftBy(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.ShiftLeft();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftleft operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftleft the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator ShiftLeftBy(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.ShiftLeft();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftleft operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftleft the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator ShiftLeftBy(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.ShiftLeft();
		}

		#endregion
		#region ShiftRight

		/// <summary>
        /// Pop two integer values from the evaluation stack and perform a bitwise shiftright operation on them
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator ShiftRight(this ILGenerator generator) => generator.FluentEmit(OpCodes.Shr);

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftright operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftright the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator ShiftRightBy(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.ShiftRight();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftright operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftright the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator ShiftRightBy(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.ShiftRight();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftright operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftright the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator ShiftRightBy(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.ShiftRight();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftright operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftright the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator ShiftRightBy(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.ShiftRight();
		}

		#endregion
		#region ShiftRightUnsigned

		/// <summary>
        /// Pop two integer values from the evaluation stack and perform a bitwise shiftrightunsigned operation on them
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator ShiftRightUnsigned(this ILGenerator generator) => generator.FluentEmit(OpCodes.Shr_Un);

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftrightunsigned operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftrightunsigned the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator ShiftRightUnsignedBy(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.ShiftRightUnsigned();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftrightunsigned operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftrightunsigned the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator ShiftRightUnsignedBy(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.ShiftRightUnsigned();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftrightunsigned operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftrightunsigned the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator ShiftRightUnsignedBy(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.ShiftRightUnsigned();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise shiftrightunsigned operation by the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise shiftrightunsigned the evaluation stack value by</param>
		[PublicAPI]
		public static ILGenerator ShiftRightUnsignedBy(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.ShiftRightUnsigned();
		}

		#endregion
		#region Xor

		/// <summary>
        /// Pop two integer values from the evaluation stack and perform a bitwise xor operation on them
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator Xor(this ILGenerator generator) => generator.FluentEmit(OpCodes.Xor);

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise xor operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise xor the evaluation stack value with</param>
		[PublicAPI]
		public static ILGenerator XorWith(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.Xor();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise xor operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise xor the evaluation stack value with</param>
		[PublicAPI]
		public static ILGenerator XorWith(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.Xor();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise xor operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise xor the evaluation stack value with</param>
		[PublicAPI]
		public static ILGenerator XorWith(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.Xor();
		}

		/// <summary>
        /// Pop an integer value from the evaluation stack and perform a bitwise xor operation with the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="value">The value to bitwise xor the evaluation stack value with</param>
		[PublicAPI]
		public static ILGenerator XorWith(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.Xor();
		}

		#endregion
	}
}
