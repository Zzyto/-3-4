using ПЗ_3_и_4.IExpr.MainStruct;
using ПЗ_3_и_4.IExpr.MainStruct.Functions;
using ПЗ_3_и_4.IExpr.MainStruct.TrigFunctions;

namespace ПЗ_3_и_4.Test
{
    [TestClass]
    public class BinaryOperationTest
    {
        [TestClass]
        public class Sum
        {
            [TestMethod]
            public void Sum_5_7_returned_12()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a + b;
                var c = expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 7 });
                Assert.AreEqual(12, c);
            }
            [TestMethod]
            public void SumVariable_a_b()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a + b;
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual(false, expr.IsConstant);
                Assert.AreEqual("a + b", expr.ToString());
            }
            [TestMethod]
            public void SumConstant1()
            {
                var a = 2;
                var b = new Constant(5);
                var expr = a + b;
                Assert.AreEqual(true, expr.IsConstant);
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual("2 + 5", expr.ToString());
            }
            [TestMethod]
            public void SumConstant2()
            {
                var a = new Constant(2);
                var b = 5;
                var expr = a + b;
                Assert.AreEqual(true, expr.IsConstant);
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual("2 + 5", expr.ToString());
            }
            [TestMethod]
            public void SumConstant3()
            {
                var a = 2;
                var b = new Constant(5);
                var expr = a + b;
                Assert.AreEqual(true, expr.IsConstant);
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual("2 + 5", expr.ToString());
            }
            [TestMethod]
            public void SumConstantVariable()
            {
                var a = new Variable("a");
                var b = 5;
                var expr = a + b;
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual(false, expr.IsConstant);
                Assert.AreEqual("a + 5", expr.ToString());
            }

            [TestMethod]
            public void SumVariableFunction()
            {
                var a = new Variable("a");
                var b = new Sin(5);
                var expr = a + b;
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual(false, expr.IsConstant);
                Assert.AreEqual("a + (Sin(5))", expr.ToString());
            }

            [TestMethod]
            public void SumConstantFunction()
            {
                var a = 5;
                var b = new Variable("a");
                var c = new Cos(b);
                var expr = a + c;
                Assert.AreEqual( false, expr.IsPolynom);
                Assert.AreEqual(false, expr.IsConstant);
                Assert.AreEqual("5 + (Cos(a))", expr.ToString());
            }

            [TestMethod]
            public void SumFunctionFunction()
            {
                var a = new Variable("a");
                var b = new Cos(a);
                var c = new Sin(b);
                var expr = b + c;
                Assert.AreEqual(false, expr.IsConstant);
                Assert.AreEqual(false, expr.IsPolynom);
                Assert.AreEqual("(Cos(a)) + (Sin(Cos(a)))", expr.ToString());
            }
        }
        [TestClass]
        public class Subtraction
        {
            [TestMethod]
            public void Subtraction5_3_is2()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a - b;
                var c = expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 3 });
                Assert.AreEqual(2, c);
            }
            [TestMethod]
            public void SubtractionVariables()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a - b;
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual(false, expr.IsConstant);
                Assert.AreEqual("a - b", expr.ToString());
            }
            [TestMethod]
            public void SubtractionConstants1()
            {
                var a = 2;
                var b = new Constant(5);
                var expr = a - b;
                Assert.AreEqual(true, expr.IsConstant);
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual( "2 - 5", expr.ToString());
            }
            [TestMethod]
            public void SubtractionConstants2()
            {
                var a = 2;
                var b = new Constant(5);
                var expr = a - b;
                Assert.AreEqual(true, expr.IsConstant);
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual("2 - 5", expr.ToString());
            }
            [TestMethod]
            public void SubtractionConstants3()
            {
                var a = new Constant(2);
                var b = 5;
                var expr = a - b;
                Assert.AreEqual(true, expr.IsConstant);
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual("2 - 5", expr.ToString());
            }
            [TestMethod]
            public void SubtractionConstantAndVariable()
            {
                var a = new Variable("a");
                var b = 5;
                var expr = a - b;
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual(false, expr.IsConstant);
                Assert.AreEqual("a - 5", expr.ToString());
            }
            [TestMethod]
            public void SubtractionVariableAndFunction()
            {
                var a = new Variable("a");
                var b = new Tan(5);
                var expr = a - b;
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual(false, expr.IsConstant);
                Assert.AreEqual("a - (Tan(5))", expr.ToString());
            }
            [TestMethod]
            public void SubtractionConstantAndFunction()
            {
                var a = 5;
                var b = new Sin(a);
                var expr = a - b;
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual(true, expr.IsConstant);
                Assert.AreEqual("5 - (Sin(5))", expr.ToString());
            }

            [TestMethod]
            public void SubtractionFunctionAndFunction()
            {
                var a = new Sin(new Constant(5));
                var b = new Cos(a);
                var expr = a - b;
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual(true, expr.IsConstant);
                Assert.AreEqual( "(Sin(5)) - (Cos(Sin(5)))", expr.ToString());
            }
        }
        [TestClass]
        public class Multiplication
        {

            [TestMethod]
            public void Multiplication_5_3is15()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a * b;
                var c = expr.Compute(new Dictionary<string, double> { ["a"] = -5, ["b"] = 3 });
                Assert.AreEqual(-15, c);
            }

            [TestMethod]
            public void MultiplicationVariable()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a * b;
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual(false, expr.IsConstant);
                Assert.AreEqual("a * b", expr.ToString());
            }
            [TestMethod]
            public void MultiplicationConstant1()
            {
                var a = 2;
                var b = new Constant(5);
                var expr = a * b;
                Assert.AreEqual(true, expr.IsConstant);
                Assert.AreEqual( true, expr.IsPolynom);
                Assert.AreEqual("2 * 5", expr.ToString());
            }
            [TestMethod]
            public void MultiplicationConstant2()
            {
                var a = 2;
                var b = new Constant(5);
                var expr = a * b;
                Assert.AreEqual(true, expr.IsConstant);
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual("2 * 5", expr.ToString());
            }
            [TestMethod]
            public void MultiplicationConstant3()
            {
                var a = new Constant(2);
                var b = 5;
                var expr = a * b;
                Assert.AreEqual(true, expr.IsConstant);
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual("2 * 5", expr.ToString());
            }
            [TestMethod]
            public void MultiplicationConstantVariable()
            {
                var a = new Variable("a");
                var b = 5;
                var expr = a * b;
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual(false, expr.IsConstant);
                Assert.AreEqual( "a * 5", expr.ToString());
            }
            [TestMethod]
            public void MultiplicationVariableFunction()
            {
                var a = new Variable("a");
                var b = new Cot(new Variable("a"));
                var expr = a * b;
                Assert.AreEqual(false, expr.IsPolynom);
                Assert.AreEqual(false, expr.IsConstant);
                Assert.AreEqual("a * (Cot(a))", expr.ToString());
            }
            [TestMethod]
            public void MultiplicationConstantAndFunction()
            {
                var a = 5;
                var b = new Sin(new Variable("a"));
                var expr = a * b;
                Assert.AreEqual(false, expr.IsPolynom);
                Assert.AreEqual(false, expr.IsConstant);
                Assert.AreEqual("5 * (Sin(a))", expr.ToString());
            }
        }

        [TestClass]
        public class Division
        {
            [TestMethod]
            public void DivisionPosPos()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a / b;
                var c = expr.Compute(new Dictionary<string, double> { ["a"] = 6, ["b"] = 3 });
                Assert.AreEqual(2, c);
            }

            [TestMethod]
            public void DivisionNegZero() //
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a / b;
                var c = expr.Compute(new Dictionary<string, double> { ["a"] = -5, ["b"] = 0 });
                Assert.IsTrue(double.IsInfinity(c));
            }

            [TestMethod]
            public void DivisionVariable()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a / b;
                Assert.AreEqual(false, expr.IsPolynom);
                Assert.AreEqual(false, expr.IsConstant);
                Assert.AreEqual("a / b", expr.ToString());
            }
            [TestMethod]
            public void DivisionConstant1()
            {
                var a = 2;
                var b = new Constant(5);
                var expr = a / b;
                Assert.AreEqual(true, expr.IsConstant);
                Assert.AreEqual(true, expr.IsPolynom);
            }
            [TestMethod]
            public void DivisionConstant2()
            {
                var a = 2;
                var b = new Constant(5);
                var expr = a / b;
                Assert.AreEqual(true, expr.IsConstant);
                Assert.AreEqual(true, expr.IsPolynom);
            }
            [TestMethod]
            public void DivisionConstant3()
            {
                var a = new Constant(2);
                var b = 5;
                var expr = a / b;
                Assert.AreEqual(true, expr.IsConstant);
                Assert.AreEqual(true, expr.IsPolynom);
            }
            [TestMethod]
            public void DivisionVariableConstant()
            {
                var a = new Variable("a");
                var b = 5;
                var expr = a / b;
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual(false, expr.IsConstant);
                Assert.AreEqual("a / 5", expr.ToString());
            }
            [TestMethod]
            public void DivisionConstantVariable()
            {
                var a = new Variable("a");
                var b = 5;
                var expr = b / a;
                Assert.AreEqual(false, expr.IsPolynom);
                Assert.AreEqual(false, expr.IsConstant);
                Assert.AreEqual("5 / a", expr.ToString());
            }
            [TestMethod]
            public void DivisionVariables()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = b / a;
                Assert.AreEqual(false, expr.IsPolynom);
                Assert.AreEqual(false, expr.IsConstant);
                Assert.AreEqual("b / a", expr.ToString());
            }

            [TestMethod]
            public void DivisionVariableFunction()
            {
                var a = new Variable("a");
                var b = new Sin(5);
                var expr = a / b;
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual(false, expr.IsConstant);
                Assert.AreEqual("a / (Sin(5))", expr.ToString());
            }

            [TestMethod]
            public void DivisionFunctionVariable()
            {
                var a = new Variable("a");
                var b = new Cos(5);
                var expr = b / a;
                Assert.AreEqual(false, expr.IsPolynom);
                Assert.AreEqual(false, expr.IsConstant);
                Assert.AreEqual("(Cos(5)) / a", expr.ToString());
            }

            [TestMethod]
            public void DivisionConstantAndFunction()
            {
                var a = 5;
                var b = new Cot(a);
                var expr = a / b;
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual(true, expr.IsConstant);
                Assert.AreEqual("5 / (Cot(5))", expr.ToString());
            }

            [TestMethod]
            public void DivisionFunctionAndConstant()
            {
                var a = 5;
                var b = new Tan(a);
                var expr = b / a;
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual(true, expr.IsConstant);
                Assert.AreEqual("(Tan(5)) / 5", expr.ToString());
            }

            [TestMethod]
            public void DivisionFunctionAndFunction()
            {
                var a = new Sin(5);
                var b = new Cos(a);
                var expr = a / b;
                Assert.AreEqual(true, expr.IsPolynom);
                Assert.AreEqual(true, expr.IsConstant);
                Assert.AreEqual("(Sin(5)) / (Cos(Sin(5)))", expr.ToString());
            }
            [TestMethod]
            public void DivisionFunctionAndFunction2()
            {
                var a = new Sin(new Variable("a"));
                var b = new Cos(a);
                var expr = a / b;
                Assert.AreEqual(false, expr.IsPolynom);
                Assert.AreEqual(false, expr.IsConstant);
                Assert.AreEqual("(Sin(a)) / (Cos(Sin(a)))", expr.ToString());
            }
        }
    }
}