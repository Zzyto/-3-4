using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_3_и_4.IExpr.MainStruct
{
    abstract public class BinaryOperation : AbstractExpr
    {
        protected AbstractExpr FirstExpression { get; init; }
        protected AbstractExpr SecondExpression { get; init; }
        protected string Operation { get; init; }

        public override IEnumerable<string> Variables
        {
            get
            {
                var allVars = new List<string>();
                allVars.AddRange(FirstExpression.Variables);
                allVars.AddRange(SecondExpression.Variables);

                return allVars;
            }
        }

        public override bool IsConstant { get => !Variables.GetEnumerator().MoveNext(); }
        public override bool IsPolynom { get => FirstExpression.IsPolynom && SecondExpression.IsPolynom; }

        public BinaryOperation(AbstractExpr firstExpression, AbstractExpr secondExpression, string operation = "")
        {
            FirstExpression = firstExpression;
            SecondExpression = secondExpression;
            Operation = operation;
        }

        override abstract public double Compute(IReadOnlyDictionary<string, double> variableValues);

        public override string ToString()
        {
            string outString;
            if (FirstExpression is not Constant && FirstExpression is not Variable)
                outString = $"({FirstExpression})";
            else
                outString = $"{FirstExpression}";
            outString += $" {Operation} ";

            if (SecondExpression is not Constant && SecondExpression is not Variable)
                outString += $"({SecondExpression})";
            else
                outString += $"{SecondExpression}";

            return outString;
        }
    }
}
