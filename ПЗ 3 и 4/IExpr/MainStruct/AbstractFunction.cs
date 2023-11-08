using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_3_и_4.IExpr.MainStruct
{
    public abstract class Function : AbstractExpr
    {
        protected List<AbstractExpr> Expressions { get; init; }
        public override IEnumerable<string> Variables
        {
            get
            {
                var variables = new List<string>();
                foreach (var elem in Expressions)
                    variables.AddRange(elem.Variables);

                return variables;
            }
        }

        public Function()
        {
            Expressions = new List<AbstractExpr>();
        }

        public override bool IsConstant { get => !Variables.GetEnumerator().MoveNext(); }
        public override bool IsPolynom
        {
            get
            {
                foreach (var item in Expressions)
                    if (item.IsPolynom == true) return true;
                return false;
            }
        }

        //override abstract public double Compute(IReadOnlyDictionary<string, double> variableValues);

        abstract public override string ToString();
    }
}
