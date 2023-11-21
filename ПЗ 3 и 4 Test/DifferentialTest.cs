using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ПЗ_3_и_4.IExpr.MainStruct;
using ПЗ_3_и_4.IExpr.MainStruct.Functions;
using ПЗ_3_и_4.IExpr.MainStruct.TrigFunctions;

namespace ПЗ_3_и_4_Test
{
    [TestClass]
    public class DifferentialTest
    {
        [TestClass]
        public class BinaryTest
        {
            [TestMethod]
            public void SumConstant()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a + b;
                Assert.AreEqual(expr.Differential(a).ToString(), "1 + 0");
                Assert.AreEqual(expr.Differential(b).ToString(), "0 + 1");
            }
            [TestMethod]
            public void SubConstant()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a - b;
                Assert.AreEqual(expr.Differential(a).ToString(), "1 - 0");
                Assert.AreEqual(expr.Differential(b).ToString(), "0 - 1");
            }
            [TestMethod]
            public void MultConstant()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a * b;
                Assert.AreEqual(expr.Differential(a).ToString(), "(1 * b) + (a * 0)");
                Assert.AreEqual(expr.Differential(b).ToString(), "(0 * b) + (a * 1)");
            }
            [TestMethod]
            public void DevideConstant()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a / b;
                Assert.AreEqual(expr.Differential(a).ToString(), "((1 * b) - (a * 0)) / (b * b)");
                Assert.AreEqual(expr.Differential(b).ToString(), "((0 * b) - (a * 1)) / (b * b)");
            }
        }
        [TestClass]
        public class FunClass
        {
            [TestMethod]
            public void SinTest()
            {
                var x = new Variable("x");
                var expr = new Sin(x);
                Assert.AreEqual(expr.Differential(x).ToString(), "(Cos(x)) * 1");
            }
            [TestMethod]
            public void CosTest()
            {
                var x = new Variable("x");
                var expr = new Cos(x);
                Assert.AreEqual(expr.Differential(x).ToString(), "-((Sin(x)) * 1)");
            }
            [TestMethod]
            public void TanTest()
            {
                var x = new Variable("x");
                var expr = new Tan(x);
                Assert.AreEqual(expr.Differential(x).ToString(), "1 / ((Cos(x)) * (Cos(x)))");
            }
            [TestMethod]
            public void CotTest()
            {
                var x = new Variable("x");
                var expr = new Cot(x);
                Assert.AreEqual(expr.Differential(x).ToString(), "(-1) / ((Sin(x)) * (Sin(x)))");
            }
        }
    }
}
