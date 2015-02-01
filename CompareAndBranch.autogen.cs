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
		public static ILGenerator BranchIfEqual(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Beq, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is equal to the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfEqualShortForm(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Beq_S, label);
		
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfEqualTo(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfEqualToShortForm(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfEqualTo(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfEqualToShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfEqualTo(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfEqualToShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfEqualTo(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfEqualToShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfEqualTo(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfEqualToShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfEqualTo(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfEqualToShortForm(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfEqualTo(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfEqualToShortForm(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfEqualShortForm(label);
		}
		/// <summary>
        /// Pops two integer values from the evaluation stack and pushes the result of comparing whether the first is equal to the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator CompareEqual(this ILGenerator generator) => generator.FluentEmit(OpCodes.Ceq);

		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareEqualTo(this ILGenerator generator, Char value)
		{
			return generator.LoadConstant(value)
							.CompareEqual();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareEqualTo(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.CompareEqual();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareEqualTo(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.CompareEqual();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareEqualTo(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.CompareEqual();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareEqualTo(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.CompareEqual();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareEqualTo(this ILGenerator generator, Single value)
		{
			return generator.LoadConstant(value)
							.CompareEqual();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareEqualTo(this ILGenerator generator, Double value)
		{
			return generator.LoadConstant(value)
							.CompareEqual();
		}

		#endregion

		#region NotEqual
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is not equal to the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfNotEqualUnsigned(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Bne_Un, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is not equal to the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfNotEqualUnsignedShortForm(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Bne_Un_S, label);

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfNotEqualToUnsigned(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfNotEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfNotEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfNotEqualToUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfNotEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfNotEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfNotEqualToUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfNotEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfNotEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfNotEqualToUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfNotEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfNotEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfNotEqualToUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfNotEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfNotEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfNotEqualToUnsigned(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfNotEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfNotEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfNotEqualToUnsigned(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfNotEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is not equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfNotEqualUnsignedShortForm(label);
		}

		#endregion

		#region GreaterThanOrEqual

		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is greater than or equal to the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqual(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Bge, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is greater than or equal to the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualShortForm(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Bge_S, label);
		
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualTo(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualTo(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is greater than or equal to the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualUnsigned(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Bge_Un, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is greater than or equal to the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualUnsignedShortForm(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Bge_Un_S, label);

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}

		#endregion

		#region Greater

		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is greater than the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreater(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Bgt, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is greater than the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterShortForm(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Bgt_S, label);
		
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThan(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreater(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanShortForm(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThan(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreater(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThan(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreater(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThan(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreater(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThan(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreater(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThan(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreater(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanShortForm(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThan(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreater(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanShortForm(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterShortForm(label);
		}
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is greater than the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterUnsigned(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Bgt_Un, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is greater than the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterUnsignedShortForm(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Bgt_Un_S, label);

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanUnsigned(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanUnsigned(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanUnsigned(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is greater than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfGreaterUnsignedShortForm(label);
		}

		/// <summary>
        /// Pops two integer values from the evaluation stack and pushes the result of comparing whether the first is greater than the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator CompareGreater(this ILGenerator generator) => generator.FluentEmit(OpCodes.Cgt);

		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareGreaterThan(this ILGenerator generator, Char value)
		{
			return generator.LoadConstant(value)
							.CompareGreater();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareGreaterThan(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.CompareGreater();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareGreaterThan(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.CompareGreater();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareGreaterThan(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.CompareGreater();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareGreaterThan(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.CompareGreater();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareGreaterThan(this ILGenerator generator, Single value)
		{
			return generator.LoadConstant(value)
							.CompareGreater();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareGreaterThan(this ILGenerator generator, Double value)
		{
			return generator.LoadConstant(value)
							.CompareGreater();
		}

		/// <summary>
        /// Pops two integer values from the evaluation stack and pushes the result of comparing whether the first is greater than the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator CompareGreaterUnsigned(this ILGenerator generator) => generator.FluentEmit(OpCodes.Cgt_Un);

		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareGreaterThanUnsigned(this ILGenerator generator, Char value)
		{
			return generator.LoadConstant(value)
							.CompareGreaterUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareGreaterThanUnsigned(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.CompareGreaterUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareGreaterThanUnsigned(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.CompareGreaterUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareGreaterThanUnsigned(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.CompareGreaterUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareGreaterThanUnsigned(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.CompareGreaterUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareGreaterThanUnsigned(this ILGenerator generator, Single value)
		{
			return generator.LoadConstant(value)
							.CompareGreaterUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is greater than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareGreaterThanUnsigned(this ILGenerator generator, Double value)
		{
			return generator.LoadConstant(value)
							.CompareGreaterUnsigned();
		}

		#endregion

		#region LessThanOrEqual

		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is less than or equal to the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqual(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Ble, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is less than or equal to the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualShortForm(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Ble_S, label);
		
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualTo(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualTo(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualTo(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualTo(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualTo(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualTo(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualTo(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqual(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualShortForm(label);
		}
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is less than or equal to the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualUnsigned(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Ble_Un, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is less than or equal to the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualUnsignedShortForm(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Ble_Un_S, label);

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than or equal to the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}

		#endregion

		#region Less

		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is less than the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLess(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Blt, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is less than the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessShortForm(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Blt_S, label);
		
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThan(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLess(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanShortForm(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThan(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLess(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThan(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLess(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThan(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLess(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThan(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLess(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThan(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLess(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanShortForm(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThan(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLess(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanShortForm(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessShortForm(label);
		}
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is less than the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessUnsigned(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Blt_Un, label);
		
		/// <summary>
        /// Pops two integer values from the evaluation stack and branches to the given label if the first is less than the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessUnsignedShortForm(this ILGenerator generator, Label label) => generator.FluentEmit(OpCodes.Blt_Un_S, label);

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanUnsigned(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanUnsigned(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessUnsignedShortForm(label);
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanUnsigned(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessUnsigned(label);
		}

		/// <summary>
        /// Pops an integer value from the evaluation stack and branches to the given label if it is less than the given value, with regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
        /// <param name="label">The label to branch to</param>
		[PublicAPI]
		public static ILGenerator BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			return generator.LoadConstant(value)
							.BranchIfLessUnsignedShortForm(label);
		}

		/// <summary>
        /// Pops two integer values from the evaluation stack and pushes the result of comparing whether the first is less than the second
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator CompareLess(this ILGenerator generator) => generator.FluentEmit(OpCodes.Clt);

		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareLessThan(this ILGenerator generator, Char value)
		{
			return generator.LoadConstant(value)
							.CompareLess();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareLessThan(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.CompareLess();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareLessThan(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.CompareLess();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareLessThan(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.CompareLess();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareLessThan(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.CompareLess();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareLessThan(this ILGenerator generator, Single value)
		{
			return generator.LoadConstant(value)
							.CompareLess();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareLessThan(this ILGenerator generator, Double value)
		{
			return generator.LoadConstant(value)
							.CompareLess();
		}

		/// <summary>
        /// Pops two integer values from the evaluation stack and pushes the result of comparing whether the first is less than the second, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		[PublicAPI]
		public static ILGenerator CompareLessUnsigned(this ILGenerator generator) => generator.FluentEmit(OpCodes.Clt_Un);

		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareLessThanUnsigned(this ILGenerator generator, Char value)
		{
			return generator.LoadConstant(value)
							.CompareLessUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareLessThanUnsigned(this ILGenerator generator, Int32 value)
		{
			return generator.LoadConstant(value)
							.CompareLessUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareLessThanUnsigned(this ILGenerator generator, UInt32 value)
		{
			return generator.LoadConstant(value)
							.CompareLessUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareLessThanUnsigned(this ILGenerator generator, Int64 value)
		{
			return generator.LoadConstant(value)
							.CompareLessUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareLessThanUnsigned(this ILGenerator generator, UInt64 value)
		{
			return generator.LoadConstant(value)
							.CompareLessUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareLessThanUnsigned(this ILGenerator generator, Single value)
		{
			return generator.LoadConstant(value)
							.CompareLessUnsigned();
		}
		/// <summary>
        /// Pops an integer value from the evaluation stack and pushes the result of comparing whether it is less than the given value, without regard for sign
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
		/// <param name="value">The value to compare to the evaluation stack value</param>
		[PublicAPI]
		public static ILGenerator CompareLessThanUnsigned(this ILGenerator generator, Double value)
		{
			return generator.LoadConstant(value)
							.CompareLessUnsigned();
		}

		#endregion

	}
}
