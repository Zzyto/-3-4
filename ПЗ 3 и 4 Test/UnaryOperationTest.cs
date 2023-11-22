using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ПЗ_3_и_4.IExpr.MainStruct;

namespace ПЗ_3_и_4_Test
{
    [TestClass]
    public class UnaryOperationTest
    {
        [TestClass]
        public class UnaryMinusTest
        {
            [TestMethod]
            public void UnaryMinusPosTest()
            {
                var x = new Variable("x");
                var expr = -x;
                var y = expr.Compute(new Dictionary<string, double> { ["x"] = 1 });
                Assert.AreEqual(-1, y);
            }
        }
        [TestMethod]
        public void UnaryMinusVariableTest()
        {
            var x = new Variable("x");
            var expr = -x;
            Assert.AreEqual(true, expr.IsPolynom);
            Assert.AreEqual( "-x", expr.ToString());
        }

        [TestMethod]
        public void UnaryMinusConstantTest()
        {
            var x = new Constant(2);
            var expr = -x;
            Assert.AreEqual(true, expr.IsConstant);
            Assert.AreEqual(true, expr.IsPolynom);
            Assert.AreEqual( "-2", expr.ToString());
        }
        [TestMethod]
        public void UnaryMinusExprTest()
        {
            var x = 2;
            var a = new Variable("a");
            var expr = -(a+x);
            Assert.AreEqual(false, expr.IsConstant);
            Assert.AreEqual(true, expr.IsPolynom);
            Assert.AreEqual("-(a + 2)", expr.ToString());
        }
    }
}
