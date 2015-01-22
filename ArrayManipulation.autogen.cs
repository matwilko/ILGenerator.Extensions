using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    public static partial class ArrayManipulation
    {
		[UsedImplicitly]
		public static void StoreElementAtIndex(this ILGenerator generator, Boolean value, uint index)
        {
            generator.LoadConstant(index);
			generator.LoadConstant(value);
            generator.StoreElement<Boolean>();
        }

		[UsedImplicitly]
		public static void StoreElementAtIndex(this ILGenerator generator, Char value, uint index)
        {
            generator.LoadConstant(index);
			generator.LoadConstant(value);
            generator.StoreElement<Char>();
        }

		[UsedImplicitly]
		public static void StoreElementAtIndex(this ILGenerator generator, SByte value, uint index)
        {
            generator.LoadConstant(index);
			generator.LoadConstant(value);
            generator.StoreElement<SByte>();
        }

		[UsedImplicitly]
		public static void StoreElementAtIndex(this ILGenerator generator, Byte value, uint index)
        {
            generator.LoadConstant(index);
			generator.LoadConstant(value);
            generator.StoreElement<Byte>();
        }

		[UsedImplicitly]
		public static void StoreElementAtIndex(this ILGenerator generator, Int16 value, uint index)
        {
            generator.LoadConstant(index);
			generator.LoadConstant(value);
            generator.StoreElement<Int16>();
        }

		[UsedImplicitly]
		public static void StoreElementAtIndex(this ILGenerator generator, UInt16 value, uint index)
        {
            generator.LoadConstant(index);
			generator.LoadConstant(value);
            generator.StoreElement<UInt16>();
        }

		[UsedImplicitly]
		public static void StoreElementAtIndex(this ILGenerator generator, Int32 value, uint index)
        {
            generator.LoadConstant(index);
			generator.LoadConstant(value);
            generator.StoreElement<Int32>();
        }

		[UsedImplicitly]
		public static void StoreElementAtIndex(this ILGenerator generator, UInt32 value, uint index)
        {
            generator.LoadConstant(index);
			generator.LoadConstant(value);
            generator.StoreElement<UInt32>();
        }

		[UsedImplicitly]
		public static void StoreElementAtIndex(this ILGenerator generator, Int64 value, uint index)
        {
            generator.LoadConstant(index);
			generator.LoadConstant(value);
            generator.StoreElement<Int64>();
        }

		[UsedImplicitly]
		public static void StoreElementAtIndex(this ILGenerator generator, UInt64 value, uint index)
        {
            generator.LoadConstant(index);
			generator.LoadConstant(value);
            generator.StoreElement<UInt64>();
        }

		[UsedImplicitly]
		public static void StoreElementAtIndex(this ILGenerator generator, Single value, uint index)
        {
            generator.LoadConstant(index);
			generator.LoadConstant(value);
            generator.StoreElement<Single>();
        }

		[UsedImplicitly]
		public static void StoreElementAtIndex(this ILGenerator generator, Double value, uint index)
        {
            generator.LoadConstant(index);
			generator.LoadConstant(value);
            generator.StoreElement<Double>();
        }

    }
}
