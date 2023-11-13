using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ПЗ_3_и_4.IExpr.MainStruct;
using ПЗ_3_и_4.IExpr.MainStruct.Functions;

namespace ПЗ_3_и_4_Test
{
    [TestClass]
    public class Combined
    {
        [TestClass]
        public class CombinedTests
        {
            [TestMethod]
            public void AdditionWithMultiplication()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a + a * b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 3 }), 20);
                Assert.AreEqual(expr.ToString(), "a + (a * b)");
            }

            [TestMethod]
            public void AdditionWithMultiplicationAndFunction()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a * b + new Sin(a);
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 1, ["b"] = 0 }), 0.841, 0.001);
                Assert.AreEqual(expr.ToString(), "(a * b) + (Sin(a))");
            }

            [TestMethod]
            public void DivisionWithSubtraction()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a / (b + 3);
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 4, ["b"] = 1 }), 1);
                Assert.AreEqual(expr.ToString(), "a / (b + 3)");
            }

            [TestMethod]
            public void SubtractionWithMultiplication()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a * b - 10;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 1, ["b"] = 0 }), -10);
                Assert.AreEqual(expr.ToString(), "(a * b) - 10");
            }
        }
    }
}
