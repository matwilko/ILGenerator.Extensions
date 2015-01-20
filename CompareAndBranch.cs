using System;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
	public static class CompareAndBranch
	{

		#region Equal

		public static void BranchIfEqual(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Beq, label);
		public static void BranchIfEqualShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Beq_S, label);
		
		public static void BranchIfEqualTo(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		public static void BranchIfEqualToShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		public static void BranchIfEqualTo(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		public static void BranchIfEqualToShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		public static void BranchIfEqualTo(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		public static void BranchIfEqualToShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		public static void BranchIfEqualTo(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		public static void BranchIfEqualToShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		public static void BranchIfEqualTo(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		public static void BranchIfEqualToShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		public static void BranchIfEqualTo(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		public static void BranchIfEqualToShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		public static void BranchIfEqualTo(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		public static void BranchIfEqualToShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		public static void CompareEqual(this ILGenerator generator) => generator.Emit(OpCodes.Ceq);

		public static void CompareEqualTo(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		public static void CompareEqualTo(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		public static void CompareEqualTo(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		public static void CompareEqualTo(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		public static void CompareEqualTo(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		public static void CompareEqualTo(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		public static void CompareEqualTo(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}

		#endregion

		#region NotEqual
		public static void BranchIfNotEqualUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bne_Un, label);
		public static void BranchIfNotEqualUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bne_Un_S, label);

		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}

		#endregion

		#region GreaterThanOrEqual

		public static void BranchIfGreaterThanOrEqual(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bge, label);
		public static void BranchIfGreaterThanOrEqualShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bge_S, label);
		
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		public static void BranchIfGreaterThanOrEqualUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bge_Un, label);
		public static void BranchIfGreaterThanOrEqualUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bge_Un_S, label);

		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}

		#endregion

		#region Greater

		public static void BranchIfGreater(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bgt, label);
		public static void BranchIfGreaterShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bgt_S, label);
		
		public static void BranchIfGreaterThan(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		public static void BranchIfGreaterThan(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		public static void BranchIfGreaterThan(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		public static void BranchIfGreaterThan(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		public static void BranchIfGreaterThan(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		public static void BranchIfGreaterThan(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		public static void BranchIfGreaterThan(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		public static void BranchIfGreaterUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bgt_Un, label);
		public static void BranchIfGreaterUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bgt_Un_S, label);

		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}

		public static void CompareGreater(this ILGenerator generator) => generator.Emit(OpCodes.Cgt);

		public static void CompareGreaterThan(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		public static void CompareGreaterThan(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		public static void CompareGreaterThan(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		public static void CompareGreaterThan(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		public static void CompareGreaterThan(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		public static void CompareGreaterThan(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		public static void CompareGreaterThan(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}

		public static void CompareGreaterUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Cgt_Un);

		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}

		#endregion

		#region LessThanOrEqual

		public static void BranchIfLessThanOrEqual(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Ble, label);
		public static void BranchIfLessThanOrEqualShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Ble_S, label);
		
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		public static void BranchIfLessThanOrEqualUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Ble_Un, label);
		public static void BranchIfLessThanOrEqualUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Ble_Un_S, label);

		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}

		#endregion

		#region Less

		public static void BranchIfLess(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Blt, label);
		public static void BranchIfLessShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Blt_S, label);
		
		public static void BranchIfLessThan(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		public static void BranchIfLessThanShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		public static void BranchIfLessThan(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		public static void BranchIfLessThanShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		public static void BranchIfLessThan(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		public static void BranchIfLessThanShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		public static void BranchIfLessThan(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		public static void BranchIfLessThanShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		public static void BranchIfLessThan(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		public static void BranchIfLessThanShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		public static void BranchIfLessThan(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		public static void BranchIfLessThanShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		public static void BranchIfLessThan(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		public static void BranchIfLessThanShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		public static void BranchIfLessUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Blt_Un, label);
		public static void BranchIfLessUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Blt_Un_S, label);

		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}

		public static void CompareLess(this ILGenerator generator) => generator.Emit(OpCodes.Clt);

		public static void CompareLessThan(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		public static void CompareLessThan(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		public static void CompareLessThan(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		public static void CompareLessThan(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		public static void CompareLessThan(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		public static void CompareLessThan(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		public static void CompareLessThan(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}

		public static void CompareLessUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Clt_Un);

		public static void CompareLessThanUnsigned(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		public static void CompareLessThanUnsigned(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		public static void CompareLessThanUnsigned(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		public static void CompareLessThanUnsigned(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		public static void CompareLessThanUnsigned(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		public static void CompareLessThanUnsigned(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		public static void CompareLessThanUnsigned(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}

		#endregion

		#region True

		public static void BranchIfTrue(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Brtrue, label);
		public static void BranchIfTrueShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Brtrue_S, label);
		
		public static void BranchIfTrue(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		public static void BranchIfTrueShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		public static void BranchIfTrue(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		public static void BranchIfTrueShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		public static void BranchIfTrue(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		public static void BranchIfTrueShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		public static void BranchIfTrue(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		public static void BranchIfTrueShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		public static void BranchIfTrue(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		public static void BranchIfTrueShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		public static void BranchIfTrue(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		public static void BranchIfTrueShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		public static void BranchIfTrue(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		public static void BranchIfTrueShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		#endregion

		#region False

		public static void BranchIfFalse(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Brfalse, label);
		public static void BranchIfFalseShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Brfalse_S, label);
		
		public static void BranchIfFalse(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		public static void BranchIfFalseShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		public static void BranchIfFalse(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		public static void BranchIfFalseShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		public static void BranchIfFalse(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		public static void BranchIfFalseShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		public static void BranchIfFalse(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		public static void BranchIfFalseShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		public static void BranchIfFalse(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		public static void BranchIfFalseShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		public static void BranchIfFalse(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		public static void BranchIfFalseShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		public static void BranchIfFalse(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		public static void BranchIfFalseShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		#endregion


		#region null
		
		public static void BranchIfNull(this ILGenerator generator, Label label)
		{
			generator.LoadNull();
			generator.BranchIfEqual(label);
		}

		public static void BranchIfNullShortForm(this ILGenerator generator, Label label)
		{
			generator.LoadNull();
			generator.BranchIfEqualShortForm(label);
		}

		#endregion
	}
}
