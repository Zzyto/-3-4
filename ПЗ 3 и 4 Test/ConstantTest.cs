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
            Assert.AreEqual(true, expr.IsConstant);
            Assert.AreEqual(true, expr.IsPolynom);
            Assert.AreEqual("1", expr.ToString());
        }
    }
}
