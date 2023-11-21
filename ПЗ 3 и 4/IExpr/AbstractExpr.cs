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

        abstract public AbstractExpr Differential(Variable differentialVariable);

        //Унарный минус
        public static Minus operator -(AbstractExpr expression) => new(expression);
        //Сложение
        public static Sum operator +(AbstractExpr RightExpression, AbstractExpr LeftExpresion) => new(RightExpression, LeftExpresion);
        //Вычитание
        public static Sub operator -(AbstractExpr RightExpression, AbstractExpr LeftExpresion) => new(RightExpression, LeftExpresion);
        //Умножение
        public static Mult operator *(AbstractExpr LeftExpression, AbstractExpr RightExpression) => new(LeftExpression, RightExpression);
        //Деление
        public static Divide operator /(AbstractExpr LeftExpression, AbstractExpr RightExpression) => new(LeftExpression, RightExpression);

        //Преобразование
        public static implicit operator AbstractExpr(double c) => new Constant(c);
    }
}