using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ПЗ_3_и_4.IExpr.MainStruct;

namespace ПЗ_3_и_4_Test
{
    [TestClass]
    public class ConstantTest
    {
        [TestMethod]
        public void Constant1()
        {
            var x = new Constant(1);
            var expr = x;
            Assert.AreEqual(expr.IsConstant, true);
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.ToString(), "1");
        }
    }
}
