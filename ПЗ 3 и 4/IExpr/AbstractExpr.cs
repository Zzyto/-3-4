using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ПЗ_3_и_4.IExpr.MainStruct.BinaryOperations;
using ПЗ_3_и_4.IExpr.MainStruct.UnaryOperations;
using ПЗ_3_и_4.IExpr.MainStruct;

namespace ПЗ_3_и_4.IExpr
{
    abstract public class AbstractExpr : IExpr
    {
        abstract public IEnumerable<string> Variables { get; }
        abstract public bool IsConstant { get; }
        abstract public bool IsPolynom { get; }
        abstract public double Compute(IReadOnlyDictionary<string, double> variableValues);
        //Унарный минус
        public static Minus operator -(AbstractExpr expression) => new(expression);
        //Сложение
        public static Sum operator +(AbstractExpr RightExpression, AbstractExpr LeftExpresion) => new(RightExpression, LeftExpresion);
        public static Sum operator +(AbstractExpr RightExpression, double val) => new(RightExpression, new Constant(val));
        public static Sum operator +(double val, AbstractExpr LeftExpresion) => new(new Constant(val), LeftExpresion);
        //Вычитание
        public static Sub operator -(AbstractExpr RightExpression, AbstractExpr LeftExpresion) => new(RightExpression, LeftExpresion);
        public static Sub operator -(AbstractExpr RightExpression, double val) => new(RightExpression, new Constant(val));
        public static Sub operator -(double val, AbstractExpr LeftExpresion) => new(new Constant(val), LeftExpresion);
        //Умножение
        public static Mult operator *(AbstractExpr LeftExpression, AbstractExpr RightExpression) => new(LeftExpression, RightExpression);
        public static Mult operator *(AbstractExpr LeftExpression, double val) => new(LeftExpression, new Constant(val));
        public static Mult operator *(double val, AbstractExpr RightExpression) => new(new Constant(val), RightExpression);
        //Деление
        public static Divide operator /(AbstractExpr LeftExpression, AbstractExpr RightExpression) => new(LeftExpression, RightExpression);
        public static Divide operator /(AbstractExpr LeftExpression, double val) => new(LeftExpression, new Constant(val));
        public static Divide operator /(double val, AbstractExpr RightExpression) => new(new Constant(val), RightExpression);
    }
}