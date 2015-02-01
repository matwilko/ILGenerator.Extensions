using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ILGeneratorExtensions
{
	public static class FluentInterface
	{
        public static ILGenerator FluentEmit(this ILGenerator generator, OpCode opcode)
        {
            generator.Emit(opcode);
            return generator;
        }

        public static ILGenerator FluentEmit(this ILGenerator generator, OpCode opcode, Byte arg)
        {
            generator.Emit(opcode, arg);
            return generator;
        }

        public static ILGenerator FluentEmit(this ILGenerator generator, OpCode opcode, SByte arg)
        {
            generator.Emit(opcode, arg);
            return generator;
        }

        public static ILGenerator FluentEmit(this ILGenerator generator, OpCode opcode, Int16 arg)
        {
            generator.Emit(opcode, arg);
            return generator;
        }

        public static ILGenerator FluentEmit(this ILGenerator generator, OpCode opcode, Int32 arg)
        {
            generator.Emit(opcode, arg);
            return generator;
        }

        public static ILGenerator FluentEmit(this ILGenerator generator, OpCode opcode, MethodInfo meth)
        {
            generator.Emit(opcode, meth);
            return generator;
        }

        public static ILGenerator FluentEmit(this ILGenerator generator, OpCode opcode, SignatureHelper signature)
        {
            generator.Emit(opcode, signature);
            return generator;
        }

        public static ILGenerator FluentEmit(this ILGenerator generator, OpCode opcode, ConstructorInfo con)
        {
            generator.Emit(opcode, con);
            return generator;
        }

        public static ILGenerator FluentEmit(this ILGenerator generator, OpCode opcode, Type cls)
        {
            generator.Emit(opcode, cls);
            return generator;
        }

        public static ILGenerator FluentEmit(this ILGenerator generator, OpCode opcode, Int64 arg)
        {
            generator.Emit(opcode, arg);
            return generator;
        }

        public static ILGenerator FluentEmit(this ILGenerator generator, OpCode opcode, Single arg)
        {
            generator.Emit(opcode, arg);
            return generator;
        }

        public static ILGenerator FluentEmit(this ILGenerator generator, OpCode opcode, Double arg)
        {
            generator.Emit(opcode, arg);
            return generator;
        }

        public static ILGenerator FluentEmit(this ILGenerator generator, OpCode opcode, Label label)
        {
            generator.Emit(opcode, label);
            return generator;
        }

        public static ILGenerator FluentEmit(this ILGenerator generator, OpCode opcode, Label[] labels)
        {
            generator.Emit(opcode, labels);
            return generator;
        }

        public static ILGenerator FluentEmit(this ILGenerator generator, OpCode opcode, FieldInfo field)
        {
            generator.Emit(opcode, field);
            return generator;
        }

        public static ILGenerator FluentEmit(this ILGenerator generator, OpCode opcode, String str)
        {
            generator.Emit(opcode, str);
            return generator;
        }

        public static ILGenerator FluentEmit(this ILGenerator generator, OpCode opcode, LocalBuilder local)
        {
            generator.Emit(opcode, local);
            return generator;
        }

    }
}