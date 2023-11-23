using ПЗ_3_и_4.IExpr.MainStruct.Functions;

namespace ПЗ_3_и_4.IExpr.MainStruct.TrigFunctions
{
    public class Cot : TrigFunction
    {
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => 1.0 / Math.Tan(Expression.Compute(variableValues));
        public Cot(AbstractExpr expression) : base(expression) { }
        public override string ToString() => $"Cot({Expression})";
        public override AbstractExpr Differential(Variable differentialVariable)
        {
            if (Expression.Variables.Contains<string>(differentialVariable.ToString()))
                return (-Expression.Differential(differentialVariable))
                   / (new Sin(Expression) * new Sin(Expression));
            return 0;
        }
    }
}
