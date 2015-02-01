using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ILGeneratorExtensions
{
    /// <summary>
    /// Contains extension methods for manipulating fields
    /// </summary>
    public static partial class Fields
    {
        #region LoadField

        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the value of the given field for that object
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="field">The field to load</param>
        [PublicAPI]
        public static ILGenerator LoadField(this ILGenerator generator, FieldInfo field)
            => generator.FluentEmit(field.IsStatic ? OpCodes.Ldsfld : OpCodes.Ldfld, field);

        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the value of the field (with the given name on the given type) for that object
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type the field is on</param>
        /// <param name="fieldName">The name of the field</param>
        [PublicAPI]
        public static ILGenerator LoadField(this ILGenerator generator, Type type, string fieldName)
            => generator.LoadField(GetFieldInfo(type, fieldName));

        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the value of the field (with the given name on the given type) for that object
        /// </summary>
        /// <typeparam name="T">The type the field is on</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="fieldName">The name of the field</param>
        [PublicAPI]
        public static ILGenerator LoadField<T>(this ILGenerator generator, string fieldName)
            => generator.LoadField(typeof(T), fieldName);

        /// <summary>
        /// Pushes the value of the static field represented by the given expression
        /// </summary>
        /// <typeparam name="TField">The type of the field</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="fieldExpression">An expression representing the field to load</param>
        [PublicAPI]
        public static ILGenerator LoadField<TField>(this ILGenerator generator, Expression<Func<TField>> fieldExpression)
            => generator.LoadField(GetFieldInfo(fieldExpression));

        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the value of the field represented by the given expression for that object
        /// </summary>
        /// <typeparam name="T">The type the field is on</typeparam>
        /// <typeparam name="TField">The type of the field</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="fieldExpression">An expression representing the field to load</param>
        [PublicAPI]
        public static ILGenerator LoadField<T, TField>(this ILGenerator generator, Expression<Func<T, TField>> fieldExpression)
            => generator.LoadField(GetFieldInfo(fieldExpression));

        #endregion
        #region LoadFieldVolatile
        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the value of the given field for that object, with volatile semantics
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="field">The field to load</param>
        [PublicAPI]
        public static ILGenerator LoadFieldVolatile(this ILGenerator generator, FieldInfo field)
        {
            return generator.FluentEmit(OpCodes.Volatile)
                            .LoadField(field);
        }

        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the value of the field (with the given name on the given type) for that object, with volatile semantics
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type the field is on</param>
        /// <param name="fieldName">The name of the field</param>
        [PublicAPI]
        public static ILGenerator LoadFieldVolatile(this ILGenerator generator, Type type, string fieldName)
            => generator.LoadFieldVolatile(GetFieldInfo(type, fieldName));

        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the value of the field (with the given name on the given type) for that object, with volatile semantics
        /// </summary>
        /// <typeparam name="T">The type the field is on</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="fieldName">The name of the field</param>
        [PublicAPI]
        public static ILGenerator LoadFieldVolatile<T>(this ILGenerator generator, string fieldName)
            => generator.LoadFieldVolatile(typeof(T), fieldName);

        /// <summary>
        ///Pushes the value of the static field represented by the given expression, with volatile semantics
        /// </summary>
        /// <typeparam name="TField">The type of the field</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="fieldExpression">An expression representing the field to load</param>
        [PublicAPI]
        public static ILGenerator LoadFieldVolatile<TField>(this ILGenerator generator, Expression<Func<TField>> fieldExpression)
            => generator.LoadFieldVolatile(GetFieldInfo(fieldExpression));

        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the value of the field represented by the given expression for that object, with volatile semantics
        /// </summary>
        /// <typeparam name="T">The type the field is on</typeparam>
        /// <typeparam name="TField">The type of the field</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="fieldExpression">An expression representing the field to load</param>
        [PublicAPI]
        public static ILGenerator LoadFieldVolatile<T, TField>(this ILGenerator generator, Expression<Func<T, TField>> fieldExpression)
            => generator.LoadFieldVolatile(GetFieldInfo(fieldExpression));

        #endregion
        #region LoadFieldAddress
        
        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the address of the given field for that object
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="field">The field to load</param>
        [PublicAPI]
        public static ILGenerator LoadFieldAddress(this ILGenerator generator, FieldInfo field)
        {
            return generator.FluentEmit(field.IsStatic ? OpCodes.Ldsflda : OpCodes.Ldflda, field);
        }

        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the address of the field (with the given name on the given type) for that object
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type the field is on</param>
        /// <param name="fieldName">The name of the field</param>
        [PublicAPI]
        public static ILGenerator LoadFieldAddress(this ILGenerator generator, Type type, string fieldName)
            => generator.LoadFieldAddress(GetFieldInfo(type, fieldName));

        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the address of the field (with the given name on the given type) for that object
        /// </summary>
        /// <typeparam name="T">The type the field is on</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="fieldName">The name of the field</param>
        [PublicAPI]
        public static ILGenerator LoadFieldAddress<T>(this ILGenerator generator, string fieldName)
            => generator.LoadFieldAddress(typeof(T), fieldName);

        /// <summary>
        /// Pushes the address of the static field represented by the given expression
        /// </summary>
        /// <typeparam name="TField">The type of the field</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="fieldExpression">An expression representing the field to load</param>
        [PublicAPI]
        public static ILGenerator LoadFieldAddress<TField>(this ILGenerator generator, Expression<Func<TField>> fieldExpression)
            => generator.LoadFieldAddress(GetFieldInfo(fieldExpression));

        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the address of the field represented by the given expression for that object
        /// </summary>
        /// <typeparam name="T">The type the field is on</typeparam>
        /// <typeparam name="TField">The type of the field</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="fieldExpression">An expression representing the field to load</param>
        [PublicAPI]
        public static ILGenerator LoadFieldAddress<T, TField>(this ILGenerator generator, Expression<Func<T, TField>> fieldExpression)
            => generator.LoadFieldAddress(GetFieldInfo(fieldExpression));

        #endregion
        #region LoadFieldAddressVolatile

        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the address of the given field for that object, with volatile semantics
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="field">The field to load</param>
        [PublicAPI]
        public static ILGenerator LoadFieldAddressVolatile(this ILGenerator generator, FieldInfo field)
        {
            return generator.FluentEmit(OpCodes.Volatile)
                            .LoadFieldAddress(field);
        }

        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the address of the field (with the given name on the given type) for that object, with volatile semantics
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type the field is on</param>
        /// <param name="fieldName">The name of the field</param>
        [PublicAPI]
        public static ILGenerator LoadFieldAddressVolatile(this ILGenerator generator, Type type, string fieldName)
            => generator.LoadFieldAddressVolatile(GetFieldInfo(type, fieldName));

        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the address of the field (with the given name on the given type) for that object, with volatile semantics
        /// </summary>
        /// <typeparam name="T">The type the field is on</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="fieldName">The name of the field</param>
        [PublicAPI]
        public static ILGenerator LoadFieldAddressVolatile<T>(this ILGenerator generator, string fieldName)
            => generator.LoadFieldAddressVolatile(typeof(T), fieldName);

        /// <summary>
        /// Pushes the address of the static field represented by the given expression, with volatile semantics
        /// </summary>
        /// <typeparam name="TField">The type of the field</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="fieldExpression">An expression representing the field to load</param>
        [PublicAPI]
        public static ILGenerator LoadFieldAddressVolatile<TField>(this ILGenerator generator, Expression<Func<TField>> fieldExpression)
            => generator.LoadFieldAddressVolatile(GetFieldInfo(fieldExpression));

        /// <summary>
        /// Pops a reference from the evaluation stack and pushes the address of the field represented by the given expression for that object, with volatile semantics
        /// </summary>
        /// <typeparam name="T">The type the field is on</typeparam>
        /// <typeparam name="TField">The type of the field</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="fieldExpression">An expression representing the field to load</param>
        [PublicAPI]
        public static ILGenerator LoadFieldAddressVolatile<T, TField>(this ILGenerator generator, Expression<Func<T, TField>> fieldExpression)
            => generator.LoadFieldAddressVolatile(GetFieldInfo(fieldExpression));

        #endregion
        #region StoreInField

        /// <summary>
        /// Pops a reference and a value from the evaluation stack and stores the value in the given field for that object
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="field">The field to store the value in</param>
        [PublicAPI]
        public static ILGenerator StoreInField(this ILGenerator generator, FieldInfo field)
            => generator.FluentEmit(field.IsStatic ? OpCodes.Stsfld : OpCodes.Stfld, field);

        /// <summary>
        /// Pops a reference and a value from the evaluation stack and stores the value in the field (with the given name on the given type) for that object
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type the field is on</param>
        /// <param name="fieldName">The name of the field</param>
        [PublicAPI]
        public static ILGenerator StoreInField(this ILGenerator generator, Type type, string fieldName)
            => generator.StoreInField(GetFieldInfo(type, fieldName));

        /// <summary>
        /// Pops a reference and a value from the evaluation stack and stores the value in the field (with the given name on the given type) for that object
        /// </summary>
        /// <typeparam name="T">The type the field is on</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="fieldName">The name of the field</param>
        [PublicAPI]
        public static ILGenerator StoreInField<T>(this ILGenerator generator, string fieldName)
            => generator.StoreInField(typeof(T), fieldName);

        /// <summary>
        /// Pops a value from the evaluation stack and stores the value in the static field represented by the given expression
        /// </summary>
        /// <typeparam name="TField">The type of the field</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="fieldExpression">An expression representing the field to load</param>
        [PublicAPI]
        public static ILGenerator StoreInField<TField>(this ILGenerator generator, Expression<Func<TField>> fieldExpression)
            => generator.StoreInField(GetFieldInfo(fieldExpression));

        /// <summary>
        /// Pops a reference and a value from the evaluation stack and stores the value in the field represented by the given expression for that object
        /// </summary>
        /// <typeparam name="T">The type the field is on</typeparam>
        /// <typeparam name="TField">The type of the field</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="fieldExpression">An expression representing the field to load</param>
        [PublicAPI]
        public static ILGenerator StoreInField<T, TField>(this ILGenerator generator, Expression<Func<T, TField>> fieldExpression)
            => generator.StoreInField(GetFieldInfo(fieldExpression));

        #endregion
        #region StoreInFieldVolatile

        /// <summary>
        /// Pops a reference and a value from the evaluation stack and stores the value in the given field for that object, with volatile semantics
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="field">The field to store the value in</param>
        [PublicAPI]
        public static ILGenerator StoreInFieldVolatile(this ILGenerator generator, FieldInfo field)
        {
            return generator.FluentEmit(OpCodes.Volatile)
                            .StoreInField(field);
        }

        /// <summary>
        /// Pops a reference and a value from the evaluation stack and stores the value in the field (with the given name on the given type) for that object, with volatile semantics
        /// </summary>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="type">The type the field is on</param>
        /// <param name="fieldName">The name of the field</param>
        [PublicAPI]
        public static ILGenerator StoreInFieldVolatile(this ILGenerator generator, Type type, string fieldName)
            => generator.StoreInFieldVolatile(GetFieldInfo(type, fieldName));

        /// <summary>
        /// Pops a reference and a value from the evaluation stack and stores the value in the field (with the given name on the given type) for that object, with volatile semantics
        /// </summary>
        /// <typeparam name="T">The type the field is on</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="fieldName">The name of the field</param>
        [PublicAPI]
        public static ILGenerator StoreInFieldVolatile<T>(this ILGenerator generator, string fieldName)
            => generator.StoreInFieldVolatile(typeof(T), fieldName);

        /// <summary>
        /// Pops a value from the evaluation stack and stores the value in the static field represented by the given expression, with volatile semantics
        /// </summary>
        /// <typeparam name="TField">The type of the field</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="fieldExpression">An expression representing the field to load</param>
        [PublicAPI]
        public static ILGenerator StoreInFieldVolatile<TField>(this ILGenerator generator, Expression<Func<TField>> fieldExpression)
            => generator.StoreInFieldVolatile(GetFieldInfo(fieldExpression));

        /// <summary>
        /// Pops a reference and a value from the evaluation stack and stores the value in the field represented by the given expression for that object, with volatile semantics
        /// </summary>
        /// <typeparam name="T">The type the field is on</typeparam>
        /// <typeparam name="TField">The type of the field</typeparam>
        /// <param name="generator">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
        /// <param name="fieldExpression">An expression representing the field to load</param>
        [PublicAPI]
        public static ILGenerator StoreInFieldVolatile<T, TField>(this ILGenerator generator, Expression<Func<T, TField>> fieldExpression)
            => generator.StoreInFieldVolatile(GetFieldInfo(fieldExpression));

        #endregion

        #region GetFieldInfo

        private static FieldInfo GetFieldInfo<T, TField>(Expression<Func<T, TField>> expression)
        {
            var field = (expression?.Body as MemberExpression)?.Member as FieldInfo;

            if (field == null)
            {
                throw new InvalidOperationException("Expression does not represent a field");
            }

            return field;
        }

        private static FieldInfo GetFieldInfo<TField>(Expression<Func<TField>> expression)
        {
            var field = (expression?.Body as MemberExpression)?.Member as FieldInfo;

            if (field == null)
            {
                throw new InvalidOperationException("Expression does not represent a field");
            }

            return field;
        }

        private static FieldInfo GetFieldInfo(Type type, string fieldName)
        {
            var field = type.GetField(fieldName, BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);

            if (field == null)
            {
                throw new InvalidOperationException("Field with name `" + fieldName + "` cannot be found on type " + type.Name);
            }

            return field;
        }

        #endregion
    }
}
