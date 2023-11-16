using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_3_и_4.IExpr.MainStruct
{
    public class Constant : AbstractExpr
    {
        private double ConstValue { get; init; }

        public override IEnumerable<string> Variables { get => Enumerable.Empty<string>(); }
        public override bool IsConstant { get => true; }
        public override bool IsPolynom { get => true; }

        public Constant(double value) => ConstValue = value;

        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => ConstValue;
        
        public override string ToString() => ConstValue.ToString();
    }
}
