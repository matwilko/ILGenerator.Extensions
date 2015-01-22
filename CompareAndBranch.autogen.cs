using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
	[PublicAPI]
	public static partial class CompareAndBranch
	{

		#region Equal

		[PublicAPI]
		public static void BranchIfEqual(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Beq, label);
		
		[PublicAPI]
		public static void BranchIfEqualShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Beq_S, label);
		
		[PublicAPI]
		public static void BranchIfEqualTo(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		[PublicAPI]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfEqualTo(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		[PublicAPI]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfEqualTo(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		[PublicAPI]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfEqualTo(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		[PublicAPI]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfEqualTo(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		[PublicAPI]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfEqualTo(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		[PublicAPI]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfEqualTo(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		[PublicAPI]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		[PublicAPI]
		public static void CompareEqual(this ILGenerator generator) => generator.Emit(OpCodes.Ceq);

		[PublicAPI]
		public static void CompareEqualTo(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		[PublicAPI]
		public static void CompareEqualTo(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		[PublicAPI]
		public static void CompareEqualTo(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		[PublicAPI]
		public static void CompareEqualTo(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		[PublicAPI]
		public static void CompareEqualTo(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		[PublicAPI]
		public static void CompareEqualTo(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		[PublicAPI]
		public static void CompareEqualTo(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}

		#endregion

		#region NotEqual
		[PublicAPI]
		public static void BranchIfNotEqualUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bne_Un, label);
		
		[PublicAPI]
		public static void BranchIfNotEqualUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bne_Un_S, label);

		[PublicAPI]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}

		#endregion

		#region GreaterThanOrEqual

		[PublicAPI]
		public static void BranchIfGreaterThanOrEqual(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bge, label);
		
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bge_S, label);
		
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bge_Un, label);
		
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bge_Un_S, label);

		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}

		#endregion

		#region Greater

		[PublicAPI]
		public static void BranchIfGreater(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bgt, label);
		
		[PublicAPI]
		public static void BranchIfGreaterShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bgt_S, label);
		
		[PublicAPI]
		public static void BranchIfGreaterThan(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThan(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThan(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThan(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThan(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThan(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThan(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bgt_Un, label);
		
		[PublicAPI]
		public static void BranchIfGreaterUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bgt_Un_S, label);

		[PublicAPI]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}

		[PublicAPI]
		public static void CompareGreater(this ILGenerator generator) => generator.Emit(OpCodes.Cgt);

		[PublicAPI]
		public static void CompareGreaterThan(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		[PublicAPI]
		public static void CompareGreaterThan(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		[PublicAPI]
		public static void CompareGreaterThan(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		[PublicAPI]
		public static void CompareGreaterThan(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		[PublicAPI]
		public static void CompareGreaterThan(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		[PublicAPI]
		public static void CompareGreaterThan(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		[PublicAPI]
		public static void CompareGreaterThan(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}

		[PublicAPI]
		public static void CompareGreaterUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Cgt_Un);

		[PublicAPI]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		[PublicAPI]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		[PublicAPI]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		[PublicAPI]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		[PublicAPI]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		[PublicAPI]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		[PublicAPI]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}

		#endregion

		#region LessThanOrEqual

		[PublicAPI]
		public static void BranchIfLessThanOrEqual(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Ble, label);
		
		[PublicAPI]
		public static void BranchIfLessThanOrEqualShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Ble_S, label);
		
		[PublicAPI]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThanOrEqualUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Ble_Un, label);
		
		[PublicAPI]
		public static void BranchIfLessThanOrEqualUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Ble_Un_S, label);

		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}

		#endregion

		#region Less

		[PublicAPI]
		public static void BranchIfLess(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Blt, label);
		
		[PublicAPI]
		public static void BranchIfLessShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Blt_S, label);
		
		[PublicAPI]
		public static void BranchIfLessThan(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThan(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThan(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThan(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThan(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThan(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThan(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Blt_Un, label);
		
		[PublicAPI]
		public static void BranchIfLessUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Blt_Un_S, label);

		[PublicAPI]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		[PublicAPI]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}

		[PublicAPI]
		public static void CompareLess(this ILGenerator generator) => generator.Emit(OpCodes.Clt);

		[PublicAPI]
		public static void CompareLessThan(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		[PublicAPI]
		public static void CompareLessThan(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		[PublicAPI]
		public static void CompareLessThan(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		[PublicAPI]
		public static void CompareLessThan(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		[PublicAPI]
		public static void CompareLessThan(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		[PublicAPI]
		public static void CompareLessThan(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		[PublicAPI]
		public static void CompareLessThan(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}

		[PublicAPI]
		public static void CompareLessUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Clt_Un);

		[PublicAPI]
		public static void CompareLessThanUnsigned(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		[PublicAPI]
		public static void CompareLessThanUnsigned(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		[PublicAPI]
		public static void CompareLessThanUnsigned(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		[PublicAPI]
		public static void CompareLessThanUnsigned(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		[PublicAPI]
		public static void CompareLessThanUnsigned(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		[PublicAPI]
		public static void CompareLessThanUnsigned(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		[PublicAPI]
		public static void CompareLessThanUnsigned(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}

		#endregion

		#region True

		[PublicAPI]
		public static void BranchIfTrue(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Brtrue, label);
		
		[PublicAPI]
		public static void BranchIfTrueShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Brtrue_S, label);
		
		[PublicAPI]
		public static void BranchIfTrue(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		[PublicAPI]
		public static void BranchIfTrueShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfTrue(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		[PublicAPI]
		public static void BranchIfTrueShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfTrue(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		[PublicAPI]
		public static void BranchIfTrueShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfTrue(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		[PublicAPI]
		public static void BranchIfTrueShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfTrue(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		[PublicAPI]
		public static void BranchIfTrueShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfTrue(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		[PublicAPI]
		public static void BranchIfTrueShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfTrue(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		[PublicAPI]
		public static void BranchIfTrueShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		#endregion

		#region False

		[PublicAPI]
		public static void BranchIfFalse(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Brfalse, label);
		
		[PublicAPI]
		public static void BranchIfFalseShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Brfalse_S, label);
		
		[PublicAPI]
		public static void BranchIfFalse(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		[PublicAPI]
		public static void BranchIfFalseShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfFalse(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		[PublicAPI]
		public static void BranchIfFalseShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfFalse(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		[PublicAPI]
		public static void BranchIfFalseShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfFalse(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		[PublicAPI]
		public static void BranchIfFalseShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfFalse(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		[PublicAPI]
		public static void BranchIfFalseShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfFalse(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		[PublicAPI]
		public static void BranchIfFalseShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		[PublicAPI]
		public static void BranchIfFalse(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		[PublicAPI]
		public static void BranchIfFalseShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		#endregion

	}
}
