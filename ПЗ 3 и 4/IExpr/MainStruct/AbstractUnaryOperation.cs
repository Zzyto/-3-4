using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_3_и_4.IExpr.MainStruct
{
    abstract public class UnaryOperation : AbstractExpr
    {
        protected AbstractExpr Expression { get; init; }
        protected string Operation { get; init; }

        public override IEnumerable<string> Variables { get => Expression.Variables; }

        public override bool IsConstant { get => !Variables.Any(); }
        public override bool IsPolynom { get => Expression.IsPolynom; }

        public UnaryOperation(AbstractExpr expression, string operation)
        {
            Expression = expression;
            Operation = operation;
        }

        public override string ToString()
        {
            if (Expression is not Constant and not Variable)
                return $"{Operation}({Expression})";
            return $"{Operation}{Expression}";
        }

    }
}
