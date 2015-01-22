using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
	public static partial class Arguments
	{
		/// <summary>
        /// Overwrite the specified argument with the given value.
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="argNum">The index of the argument to store the value in</param>
		/// <param name="value">The value to store in the argument</param>
		[PublicAPI]
		public static void OverwriteArgument(this ILGenerator generator, ushort argNum, Char value)
		{
			generator.LoadConstant(value);
			generator.StoreInArgument(argNum);
		}
		
		/// <summary>
        /// Overwrite the specified argument with the given value.
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="argNum">The index of the argument to store the value in</param>
		/// <param name="value">The value to store in the argument</param>
		[PublicAPI]
		public static void OverwriteArgument(this ILGenerator generator, ushort argNum, Boolean value)
		{
			generator.LoadConstant(value);
			generator.StoreInArgument(argNum);
		}
		
		/// <summary>
        /// Overwrite the specified argument with the given value.
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="argNum">The index of the argument to store the value in</param>
		/// <param name="value">The value to store in the argument</param>
		[PublicAPI]
		public static void OverwriteArgument(this ILGenerator generator, ushort argNum, Int32 value)
		{
			generator.LoadConstant(value);
			generator.StoreInArgument(argNum);
		}
		
		/// <summary>
        /// Overwrite the specified argument with the given value.
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="argNum">The index of the argument to store the value in</param>
		/// <param name="value">The value to store in the argument</param>
		[PublicAPI]
		public static void OverwriteArgument(this ILGenerator generator, ushort argNum, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.StoreInArgument(argNum);
		}
		
		/// <summary>
        /// Overwrite the specified argument with the given value.
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="argNum">The index of the argument to store the value in</param>
		/// <param name="value">The value to store in the argument</param>
		[PublicAPI]
		public static void OverwriteArgument(this ILGenerator generator, ushort argNum, Int64 value)
		{
			generator.LoadConstant(value);
			generator.StoreInArgument(argNum);
		}
		
		/// <summary>
        /// Overwrite the specified argument with the given value.
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="argNum">The index of the argument to store the value in</param>
		/// <param name="value">The value to store in the argument</param>
		[PublicAPI]
		public static void OverwriteArgument(this ILGenerator generator, ushort argNum, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.StoreInArgument(argNum);
		}
		
	}
}