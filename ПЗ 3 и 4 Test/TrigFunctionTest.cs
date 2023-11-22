using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ПЗ_3_и_4.IExpr.MainStruct;
using ПЗ_3_и_4.IExpr.MainStruct.Functions;
using ПЗ_3_и_4.IExpr.MainStruct.TrigFunctions;

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
            var y = expr.Compute(new Dictionary<string, double> { ["x"] = 1 });
            Assert.AreEqual(Math.Cos(1),y, 0.0001);
        }

        [TestMethod]
        public void CosTestNeg()
        {
            var x = new Variable("x");
            var expr = new Cos(x);
            var y = expr.Compute(new Dictionary<string, double> { ["x"] = -1 });
            Assert.AreEqual(Math.Cos(-1), y, 0.0001);
        }

        [TestMethod]
        public void CosVariable()
        {
            var a = new Variable("a");
            var expr = new Cos(a);
            Assert.AreEqual(false, expr.IsPolynom);
            Assert.AreEqual(false, expr.IsConstant);
            Assert.AreEqual("Cos(a)", expr.ToString());
        }

        [TestMethod]
        public void CosConstant()
        {
            var a = 7;
            var expr = new Cos(a);
            Assert.AreEqual(true, expr.IsPolynom);
            Assert.AreEqual(true, expr.IsConstant);
            Assert.AreEqual("Cos(7)", expr.ToString());
        }

        [TestMethod]
        public void SinTestPos()
        {
            var x = new Variable("x");
            var expr = new Sin(x);
            var y = expr.Compute(new Dictionary<string, double> { ["x"] = 1 });
            Assert.AreEqual( Math.Sin(1),y, 0.0001);
        }

        [TestMethod]
        public void SinTestNeg()
        {
            var x = new Variable("x");
            var expr = new Sin(x);
            var y = expr.Compute(new Dictionary<string, double> { ["x"] = -1 });
            Assert.AreEqual(Math.Sin(-1), y, 0.0001);
        }

        [TestMethod]
        public void SinVariable()
        {
            var a = new Variable("a");
            var expr = new Sin(a);
            Assert.AreEqual(false, expr.IsPolynom);
            Assert.AreEqual(false, expr.IsConstant);
            Assert.AreEqual("Sin(a)", expr.ToString());
        }

        [TestMethod]
        public void SinConstant()
        {
            var a = 7;
            var expr = new Sin(a);
            Assert.AreEqual(true, expr.IsPolynom);
            Assert.AreEqual(true, expr.IsConstant);
            Assert.AreEqual("Sin(7)", expr.ToString());
        }

        [TestMethod]
        public void CotTestPos()
        {
            var x = new Variable("x");
            var expr = new Cot(x);
            var y = expr.Compute(new Dictionary<string, double> { ["x"] = 1 });
            Assert.AreEqual(1 / Math.Tan(1), y, 0.0001);
        }

        [TestMethod]
        public void CotTestNeg()
        {
            var x = new Variable("x");
            var expr = new Cot(x);
            var y = expr.Compute(new Dictionary<string, double> { ["x"] = -1 });
            Assert.AreEqual(1 / Math.Tan(-1), y, 0.0001);
        }

        [TestMethod]
        public void CotVariable()
        {
            var a = new Variable("a");
            var expr = new Cot(a);
            Assert.AreEqual(false, expr.IsPolynom);
            Assert.AreEqual(false, expr.IsConstant);
            Assert.AreEqual("Cot(a)", expr.ToString());
        }

        [TestMethod]
        public void CotConstant()
        {
            var a = 7;
            var expr = new Cot(a);
            Assert.AreEqual(true, expr.IsPolynom);
            Assert.AreEqual(true, expr.IsConstant);
            Assert.AreEqual("Cot(7)", expr.ToString());
        }
        
        [TestMethod]
        public void TanTestPos()
        {
            var x = new Variable("x");
            var expr = new Tan(x);
            var y = expr.Compute(new Dictionary<string, double> { ["x"] = 1 });
            Assert.AreEqual(Math.Tan(1), y, 0.0001);
        }

        [TestMethod]
        public void TanTestNeg()
        {
            var x = new Variable("x");
            var expr = new Tan(x);
            var y = expr.Compute(new Dictionary<string, double> { ["x"] = -1 });
            Assert.AreEqual(Math.Tan(-1), y, 0.0001);
        }

        [TestMethod]
        public void TanVariable()
        {
            var a = new Variable("a");
            var expr = new Tan(a);
            Assert.AreEqual(false, expr.IsPolynom);
            Assert.AreEqual(false, expr.IsConstant);
            Assert.AreEqual("Tan(a)", expr.ToString());
        }

        [TestMethod]
        public void TanConstant()
        {
            var a = 7;
            var expr = new Tan(a);
            Assert.AreEqual(true, expr.IsPolynom);
            Assert.AreEqual(true, expr.IsConstant);
            Assert.AreEqual("Tan(7)", expr.ToString());
        }
        
    }
}
 