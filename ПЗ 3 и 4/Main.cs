using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ПЗ_3_и_4.IExpr.MainStruct;
using ПЗ_3_и_4.IExpr.MainStruct.BinaryOperations;
using ПЗ_3_и_4.IExpr.MainStruct.UnaryOperations;
using ПЗ_3_и_4.IExpr.MainStruct.Functions;
using System.Diagnostics.CodeAnalysis;

namespace PZ_3_4
{
    class PZ_3_4
    {
        [ExcludeFromCodeCoverage]
        static void Main() 
        {
            var a = new Variable("a");
            var b = new Variable("b");
            var expr = a + b;
            Console.WriteLine($"производная выражения по a: {expr.Differential(new Variable("a"))}");
            Console.WriteLine($"производная выражения по b: {expr.Differential(new Variable("b"))}");
        }
    }
}