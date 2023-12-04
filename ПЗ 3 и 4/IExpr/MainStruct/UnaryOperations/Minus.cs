using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_3_и_4.IExpr.MainStruct.UnaryOperations
{
    public class Minus : UnaryOperation
    {
        public Minus(AbstractExpr expression) : base(expression, "-") { }

        public override double Compute(IReadOnlyDictionary<string, double> variableValues) =>  -(Expression.Compute(variableValues));
        public override AbstractExpr Differential(Variable differentialVariable) =>
            -(Expression.Differential(differentialVariable));
    }
}