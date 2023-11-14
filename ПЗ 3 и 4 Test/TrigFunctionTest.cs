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
        [TestMethod]
        public void SinTestPos()
        {
            var x = new Variable("x");
            var expr = new Sin(x);
            Assert.AreEqual(expr.Compute(new Dictionary<string, double>{["x"] = 1}),Math.Sin(1), 0.0001);
        }

        [TestMethod]
        public void SinTestNeg()
        {
            var x = new Variable("x");
            var expr = new Sin(x);
            Assert.AreEqual(expr.Compute(new Dictionary<string, double>{["x"]=-1}),Math.Sin(-1),0.0001 );
        }

        [TestMethod]
        public void SinVariable()
        {
            var a = new Variable("a");
            var expr = new Sin(a);
            Assert.AreEqual(expr.IsPolynom, false);
            Assert.AreEqual(expr.IsConstant, false);
            Assert.AreEqual(expr.ToString(), "Sin(a)");
        }
        
        [TestMethod]
        public void SinConstant()
        {
            var a = new Constant(7);
            var expr = new Sin(a);
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, true);
            Assert.AreEqual(expr.ToString(), "Sin(7)");
        } 
        
        [TestMethod]
        public void CotTestPos()
        {
            var x = new Variable("x");
            var expr = new Cot(x);
            Assert.AreEqual(expr.Compute(new Dictionary<string, double>{["x"] = 1}),1/Math.Tan(1), 0.0001);
        }

        [TestMethod]
        public void CotTestNeg()
        {
            var x = new Variable("x");
            var expr = new Cot(x);
            Assert.AreEqual(expr.Compute(new Dictionary<string, double>{["x"]=-1}),1/Math.Tan(-1),0.0001 );
        }

        [TestMethod]
        public void CotVariable()
        {
            var a = new Variable("a");
            var expr = new Cot(a);
            Assert.AreEqual(expr.IsPolynom, false);
            Assert.AreEqual(expr.IsConstant, false);
            Assert.AreEqual(expr.ToString(), "Cot(a)");
        }
        
        [TestMethod]
        public void CotConstant()
        {
            var a = new Constant(7);
            var expr = new Cot(a);
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, true);
            Assert.AreEqual(expr.ToString(), "Cot(7)");
        } 
        
        //тангенс
        [TestMethod]
        public void TanTestPos()
        {
            var x = new Variable("x");
            var expr = new Tan(x);
            Assert.AreEqual(expr.Compute(new Dictionary<string, double>{["x"] = 1}),Math.Tan(1), 0.0001);
        }

        [TestMethod]
        public void TanTestNeg()
        {
            var x = new Variable("x");
            var expr = new Tan(x);
            Assert.AreEqual(expr.Compute(new Dictionary<string, double>{["x"]=-1}),Math.Tan(-1),0.0001 );
        }

        [TestMethod]
        public void TanVariable()
        {
            var a = new Variable("a");
            var expr = new Tan(a);
            Assert.AreEqual(expr.IsPolynom, false);
            Assert.AreEqual(expr.IsConstant, false);
            Assert.AreEqual(expr.ToString(), "Tan(a)");
        }
        
        [TestMethod]
        public void TanConstant()
        {
            var a = new Constant(7);
            var expr = new Tan(a);
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, true);
            Assert.AreEqual(expr.ToString(), "Tan(7)");
        } 
   }
}
