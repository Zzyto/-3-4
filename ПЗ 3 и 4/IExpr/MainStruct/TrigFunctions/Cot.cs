using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_3_и_4.IExpr.MainStruct.Functions
{
    public class Cot : TrigFunction
    {
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => 1.0 / Math.Tan(Expression.Compute(variableValues));
        public Cot(AbstractExpr expression) : base(expression) { }
        public override string ToString() => $"Cot({Expression})";
    }
}
