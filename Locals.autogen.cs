using System;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
	public static partial class Locals
	{
		
		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, Boolean value)
		{
			if (local.LocalType != typeof(Boolean))
			{
				throw new ArgumentException("Cannot store a Boolean value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, Char value)
		{
			if (local.LocalType != typeof(Char))
			{
				throw new ArgumentException("Cannot store a Char value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, SByte value)
		{
			if (local.LocalType != typeof(SByte))
			{
				throw new ArgumentException("Cannot store a SByte value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, Byte value)
		{
			if (local.LocalType != typeof(Byte))
			{
				throw new ArgumentException("Cannot store a Byte value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, Int16 value)
		{
			if (local.LocalType != typeof(Int16))
			{
				throw new ArgumentException("Cannot store a Int16 value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, UInt16 value)
		{
			if (local.LocalType != typeof(UInt16))
			{
				throw new ArgumentException("Cannot store a UInt16 value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, Int32 value)
		{
			if (local.LocalType != typeof(Int32))
			{
				throw new ArgumentException("Cannot store a Int32 value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, UInt32 value)
		{
			if (local.LocalType != typeof(UInt32))
			{
				throw new ArgumentException("Cannot store a UInt32 value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, Int64 value)
		{
			if (local.LocalType != typeof(Int64))
			{
				throw new ArgumentException("Cannot store a Int64 value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, UInt64 value)
		{
			if (local.LocalType != typeof(UInt64))
			{
				throw new ArgumentException("Cannot store a UInt64 value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, Single value)
		{
			if (local.LocalType != typeof(Single))
			{
				throw new ArgumentException("Cannot store a Single value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, Double value)
		{
			if (local.LocalType != typeof(Double))
			{
				throw new ArgumentException("Cannot store a Double value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

	}
}