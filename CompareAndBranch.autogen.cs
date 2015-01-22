using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
	[UsedImplicitly]
	public static partial class CompareAndBranch
	{

		#region Equal

		[UsedImplicitly]
		public static void BranchIfEqual(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Beq, label);
		
		[UsedImplicitly]
		public static void BranchIfEqualShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Beq_S, label);
		
		[UsedImplicitly]
		public static void BranchIfEqualTo(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfEqualTo(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfEqualTo(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfEqualTo(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfEqualTo(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfEqualTo(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfEqualTo(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfEqualToShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void CompareEqual(this ILGenerator generator) => generator.Emit(OpCodes.Ceq);

		[UsedImplicitly]
		public static void CompareEqualTo(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		[UsedImplicitly]
		public static void CompareEqualTo(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		[UsedImplicitly]
		public static void CompareEqualTo(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		[UsedImplicitly]
		public static void CompareEqualTo(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		[UsedImplicitly]
		public static void CompareEqualTo(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		[UsedImplicitly]
		public static void CompareEqualTo(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}
		[UsedImplicitly]
		public static void CompareEqualTo(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareEqual();
		}

		#endregion

		#region NotEqual
		[UsedImplicitly]
		public static void BranchIfNotEqualUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bne_Un, label);
		
		[UsedImplicitly]
		public static void BranchIfNotEqualUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bne_Un_S, label);

		[UsedImplicitly]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfNotEqualToUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfNotEqualToUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfNotEqualUnsignedShortForm(label);
		}

		#endregion

		#region GreaterThanOrEqual

		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqual(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bge, label);
		
		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bge_S, label);
		
		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualTo(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bge_Un, label);
		
		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bge_Un_S, label);

		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanOrEqualToUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterThanOrEqualUnsignedShortForm(label);
		}

		#endregion

		#region Greater

		[UsedImplicitly]
		public static void BranchIfGreater(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bgt, label);
		
		[UsedImplicitly]
		public static void BranchIfGreaterShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bgt_S, label);
		
		[UsedImplicitly]
		public static void BranchIfGreaterThan(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThan(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThan(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThan(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThan(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThan(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThan(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreater(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bgt_Un, label);
		
		[UsedImplicitly]
		public static void BranchIfGreaterUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Bgt_Un_S, label);

		[UsedImplicitly]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfGreaterThanUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfGreaterThanUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfGreaterUnsignedShortForm(label);
		}

		[UsedImplicitly]
		public static void CompareGreater(this ILGenerator generator) => generator.Emit(OpCodes.Cgt);

		[UsedImplicitly]
		public static void CompareGreaterThan(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		[UsedImplicitly]
		public static void CompareGreaterThan(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		[UsedImplicitly]
		public static void CompareGreaterThan(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		[UsedImplicitly]
		public static void CompareGreaterThan(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		[UsedImplicitly]
		public static void CompareGreaterThan(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		[UsedImplicitly]
		public static void CompareGreaterThan(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}
		[UsedImplicitly]
		public static void CompareGreaterThan(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareGreater();
		}

		[UsedImplicitly]
		public static void CompareGreaterUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Cgt_Un);

		[UsedImplicitly]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		[UsedImplicitly]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		[UsedImplicitly]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		[UsedImplicitly]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		[UsedImplicitly]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		[UsedImplicitly]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}
		[UsedImplicitly]
		public static void CompareGreaterThanUnsigned(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareGreaterUnsigned();
		}

		#endregion

		#region LessThanOrEqual

		[UsedImplicitly]
		public static void BranchIfLessThanOrEqual(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Ble, label);
		
		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Ble_S, label);
		
		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualTo(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqual(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Ble_Un, label);
		
		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Ble_Un_S, label);

		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanOrEqualToUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessThanOrEqualUnsignedShortForm(label);
		}

		#endregion

		#region Less

		[UsedImplicitly]
		public static void BranchIfLess(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Blt, label);
		
		[UsedImplicitly]
		public static void BranchIfLessShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Blt_S, label);
		
		[UsedImplicitly]
		public static void BranchIfLessThan(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThan(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThan(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThan(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThan(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThan(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThan(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLess(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessUnsigned(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Blt_Un, label);
		
		[UsedImplicitly]
		public static void BranchIfLessUnsignedShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Blt_Un_S, label);

		[UsedImplicitly]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfLessThanUnsigned(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsigned(label);
		}

		[UsedImplicitly]
		public static void BranchIfLessThanUnsignedShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfLessUnsignedShortForm(label);
		}

		[UsedImplicitly]
		public static void CompareLess(this ILGenerator generator) => generator.Emit(OpCodes.Clt);

		[UsedImplicitly]
		public static void CompareLessThan(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		[UsedImplicitly]
		public static void CompareLessThan(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		[UsedImplicitly]
		public static void CompareLessThan(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		[UsedImplicitly]
		public static void CompareLessThan(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		[UsedImplicitly]
		public static void CompareLessThan(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		[UsedImplicitly]
		public static void CompareLessThan(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}
		[UsedImplicitly]
		public static void CompareLessThan(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareLess();
		}

		[UsedImplicitly]
		public static void CompareLessUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Clt_Un);

		[UsedImplicitly]
		public static void CompareLessThanUnsigned(this ILGenerator generator, Char value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		[UsedImplicitly]
		public static void CompareLessThanUnsigned(this ILGenerator generator, Int32 value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		[UsedImplicitly]
		public static void CompareLessThanUnsigned(this ILGenerator generator, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		[UsedImplicitly]
		public static void CompareLessThanUnsigned(this ILGenerator generator, Int64 value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		[UsedImplicitly]
		public static void CompareLessThanUnsigned(this ILGenerator generator, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		[UsedImplicitly]
		public static void CompareLessThanUnsigned(this ILGenerator generator, Single value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}
		[UsedImplicitly]
		public static void CompareLessThanUnsigned(this ILGenerator generator, Double value)
		{
			generator.LoadConstant(value);
			generator.CompareLessUnsigned();
		}

		#endregion

		#region True

		[UsedImplicitly]
		public static void BranchIfTrue(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Brtrue, label);
		
		[UsedImplicitly]
		public static void BranchIfTrueShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Brtrue_S, label);
		
		[UsedImplicitly]
		public static void BranchIfTrue(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		[UsedImplicitly]
		public static void BranchIfTrueShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfTrue(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		[UsedImplicitly]
		public static void BranchIfTrueShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfTrue(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		[UsedImplicitly]
		public static void BranchIfTrueShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfTrue(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		[UsedImplicitly]
		public static void BranchIfTrueShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfTrue(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		[UsedImplicitly]
		public static void BranchIfTrueShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfTrue(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		[UsedImplicitly]
		public static void BranchIfTrueShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfTrue(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrue(label);
		}

		[UsedImplicitly]
		public static void BranchIfTrueShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfTrueShortForm(label);
		}
		#endregion

		#region False

		[UsedImplicitly]
		public static void BranchIfFalse(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Brfalse, label);
		
		[UsedImplicitly]
		public static void BranchIfFalseShortForm(this ILGenerator generator, Label label) => generator.Emit(OpCodes.Brfalse_S, label);
		
		[UsedImplicitly]
		public static void BranchIfFalse(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		[UsedImplicitly]
		public static void BranchIfFalseShortForm(this ILGenerator generator, Char value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfFalse(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		[UsedImplicitly]
		public static void BranchIfFalseShortForm(this ILGenerator generator, Int32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfFalse(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		[UsedImplicitly]
		public static void BranchIfFalseShortForm(this ILGenerator generator, UInt32 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfFalse(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		[UsedImplicitly]
		public static void BranchIfFalseShortForm(this ILGenerator generator, Int64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfFalse(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		[UsedImplicitly]
		public static void BranchIfFalseShortForm(this ILGenerator generator, UInt64 value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfFalse(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		[UsedImplicitly]
		public static void BranchIfFalseShortForm(this ILGenerator generator, Single value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		[UsedImplicitly]
		public static void BranchIfFalse(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalse(label);
		}

		[UsedImplicitly]
		public static void BranchIfFalseShortForm(this ILGenerator generator, Double value, Label label)
		{
			generator.LoadConstant(value);
			generator.BranchIfFalseShortForm(label);
		}
		#endregion

	}
}
