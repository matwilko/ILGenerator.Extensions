using System;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
	public static class ConvertTo
	{
		#region SByte

		/// <summary>
		/// Converts the signed value on the top of the evaluation stack to a signed byte (8 bit integer) with no overflow check. Pushes an int32 value onto the stack.
		/// </summary>
		public static void ConvertToSByte(this ILGenerator generator) => generator.Emit(OpCodes.Conv_U1);

		/// <summary>
		/// Converts the signed value on the top of the evaluation stack to a signed byte (8 bit integer) with an overflow check. Pushes an int32 value onto the stack.
		/// </summary>
		public static void ConvertToSByteWithOverflowCheck(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_U1);

		/// <summary>
		/// Converts the unsigned value on the top of the evaluation stack to a signed byte (8 bit integer) with an overflow check. Pushes an int32 value onto the stack.
		/// </summary>
		public static void ConvertToSByteFromUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_U1_Un);

		#endregion
		#region Byte

		/// <summary>
		/// Converts the signed value on the top of the evaluation stack to an unsigned byte (8 bit integer) with no overflow check. Pushes an int32 value onto the stack.
		/// </summary>
		public static void ConvertToByte(this ILGenerator generator) => generator.Emit(OpCodes.Conv_I1);

		/// <summary>
		/// Converts the signed value on the top of the evaluation stack to an unsigned byte (8 bit integer) with an overflow check. Pushes an int32 value onto the stack.
		/// </summary>
		public static void ConvertToByteWithOverflowCheck(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_I1);

		/// <summary>
		/// Converts the unsigned value on the top of the evaluation stack to an unsigned byte (8 bit integer) with an overflow check. Pushes an int32 value onto the stack.
		/// </summary>
		public static void ConvertToByteFromUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_I1_Un);

		#endregion
		#region UInt16

		/// <summary>
		/// Converts the signed value on the top of the evaluation stack to an unsigned short (16 bit integer) with no overflow check. Pushes an int32 value onto the stack.
		/// </summary>
		public static void ConvertToUInt16(this ILGenerator generator) => generator.Emit(OpCodes.Conv_U2);

		/// <summary>
		/// Converts the signed value on the top of the evaluation stack to an unsigned short (16 bit integer) with an overflow check. Pushes an int32 value onto the stack.
		/// </summary>
		public static void ConvertToUInt16WithOverflowCheck(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_U2);

		/// <summary>
		/// Converts the unsigned value on the top of the evaluation stack to an unsigned short (16 bit integer) with an overflow check. Pushes an int32 value onto the stack.
		/// </summary>
		public static void ConvertToUInt16FromUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_U2_Un);

		#endregion
		#region Int16

		/// <summary>
		/// Converts the signed value on the top of the evaluation stack to a signed short (16 bit integer) with no overflow check. Pushes an int32 value onto the stack.
		/// </summary>
		public static void ConvertToInt16(this ILGenerator generator) => generator.Emit(OpCodes.Conv_I2);

		/// <summary>
		/// Converts the signed value on the top of the evaluation stack to a signed short (16 bit integer) with an overflow check. Pushes an int32 value onto the stack.
		/// </summary>
		public static void ConvertToInt16WithOverflowCheck(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_I2);

		/// <summary>
		/// Converts the unsigned value on the top of the evaluation stack to a signed short (16 bit integer) with an overflow check. Pushes an int32 value onto the stack.
		/// </summary>
		public static void ConvertToInt16FromUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_I2_Un);

		#endregion
		#region UInt32

		/// <summary>
		/// Converts the signed value on the top of the evaluation stack to an unsigned integer (32 bit integer) with no overflow check. Pushes an int32 value onto the stack.
		/// </summary>
		public static void ConvertToUInt32(this ILGenerator generator) => generator.Emit(OpCodes.Conv_U4);

		/// <summary>
		/// Converts the signed value on the top of the evaluation stack to an unsigned integer (32 bit integer) with an overflow check. Pushes an int32 value onto the stack.
		/// </summary>
		public static void ConvertToUInt32WithOverflowCheck(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_U4);

		/// <summary>
		/// Converts the unsigned value on the top of the evaluation stack to an unsigned integer (32 bit integer) with an overflow check. Pushes an int32 value onto the stack.
		/// </summary>
		public static void ConvertToUInt32FromUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_U4_Un);

		#endregion
		#region Int32

		/// <summary>
		/// Converts the signed value on the top of the evaluation stack to a signed integer (32 bit integer) with no overflow check. Pushes an int32 value onto the stack.
		/// </summary>
		public static void ConvertToInt32(this ILGenerator generator) => generator.Emit(OpCodes.Conv_I4);

		/// <summary>
		/// Converts the signed value on the top of the evaluation stack to a signed integer (32 bit integer) with an overflow check. Pushes an int32 value onto the stack.
		/// </summary>
		public static void ConvertToInt32WithOverflowCheck(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_I4);

		/// <summary>
		/// Converts the unsigned value on the top of the evaluation stack to a signed integer (32 bit integer) with an overflow check. Pushes an int32 value onto the stack.
		/// </summary>
		public static void ConvertToInt32FromUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_I4_Un);

		#endregion
		#region UInt64

		/// <summary>
		/// Converts the signed value on the top of the evaluation stack to an unsigned long (64 bit integer) with no overflow check. Pushes an int64 value onto the stack.
		/// </summary>
		public static void ConvertToUInt64(this ILGenerator generator) => generator.Emit(OpCodes.Conv_U8);

		/// <summary>
		/// Converts the signed value on the top of the evaluation stack to an unsigned long (64 bit integer) with an overflow check. Pushes an int64 value onto the stack.
		/// </summary>
		public static void ConvertToUInt64WithOverflowCheck(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_U8);

		/// <summary>
		/// Converts the unsigned value on the top of the evaluation stack to an unsigned long (64 bit integer) with an overflow check. Pushes an int64 value onto the stack.
		/// </summary>
		public static void ConvertToUInt64FromUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_U8_Un);

		#endregion
		#region Int64

		/// <summary>
		/// Converts the signed value on the top of the evaluation stack to a signed long (64 bit integer) with no overflow check. Pushes an int64 value onto the stack.
		/// </summary>
		public static void ConvertToInt64(this ILGenerator generator) => generator.Emit(OpCodes.Conv_I8);

		/// <summary>
		/// Converts the signed value on the top of the evaluation stack to a signed long (64 bit integer) with an overflow check. Pushes an int64 value onto the stack.
		/// </summary>
		public static void ConvertToInt64WithOverflowCheck(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_I8);

		/// <summary>
		/// Converts the unsigned value on the top of the evaluation stack to a signed long (64 bit integer) with an overflow check. Pushes an int64 value onto the stack.
		/// </summary>
		public static void ConvertToInt64FromUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Conv_Ovf_I8_Un);

		#endregion
		#region Single

		/// <summary>
		/// Converts the signed value on the top of the evaluation stack to a single floating (8 bit integer) with no overflow check. Pushes an F value onto the stack.
		/// </summary>
		public static void ConvertToSingle(this ILGenerator generator) => generator.Emit(OpCodes.Conv_R4);

		#endregion
		#region Double

		/// <summary>
		/// Converts the signed value on the top of the evaluation stack to a signed byte (8 bit integer) with no overflow check. Pushes an F value onto the stack.
		/// </summary>
		public static void ConvertToDouble(this ILGenerator generator) => generator.Emit(OpCodes.Conv_R8);

		/// <summary>
		/// Converts the unsigned value on the top of the evaluation stack to a signed byte (8 bit integer) with an overflow check. Pushes an F value onto the stack.
		/// </summary>
		public static void ConvertToDoubleFromUnsigned(this ILGenerator generator) => generator.Emit(OpCodes.Conv_R_Un);

		#endregion
	}
}
