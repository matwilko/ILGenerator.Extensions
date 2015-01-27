using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
	[PublicAPI]
	public static partial class Locals
	{
		
		/// <summary>
        /// Stores the given value in the given local
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="local">The local to store value in</param>
		/// <param name="value">The value to store in the local</param>
		/// <exception cref="ArgumentException">Thrown if the local is not of type <see cref="Boolean" /></exception>
		[PublicAPI]
		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, Boolean value)
		{
			if (local.LocalType != typeof(Boolean))
			{
				throw new ArgumentException("Cannot store a Boolean value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		/// <summary>
        /// Stores the given value in the given local
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="local">The local to store value in</param>
		/// <param name="value">The value to store in the local</param>
		/// <exception cref="ArgumentException">Thrown if the local is not of type <see cref="Char" /></exception>
		[PublicAPI]
		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, Char value)
		{
			if (local.LocalType != typeof(Char))
			{
				throw new ArgumentException("Cannot store a Char value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		/// <summary>
        /// Stores the given value in the given local
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="local">The local to store value in</param>
		/// <param name="value">The value to store in the local</param>
		/// <exception cref="ArgumentException">Thrown if the local is not of type <see cref="SByte" /></exception>
		[PublicAPI]
		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, SByte value)
		{
			if (local.LocalType != typeof(SByte))
			{
				throw new ArgumentException("Cannot store a SByte value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		/// <summary>
        /// Stores the given value in the given local
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="local">The local to store value in</param>
		/// <param name="value">The value to store in the local</param>
		/// <exception cref="ArgumentException">Thrown if the local is not of type <see cref="Byte" /></exception>
		[PublicAPI]
		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, Byte value)
		{
			if (local.LocalType != typeof(Byte))
			{
				throw new ArgumentException("Cannot store a Byte value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		/// <summary>
        /// Stores the given value in the given local
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="local">The local to store value in</param>
		/// <param name="value">The value to store in the local</param>
		/// <exception cref="ArgumentException">Thrown if the local is not of type <see cref="Int16" /></exception>
		[PublicAPI]
		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, Int16 value)
		{
			if (local.LocalType != typeof(Int16))
			{
				throw new ArgumentException("Cannot store a Int16 value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		/// <summary>
        /// Stores the given value in the given local
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="local">The local to store value in</param>
		/// <param name="value">The value to store in the local</param>
		/// <exception cref="ArgumentException">Thrown if the local is not of type <see cref="UInt16" /></exception>
		[PublicAPI]
		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, UInt16 value)
		{
			if (local.LocalType != typeof(UInt16))
			{
				throw new ArgumentException("Cannot store a UInt16 value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		/// <summary>
        /// Stores the given value in the given local
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="local">The local to store value in</param>
		/// <param name="value">The value to store in the local</param>
		/// <exception cref="ArgumentException">Thrown if the local is not of type <see cref="Int32" /></exception>
		[PublicAPI]
		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, Int32 value)
		{
			if (local.LocalType != typeof(Int32))
			{
				throw new ArgumentException("Cannot store a Int32 value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		/// <summary>
        /// Stores the given value in the given local
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="local">The local to store value in</param>
		/// <param name="value">The value to store in the local</param>
		/// <exception cref="ArgumentException">Thrown if the local is not of type <see cref="UInt32" /></exception>
		[PublicAPI]
		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, UInt32 value)
		{
			if (local.LocalType != typeof(UInt32))
			{
				throw new ArgumentException("Cannot store a UInt32 value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		/// <summary>
        /// Stores the given value in the given local
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="local">The local to store value in</param>
		/// <param name="value">The value to store in the local</param>
		/// <exception cref="ArgumentException">Thrown if the local is not of type <see cref="Int64" /></exception>
		[PublicAPI]
		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, Int64 value)
		{
			if (local.LocalType != typeof(Int64))
			{
				throw new ArgumentException("Cannot store a Int64 value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		/// <summary>
        /// Stores the given value in the given local
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="local">The local to store value in</param>
		/// <param name="value">The value to store in the local</param>
		/// <exception cref="ArgumentException">Thrown if the local is not of type <see cref="UInt64" /></exception>
		[PublicAPI]
		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, UInt64 value)
		{
			if (local.LocalType != typeof(UInt64))
			{
				throw new ArgumentException("Cannot store a UInt64 value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		/// <summary>
        /// Stores the given value in the given local
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="local">The local to store value in</param>
		/// <param name="value">The value to store in the local</param>
		/// <exception cref="ArgumentException">Thrown if the local is not of type <see cref="Single" /></exception>
		[PublicAPI]
		public static void OverwriteLocalWith(this ILGenerator generator, LocalBuilder local, Single value)
		{
			if (local.LocalType != typeof(Single))
			{
				throw new ArgumentException("Cannot store a Single value in a local of type " + local.LocalType.Name);
			}

			generator.LoadConstant(value);
			generator.StoreInLocal(local);
		}

		/// <summary>
        /// Stores the given value in the given local
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="local">The local to store value in</param>
		/// <param name="value">The value to store in the local</param>
		/// <exception cref="ArgumentException">Thrown if the local is not of type <see cref="Double" /></exception>
		[PublicAPI]
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