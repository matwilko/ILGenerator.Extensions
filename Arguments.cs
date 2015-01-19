using System;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
	public static class Arguments
	{
		public static void LoadArgument(this ILGenerator generator, ushort argNum)
        {
            switch (argNum)
            {
                case 0:
                    generator.Emit(OpCodes.Ldarg_0);
                    break;
                case 1:
                    generator.Emit(OpCodes.Ldarg_1);
                    break;
                case 2:
                    generator.Emit(OpCodes.Ldarg_2);
                    break;
                case 3:
                    generator.Emit(OpCodes.Ldarg_3);
                    break;
                default:
                    if (argNum <= 255)
                    {
                        generator.Emit(OpCodes.Ldarg_S, (byte) argNum);
                    }
                    else
                    {
                        generator.Emit(OpCodes.Ldarg, argNum);
                    }
                    break;
            }
        }

        public static void LoadThis(this ILGenerator generator) => generator.Emit(OpCodes.Ldarg_0);

        public static void LoadArgumentAddress(this ILGenerator generator, ushort argNum)
        {
            if (argNum <= 255)
            {
                generator.Emit(OpCodes.Ldarga_S, (byte) argNum);
            }
            else
            {
                generator.Emit(OpCodes.Ldarga, argNum);
            }
        }

        public static void StoreInArgument(this ILGenerator generator, ushort argNum)
        {
            if (argNum <= 255)
            {
                generator.Emit(OpCodes.Starg_S, (byte)argNum);
            }
            else
            {
                generator.Emit(OpCodes.Starg, argNum);
            }
        }

		public static void OverwriteArgument(this ILGenerator generator, ushort argNum, Char value)
		{
			generator.LoadConstant(value);
			generator.StoreInArgument(argNum);
		}
		
		public static void OverwriteArgument(this ILGenerator generator, ushort argNum, Boolean value)
		{
			generator.LoadConstant(value);
			generator.StoreInArgument(argNum);
		}
		
		public static void OverwriteArgument(this ILGenerator generator, ushort argNum, Int32 value)
		{
			generator.LoadConstant(value);
			generator.StoreInArgument(argNum);
		}
		
		public static void OverwriteArgument(this ILGenerator generator, ushort argNum, UInt32 value)
		{
			generator.LoadConstant(value);
			generator.StoreInArgument(argNum);
		}
		
		public static void OverwriteArgument(this ILGenerator generator, ushort argNum, Int64 value)
		{
			generator.LoadConstant(value);
			generator.StoreInArgument(argNum);
		}
		
		public static void OverwriteArgument(this ILGenerator generator, ushort argNum, UInt64 value)
		{
			generator.LoadConstant(value);
			generator.StoreInArgument(argNum);
		}
		
		public static void LoadArgumentList(this ILGenerator generator) => generator.Emit(OpCodes.Arglist);
	}
}