using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_3_и_4.IExpr.MainStruct
{
    public class Variable : AbstractExpr
    {
        private string VariableName { get; init; }

        public override IEnumerable<string> Variables => new [] { VariableName };
        public override bool IsConstant { get => false; }
        public override bool IsPolynom { get => true; }

        public Variable(string name) => VariableName = name;

        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
        {
            if (variableValues.TryGetValue(VariableName, out double value))
                return value;
            else
                throw new Exception($"Variable {VariableName} can't find itself in variableValues."); // I don't think it's a best idea, but...
        }
        public override string ToString() => VariableName;
        public override AbstractExpr Differential(Variable differentialVariable)
        {
            if (differentialVariable.VariableName == VariableName)
                return new Constant(1);
            else
                return new Constant(0);
        }
    }
}
