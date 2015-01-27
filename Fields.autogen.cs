using System;
using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
	[PublicAPI]
    public static partial class Fields
    {
		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="Boolean" /></exception>
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

		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object, with volatile semantics
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="Boolean" /></exception>
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
		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="Char" /></exception>
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

		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object, with volatile semantics
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="Char" /></exception>
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
		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="SByte" /></exception>
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

		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object, with volatile semantics
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="SByte" /></exception>
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
		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="Byte" /></exception>
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

		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object, with volatile semantics
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="Byte" /></exception>
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
		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="Int16" /></exception>
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

		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object, with volatile semantics
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="Int16" /></exception>
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
		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="UInt16" /></exception>
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

		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object, with volatile semantics
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="UInt16" /></exception>
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
		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="Int32" /></exception>
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

		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object, with volatile semantics
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="Int32" /></exception>
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
		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="UInt32" /></exception>
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

		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object, with volatile semantics
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="UInt32" /></exception>
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
		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="Int64" /></exception>
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

		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object, with volatile semantics
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="Int64" /></exception>
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
		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="UInt64" /></exception>
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

		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object, with volatile semantics
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="UInt64" /></exception>
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
		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="Single" /></exception>
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

		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object, with volatile semantics
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="Single" /></exception>
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
		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="Double" /></exception>
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

		/// <summary>
        /// Pops a reference from the execution stack and stores the given value in the given field for that object, with volatile semantics
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="field">The field to store the value in</param>
		/// <param name="value">The value to overwrite the field with</param>
		/// <exception cref="InvalidOperationException">Thrown if the field is not of type <see cref="Double" /></exception>
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