using System;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
	public static class Locals
	{
		public static void LoadLocal(this ILGenerator generator, LocalBuilder local)
	    {
	        switch (local.LocalIndex)
	        {
                case 0:
                    generator.Emit(OpCodes.Ldloc_0);
	                break;
                case 1:
                    generator.Emit(OpCodes.Ldloc_1);
                    break;
                case 2:
                    generator.Emit(OpCodes.Ldloc_2);
                    break;
                default:
	                if (local.LocalIndex <= 255)
	                {
	                    generator.Emit(OpCodes.Ldloc_S, local);
	                }
	                else
	                {
	                    generator.Emit(OpCodes.Ldloc, local);
	                }

                    break;
            }
	    }

	    public static void LoadLocalAddress(this ILGenerator generator, LocalBuilder local)
	    {
	        if (local.LocalIndex <= 255)
	        {
	            generator.Emit(OpCodes.Ldloca_S, local);
	        }
	        else
	        {
	            generator.Emit(OpCodes.Ldloca, local);
	        }
	    }

	    public static void StoreInLocal(this ILGenerator generator, LocalBuilder local)
	    {
	        switch (local.LocalIndex)
	        {
                case 0:
                    generator.Emit(OpCodes.Stloc_0);
                    break;
                case 1:
                    generator.Emit(OpCodes.Stloc_1);
                    break;
                case 2:
                    generator.Emit(OpCodes.Stloc_2);
                    break;
                default:
                    if (local.LocalIndex <= 255)
                    {
                        generator.Emit(OpCodes.Stloc_S, local);
                    }
                    else
                    {
                        generator.Emit(OpCodes.Stloc, local);
                    }

                    break;
            }
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