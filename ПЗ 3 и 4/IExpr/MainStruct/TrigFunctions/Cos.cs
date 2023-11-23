using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_3_и_4.IExpr.MainStruct.Functions
{
    public class Cos : TrigFunction
    {
        public Cos(AbstractExpr expression) : base(expression) { }

        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => Math.Cos(Expression.Compute(variableValues));

        public override string ToString() => $"Cos({Expression})";
        public override AbstractExpr Differential(Variable differentialVariable)
        {
            if (Expression.Variables.Contains<string>(differentialVariable.ToString()))
                return -(new Sin(Expression) * Expression.Differential(differentialVariable));
            return 0;
        }
    }
}
