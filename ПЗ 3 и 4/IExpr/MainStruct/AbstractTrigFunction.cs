using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_3_и_4.IExpr.MainStruct
{
    public abstract class TrigFunction : Function
    {
        protected AbstractExpr Expression { get; init; }
        protected string Operation { get; init; }

        public override IEnumerable<string> Variables { get => Expression.Variables; }
        public TrigFunction(AbstractExpr expression) => Expression = expression;

        public override bool IsConstant { get => !Variables.Any(); }
        public override bool IsPolynom { get => IsConstant; }

        override abstract public double Compute(IReadOnlyDictionary<string, double> variableValues);

        override abstract public string ToString();
    }
}
