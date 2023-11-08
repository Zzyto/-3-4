using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_3_и_4.IExpr.MainStruct.BinaryOperations
{
    public class Mult : BinaryOperation
    {
        public Mult(AbstractExpr firstExpression, AbstractExpr secondExpression) : base(firstExpression, secondExpression, "*") { }

        public override double Compute(IReadOnlyDictionary<string, double> variableValues) =>
            FirstExpression.Compute(variableValues) * SecondExpression.Compute(variableValues);
        
    }
}
