using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
	[PublicAPI]
	public static partial class CompareAndBranch
	{

		#region Equal

		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is equal to the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfEqual(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Beq, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is equal to the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfEqualShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Beq_S, label);
		
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfEqualTo(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfEqualTo(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfEqualTo(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfEqualTo(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfEqualTo(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfEqualTo(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfEqualTo(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		/// <summary>
        /// Pops two integer values from the evaluation stack and pushes the result of comparing whether the first is equal to the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static void CompareEqual(this ILGenerator generator) => generator.Emit(OpCodes.Ceq);

		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareEqualTo(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareEqualTo(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareEqualTo(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareEqualTo(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareEqualTo(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareEqualTo(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareEqualTo(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}

		#endregion

		#region NotEqual
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is not equal to the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfNotEqualUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bne_Un, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is not equal to the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfNotEqualUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bne_Un_S, label);

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}

		#endregion

		#region GreaterThanOrEqual

		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is greater than or equal to the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqual(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bge, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is greater than or equal to the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bge_S, label);
		
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is greater than or equal to the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bge_Un, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is greater than or equal to the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bge_Un_S, label);

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}

		#endregion

		#region Greater

		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is greater than the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreater(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bgt, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is greater than the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bgt_S, label);
		
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThan(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThan(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThan(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThan(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThan(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThan(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThan(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is greater than the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bgt_Un, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is greater than the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bgt_Un_S, label);

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}

		/// <summary>
        /// Pops two integer values from the evaluation stack and pushes the result of comparing whether the first is greater than the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static void CompareGreater(this ILGenerator generator) => generator.Emit(OpCodes.Cgt);

		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareGreaterThan(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareGreaterThan(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareGreaterThan(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareGreaterThan(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareGreaterThan(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareGreaterThan(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareGreaterThan(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}

		/// <summary>
        /// Pops two integer values from the evaluation stack and pushes the result of comparing whether the first is greater than the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static void CompareGreaterUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Cgt_Un);

		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}

		#endregion

		#region LessThanOrEqual

		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is less than or equal to the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqual(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Ble, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is less than or equal to the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Ble_S, label);
		
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is less than or equal to the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Ble_Un, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is less than or equal to the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Ble_Un_S, label);

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}

		#endregion

		#region Less

		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is less than the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLess(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Blt, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is less than the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Blt_S, label);
		
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThan(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThan(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThan(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThan(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThan(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThan(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThan(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is less than the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Blt_Un, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is less than the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Blt_Un_S, label);

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}

		/// <summary>
        /// Pops two integer values from the evaluation stack and pushes the result of comparing whether the first is less than the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static void CompareLess(this ILGenerator generator) => generator.Emit(OpCodes.Clt);

		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareLessThan(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareLessThan(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareLessThan(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareLessThan(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareLessThan(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareLessThan(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareLessThan(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}

		/// <summary>
        /// Pops two integer values from the evaluation stack and pushes the result of comparing whether the first is less than the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static void CompareLessUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Clt_Un);

		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareLessThanUnsigned(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareLessThanUnsigned(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareLessThanUnsigned(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareLessThanUnsigned(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareLessThanUnsigned(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareLessThanUnsigned(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static void CompareLessThanUnsigned(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}

		#endregion

	}
}
