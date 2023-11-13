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
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["x"] = 1 }), -1);
            }
        }
        [TestMethod]
        public void UnaryMinusVariableTest()
        {
            var x = new Variable("x");
            var expr = -x;
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.ToString(), "-x");
        }

        [TestMethod]
        public void UnaryMinusConstantTest()
        {
            var x = new Constant(2);
            var expr = -x;
            Assert.AreEqual(expr.IsConstant, true);
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.ToString(), "-2");
        }
    }
}
