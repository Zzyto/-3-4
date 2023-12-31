﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_3_и_4.IExpr.MainStruct.BinaryOperations
{
    public class Sum : BinaryOperation
    {
        public Sum(AbstractExpr firstExpression, AbstractExpr secondExpression) : base(firstExpression, secondExpression, "+") { }

        public override double Compute(IReadOnlyDictionary<string, double> variableValues) =>
            FirstExpression.Compute(variableValues) + SecondExpression.Compute(variableValues);
        public override AbstractExpr Differential(Variable differentialVariable) =>
           FirstExpression.Differential(differentialVariable) + SecondExpression.Differential(differentialVariable);
    }
}
