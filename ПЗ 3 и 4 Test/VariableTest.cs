using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
