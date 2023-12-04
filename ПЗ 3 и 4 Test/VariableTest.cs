using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ПЗ_3_и_4.IExpr;
using ПЗ_3_и_4.IExpr.MainStruct;
using ПЗ_3_и_4.IExpr.MainStruct.Functions;

namespace ПЗ_3_и_4_Test
{
    [TestClass]
    public class VariableTest
    {
        [TestMethod]
        public void VariableExist()
        {
            var a = new Variable("a");
            var x = new Sin(a);
            var expr = a + x;
            ICollection<string> expected = ["a"];
            CollectionAssert.Equals(expected, expr.Variables);
        }
        [TestMethod]
        public void VariableNotExist()
        {
            var a = 2;
            var x = new Sin(1);
            var expr = a + x;
            ICollection<string> expected = [];
            CollectionAssert.Equals(expected, expr.Variables);  
        }
        [TestMethod] public void VariableExist2()
        {
            var a = new Variable("a");
            var b = new Variable("b");
            var x = new Sin(b);
            var expr = a + x;
            ICollection<string> expected = ["a", "b"];
            CollectionAssert.Equals(expected, expr.Variables);
        }
        [TestMethod]
        public void VariableX()
        {
            var x = new Variable("x");
            var expr = x;
            Assert.AreEqual(false, expr.IsConstant);
            Assert.AreEqual(true, expr.IsPolynom);
            Assert.AreEqual("x", expr.ToString());
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
