using System;
using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
	[PublicAPI]
    public static partial class Fields
    {
		[PublicAPI]
		public static void OverwriteFieldWith(this ILGenerator generator, FieldInfo field, Boolean value)
		{
			if (field.FieldType != typeof(Boolean))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.StoreInField(field);
		}

		[PublicAPI]
		public static void OverwriteFieldWithVolatile(this ILGenerator generator, FieldInfo field, Boolean value)
		{
			if (field.FieldType != typeof(Boolean))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.Emit(OpCodes.Volatile);
			generator.StoreInField(field);
		}
		[PublicAPI]
		public static void OverwriteFieldWith(this ILGenerator generator, FieldInfo field, Char value)
		{
			if (field.FieldType != typeof(Char))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.StoreInField(field);
		}

		[PublicAPI]
		public static void OverwriteFieldWithVolatile(this ILGenerator generator, FieldInfo field, Char value)
		{
			if (field.FieldType != typeof(Char))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.Emit(OpCodes.Volatile);
			generator.StoreInField(field);
		}
		[PublicAPI]
		public static void OverwriteFieldWith(this ILGenerator generator, FieldInfo field, SByte value)
		{
			if (field.FieldType != typeof(SByte))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.StoreInField(field);
		}

		[PublicAPI]
		public static void OverwriteFieldWithVolatile(this ILGenerator generator, FieldInfo field, SByte value)
		{
			if (field.FieldType != typeof(SByte))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.Emit(OpCodes.Volatile);
			generator.StoreInField(field);
		}
		[PublicAPI]
		public static void OverwriteFieldWith(this ILGenerator generator, FieldInfo field, Byte value)
		{
			if (field.FieldType != typeof(Byte))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.StoreInField(field);
		}

		[PublicAPI]
		public static void OverwriteFieldWithVolatile(this ILGenerator generator, FieldInfo field, Byte value)
		{
			if (field.FieldType != typeof(Byte))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.Emit(OpCodes.Volatile);
			generator.StoreInField(field);
		}
		[PublicAPI]
		public static void OverwriteFieldWith(this ILGenerator generator, FieldInfo field, Int16 value)
		{
			if (field.FieldType != typeof(Int16))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.StoreInField(field);
		}

		[PublicAPI]
		public static void OverwriteFieldWithVolatile(this ILGenerator generator, FieldInfo field, Int16 value)
		{
			if (field.FieldType != typeof(Int16))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.Emit(OpCodes.Volatile);
			generator.StoreInField(field);
		}
		[PublicAPI]
		public static void OverwriteFieldWith(this ILGenerator generator, FieldInfo field, UInt16 value)
		{
			if (field.FieldType != typeof(UInt16))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.StoreInField(field);
		}

		[PublicAPI]
		public static void OverwriteFieldWithVolatile(this ILGenerator generator, FieldInfo field, UInt16 value)
		{
			if (field.FieldType != typeof(UInt16))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.Emit(OpCodes.Volatile);
			generator.StoreInField(field);
		}
		[PublicAPI]
		public static void OverwriteFieldWith(this ILGenerator generator, FieldInfo field, Int32 value)
		{
			if (field.FieldType != typeof(Int32))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.StoreInField(field);
		}

		[PublicAPI]
		public static void OverwriteFieldWithVolatile(this ILGenerator generator, FieldInfo field, Int32 value)
		{
			if (field.FieldType != typeof(Int32))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.Emit(OpCodes.Volatile);
			generator.StoreInField(field);
		}
		[PublicAPI]
		public static void OverwriteFieldWith(this ILGenerator generator, FieldInfo field, UInt32 value)
		{
			if (field.FieldType != typeof(UInt32))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.StoreInField(field);
		}

		[PublicAPI]
		public static void OverwriteFieldWithVolatile(this ILGenerator generator, FieldInfo field, UInt32 value)
		{
			if (field.FieldType != typeof(UInt32))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.Emit(OpCodes.Volatile);
			generator.StoreInField(field);
		}
		[PublicAPI]
		public static void OverwriteFieldWith(this ILGenerator generator, FieldInfo field, Int64 value)
		{
			if (field.FieldType != typeof(Int64))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.StoreInField(field);
		}

		[PublicAPI]
		public static void OverwriteFieldWithVolatile(this ILGenerator generator, FieldInfo field, Int64 value)
		{
			if (field.FieldType != typeof(Int64))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.Emit(OpCodes.Volatile);
			generator.StoreInField(field);
		}
		[PublicAPI]
		public static void OverwriteFieldWith(this ILGenerator generator, FieldInfo field, UInt64 value)
		{
			if (field.FieldType != typeof(UInt64))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.StoreInField(field);
		}

		[PublicAPI]
		public static void OverwriteFieldWithVolatile(this ILGenerator generator, FieldInfo field, UInt64 value)
		{
			if (field.FieldType != typeof(UInt64))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.Emit(OpCodes.Volatile);
			generator.StoreInField(field);
		}
		[PublicAPI]
		public static void OverwriteFieldWith(this ILGenerator generator, FieldInfo field, Single value)
		{
			if (field.FieldType != typeof(Single))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.StoreInField(field);
		}

		[PublicAPI]
		public static void OverwriteFieldWithVolatile(this ILGenerator generator, FieldInfo field, Single value)
		{
			if (field.FieldType != typeof(Single))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.Emit(OpCodes.Volatile);
			generator.StoreInField(field);
		}
		[PublicAPI]
		public static void OverwriteFieldWith(this ILGenerator generator, FieldInfo field, Double value)
		{
			if (field.FieldType != typeof(Double))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.StoreInField(field);
		}

		[PublicAPI]
		public static void OverwriteFieldWithVolatile(this ILGenerator generator, FieldInfo field, Double value)
		{
			if (field.FieldType != typeof(Double))
			{
				throw new InvalidOperationException("Type mismatch - field is of type " + field.FieldType);
			}

			generator.LoadConstant(value);
			generator.Emit(OpCodes.Volatile);
			generator.StoreInField(field);
		}
	}
}