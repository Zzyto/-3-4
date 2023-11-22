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
                var c = expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 3 });
                Assert.AreEqual(20, c);
                Assert.AreEqual("a + (a * b)", expr.ToString());
            }

            [TestMethod]
            public void AdditionWithMultiplicationAndFunction()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a * b + new Sin(a);
                var c = expr.Compute(new Dictionary<string, double> { ["a"] = 1, ["b"] = 0 });
                Assert.AreEqual( 0.841, c, 0.001);
                Assert.AreEqual("(a * b) + (Sin(a))", expr.ToString());
            }

            [TestMethod]
            public void DivisionWithSubtraction()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a / (b + 3);
                var c = expr.Compute(new Dictionary<string, double> { ["a"] = 4, ["b"] = 1 });
                Assert.AreEqual(1, c);
                Assert.AreEqual("a / (b + 3)", expr.ToString());
            }

            [TestMethod]
            public void SubtractionWithMultiplication()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a * b - 10;
                var c = expr.Compute(new Dictionary<string, double> { ["a"] = 1, ["b"] = 0 });
                Assert.AreEqual(-10, c);
                Assert.AreEqual("(a * b) - 10", expr.ToString());
            }
        }
    }
}
