using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ПЗ_3_и_4.IExpr;
using ПЗ_3_и_4.IExpr.MainStruct;

namespace ПЗ_3_и_4_Test
{
    [TestClass]
    public class VariableTest
    {
        [TestMethod]
        public void VariableX()
        {
            var x = new Variable("x");
            var expr = x;
            Assert.AreEqual(expr.IsConstant, false);
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.ToString(), "x");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Variable b can't find itself in variableValues.")]
        public void CantFindVariable()
        {
            var a = new Variable("a");
            var b = new Variable("b");
            var expr = a - b;
            expr.Compute(new Dictionary<string, double> { ["a"] = 5});
        }
    }
}
