using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ПЗ_3_и_4.IExpr.MainStruct;
using ПЗ_3_и_4.IExpr.MainStruct.Functions;

namespace ПЗ_3_и_4_Test
{
    [TestClass]
    public class TrigFunctionTest
    {
        [TestMethod]
        public void CosTestPos()
        {
            var x = new Variable("x");
            var expr = new Cos(x);
            Assert.AreEqual(expr.Compute(new Dictionary<string, double>{["x"] = 1}),Math.Cos(1), 0.0001);
        }

        [TestMethod]
        public void CosTestNeg()
        {
            var x = new Variable("x");
            var expr = new Cos(x);
            Assert.AreEqual(expr.Compute(new Dictionary<string, double>{["x"]=-1}),Math.Cos(-1),0.0001 );
        }

        [TestMethod]
        public void CosVariable()
        {
            var a = new Variable("a");
            var expr = new Cos(a);
            Assert.AreEqual(expr.IsPolynom, false);
            Assert.AreEqual(expr.IsConstant, false);
            Assert.AreEqual(expr.ToString(), "Cos(a)");
        }

        [TestMethod]
        public void CosConstant()
        {
            var a = new Constant(7);
            var expr = new Cos(a);
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, true);
            Assert.AreEqual(expr.ToString(), "Cos(7)");
        }
   }
}
