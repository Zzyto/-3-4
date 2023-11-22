using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ПЗ_3_и_4.IExpr;
using ПЗ_3_и_4.IExpr.MainStruct;
using ПЗ_3_и_4.IExpr.MainStruct.Functions;
using ПЗ_3_и_4.IExpr.MainStruct.TrigFunctions;

namespace ПЗ_3_и_4_Test
{
    [TestClass]
    public class DifferentialTest
    {
        [TestClass]
        public class UnaryTest
        {
            [TestMethod]
            public void MinusTest() 
            {
                var a = new Variable("a");
                var expr = -a;
                Assert.AreEqual("-1", expr.Differential(a).ToString());
            }
        }
        [TestClass]
        public class BinaryTest
        {
            [TestMethod]
            public void SumConstant()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a + b;
                Assert.AreEqual("1 + 0", expr.Differential(a).ToString());
                Assert.AreEqual("0 + 1", expr.Differential(b).ToString());
            }
            [TestMethod]
            public void SubConstant()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a - b;
                Assert.AreEqual("1 - 0", expr.Differential(a).ToString());
                Assert.AreEqual("0 - 1", expr.Differential(b).ToString());
            }
            [TestMethod]
            public void MultConstant()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a * b;
                Assert.AreEqual("(1 * b) + (a * 0)", expr.Differential(a).ToString());
                Assert.AreEqual("(0 * b) + (a * 1)", expr.Differential(b).ToString());
            }
            [TestMethod]
            public void DevideConstant()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a / b;
                Assert.AreEqual("((1 * b) - (a * 0)) / (b * b)", expr.Differential(a).ToString());
                Assert.AreEqual("((0 * b) - (a * 1)) / (b * b)", expr.Differential(b).ToString());
            }
            [TestMethod]
            public void ConstantTest()
            {
                AbstractExpr a = 2;
                Assert.AreEqual("0", a.Differential(new Variable("x")).ToString());
            }
        }
        [TestClass]
        public class FunClass
        {
            [TestMethod]
            public void SinTestVar()
            {
                var x = new Variable("x");
                var expr = new Sin(x);
                Assert.AreEqual( "(Cos(x)) * 1", expr.Differential(x).ToString());
            }
            [TestMethod]
            public void SinTestConst() 
            {
                var x = new Variable("x");
                var a = 23;
                var expr = new Sin(a);
                Assert.AreEqual( "0", expr.Differential(x).ToString());
            }
            [TestMethod]
            public void CosTestVar()
            {
                var x = new Variable("x");
                var expr = new Cos(x);
                Assert.AreEqual("-((Sin(x)) * 1)", expr.Differential(x).ToString());
            }
            [TestMethod]
            public void CosTestConst()
            {
                var x = new Variable("x");
                var a = 23;
                var expr = new Cos(a);
                Assert.AreEqual("0", expr.Differential(x).ToString());
            }
            [TestMethod]
            public void TanTestVar()
            {
                var x = new Variable("x");
                var expr = new Tan(x);
                Assert.AreEqual( "1 / ((Cos(x)) * (Cos(x)))", expr.Differential(x).ToString());
            }
            [TestMethod]
            public void TanTestConst()
            {
                var x = new Variable("x");
                var a = 23;
                var expr = new Tan(a);
                Assert.AreEqual("0", expr.Differential(x).ToString());
            }
            [TestMethod]
            public void CotTest()
            {
                var x = new Variable("x");
                var expr = new Cot(x);
                Assert.AreEqual("(-1) / ((Sin(x)) * (Sin(x)))", expr.Differential(x).ToString());
            }
            [TestMethod]
            public void CotTestConst()
            {
                var x = new Variable("x");
                var a = 23;
                var expr = new Cot(a);
                Assert.AreEqual("0", expr.Differential(x).ToString());
            }
        }
    }
}
