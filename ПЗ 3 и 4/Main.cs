using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ПЗ_3_и_4.IExpr.MainStruct;
using ПЗ_3_и_4.IExpr.MainStruct.BinaryOperations;
using ПЗ_3_и_4.IExpr.MainStruct.UnaryOperations;
using ПЗ_3_и_4.IExpr.MainStruct.Functions;
using ПЗ_3_и_4;

namespace PZ_3_4
{
    class PZ_3_4
    {
        static void Main(string[] args)
        {
            var a = new Variable("a");
            var b = new Variable("b");
            var expr0 = new Mult(new Sum(a, b), new Minus(new Divide(a, new Constant(2))));
            var expr = (a + b) * -a / 2;

            Console.WriteLine($"введённое выражение: {expr}");
            var values = new Dictionary<string, double> { ["a"] = 7, ["b"] = 4 };
            Console.WriteLine($"значения переменных: {values.ToLineString()}");
            var result = expr.Compute(values);
            Console.WriteLine($"результат вычислений: {expr.Compute(values)}");

            Console.WriteLine(expr);

        }
    }
}