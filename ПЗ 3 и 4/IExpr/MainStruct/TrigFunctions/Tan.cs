using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_3_и_4.IExpr.MainStruct.Functions
{
    public class Tan : TrigFunction
    {
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => Math.Tan(Expression.Compute(variableValues));
        public Tan(AbstractExpr expression) : base(expression) { }
        public override string ToString() => $"Tan({Expression})";
    }
}
