using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_3_и_4.IExpr.MainStruct.Functions
{
    public class Sin : TrigFunction
    {
        public Sin(AbstractExpr expression) : base(expression) { }

        public override double Compute(IReadOnlyDictionary<string, double> variableValues) =>
            Math.Sin(Expression.Compute(variableValues));

        public override string ToString() => $"Sin({Expression})";
    }
}
