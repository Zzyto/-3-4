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
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 7 }), 12);
            }
            [TestMethod]
            public void SumVariable_a_b()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a + b;
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.IsConstant, false);
                Assert.AreEqual(expr.ToString(), "a + b");
            }
            [TestMethod]
            public void SumConstant1()
            {
                var a = new Constant(2);
                var b = new Constant(5);
                var expr = a + b;
                Assert.AreEqual(expr.IsConstant, true);
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.ToString(), "2 + 5");
            }
            [TestMethod]
            public void SumConstant2()
            {
                var a = new Constant(2);
                var b = 5;
                var expr = a + b;
                Assert.AreEqual(expr.IsConstant, true);
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.ToString(), "2 + 5");
            }
            [TestMethod]
            public void SumConstant3()
            {
                var a = 2;
                var b = new Constant(5);
                var expr = a + b;
                Assert.AreEqual(expr.IsConstant, true);
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.ToString(), "2 + 5");
            }
            [TestMethod]
            public void SumConstantVariable()
            {
                var a = new Variable("a");
                var b = new Constant(5);
                var expr = a + b;
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.IsConstant, false);
                Assert.AreEqual(expr.ToString(), "a + 5");
            }

            [TestMethod]
            public void SumVariableFunction()
            {
                var a = new Variable("a");
                var b = new Sin(new Constant(5));
                var expr = a + b;
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.IsConstant, false);
                Assert.AreEqual(expr.ToString(), "a + (Sin(5))");
            }

            [TestMethod]
            public void SumConstantFunction()
            {
                var a = new Constant(5);
                var b = new Variable("a");
                var c = new Cos(b);
                var expr = a + c;
                Assert.AreEqual(expr.IsPolynom, false);
                Assert.AreEqual(expr.IsConstant, false);
                Assert.AreEqual(expr.ToString(), "5 + (Cos(a))");
            }

            [TestMethod]
            public void SumFunctionFunction()
            {
                var a = new Variable("a");
                var b = new Cos(a);
                var c = new Sin(b);
                var expr = b + c;
                Assert.AreEqual(expr.IsConstant, false);
                Assert.AreEqual(expr.IsPolynom, false);
                Assert.AreEqual(expr.ToString(), "(Cos(a)) + (Sin(Cos(a)))");
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
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 3 }), 2);
            }
            [TestMethod]
            public void SubtractionVariables()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a - b;
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.IsConstant, false);
                Assert.AreEqual(expr.ToString(), "a - b");
            }
            [TestMethod]
            public void SubtractionConstants1()
            {
                var a = new Constant(2);
                var b = new Constant(5);
                var expr = a - b;
                Assert.AreEqual(expr.IsConstant, true);
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.ToString(), "2 - 5");
            }
            [TestMethod]
            public void SubtractionConstants2()
            {
                var a = 2;
                var b = new Constant(5);
                var expr = a - b;
                Assert.AreEqual(expr.IsConstant, true);
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.ToString(), "2 - 5");
            }
            [TestMethod]
            public void SubtractionConstants3()
            {
                var a = new Constant(2);
                var b = 5;
                var expr = a - b;
                Assert.AreEqual(expr.IsConstant, true);
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.ToString(), "2 - 5");
            }
            [TestMethod]
            public void SubtractionConstantAndVariable()
            {
                var a = new Variable("a");
                var b = new Constant(5);
                var expr = a - b;
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.IsConstant, false);
                Assert.AreEqual(expr.ToString(), "a - 5");
            }
            [TestMethod]
            public void SubtractionVariableAndFunction()
            {
                var a = new Variable("a");
                var b = new Tan(new Constant(5));
                var expr = a - b;
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.IsConstant, false);
                Assert.AreEqual(expr.ToString(), "a - (Tan(5))");
            }
            [TestMethod]
            public void SubtractionConstantAndFunction()
            {
                var a = new Constant(5);
                var b = new Sin(a);
                var expr = a - b;
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.IsConstant, true);
                Assert.AreEqual(expr.ToString(), "5 - (Sin(5))");
            }

            [TestMethod]
            public void SubtractionFunctionAndFunction()
            {
                var a = new Sin(new Constant(5));
                var b = new Cos(a);
                var expr = a - b;
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.IsConstant, true);
                Assert.AreEqual(expr.ToString(), "(Sin(5)) - (Cos(Sin(5)))");
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
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = -5, ["b"] = 3 }), -15);
            }

            [TestMethod]
            public void MultiplicationVariable()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a * b;
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.IsConstant, false);
                Assert.AreEqual(expr.ToString(), "a * b");
            }
            [TestMethod]
            public void MultiplicationConstant1()
            {
                var a = new Constant(2);
                var b = new Constant(5);
                var expr = a * b;
                Assert.AreEqual(expr.IsConstant, true);
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.ToString(), "2 * 5");
            }
            [TestMethod]
            public void MultiplicationConstant2()
            {
                var a = 2;
                var b = new Constant(5);
                var expr = a * b;
                Assert.AreEqual(expr.IsConstant, true);
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.ToString(), "2 * 5");
            }
            [TestMethod]
            public void MultiplicationConstant3()
            {
                var a = new Constant(2);
                var b = 5;
                var expr = a * b;
                Assert.AreEqual(expr.IsConstant, true);
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.ToString(), "2 * 5");
            }
            [TestMethod]
            public void MultiplicationConstantVariable()
            {
                var a = new Variable("a");
                var b = new Constant(5);
                var expr = a * b;
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.IsConstant, false);
                Assert.AreEqual(expr.ToString(), "a * 5");
            }
            [TestMethod]
            public void MultiplicationVariableFunction()
            {
                var a = new Variable("a");
                var b = new Cot(new Variable("a"));
                var expr = a * b;
                Assert.AreEqual(expr.IsPolynom, false);
                Assert.AreEqual(expr.IsConstant, false);
                Assert.AreEqual(expr.ToString(), "a * (Cot(a))");
            }
            [TestMethod]
            public void MultiplicationConstantAndFunction()
            {
                var a = new Constant(5);
                var b = new Sin(new Variable("a"));
                var expr = a * b;
                Assert.AreEqual(expr.IsPolynom, false);
                Assert.AreEqual(expr.IsConstant, false);
                Assert.AreEqual(expr.ToString(), "5 * (Sin(a))");
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
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 6, ["b"] = 3 }), 2);
            }

            [TestMethod]
            public void DivisionNegZero() //
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a / b;
                Assert.IsTrue(double.IsInfinity(expr.Compute(new Dictionary<string, double> { ["a"] = -5, ["b"] = 0 })));
            }

            [TestMethod]
            public void DivisionVariable()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a / b;
                Assert.AreEqual(expr.IsPolynom, false);
                Assert.AreEqual(expr.IsConstant, false);
                Assert.AreEqual(expr.ToString(), "a / b");
            }
            [TestMethod]
            public void DivisionConstant1()
            {
                var a = new Constant(2);
                var b = new Constant(5);
                var expr = a / b;
                Assert.AreEqual(expr.IsConstant, true);
                Assert.AreEqual(expr.IsPolynom, true);
            }
            [TestMethod]
            public void DivisionConstant2()
            {
                var a = 2;
                var b = new Constant(5);
                var expr = a / b;
                Assert.AreEqual(expr.IsConstant, true);
                Assert.AreEqual(expr.IsPolynom, true);
            }
            [TestMethod]
            public void DivisionConstant3()
            {
                var a = new Constant(2);
                var b = 5;
                var expr = a / b;
                Assert.AreEqual(expr.IsConstant, true);
                Assert.AreEqual(expr.IsPolynom, true);
            }
            [TestMethod]
            public void DivisionVariableConstant()
            {
                var a = new Variable("a");
                var b = new Constant(5);
                var expr = a / b;
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.IsConstant, false);
                Assert.AreEqual(expr.ToString(), "a / 5");
            }
            [TestMethod]
            public void DivisionConstantVariable()
            {
                var a = new Variable("a");
                var b = new Constant(5);
                var expr = b / a;
                Assert.AreEqual(expr.IsPolynom, false);
                Assert.AreEqual(expr.IsConstant, false);
                Assert.AreEqual(expr.ToString(), "5 / a");
            }

            [TestMethod]
            public void DivisionVariableFunction()
            {
                var a = new Variable("a");
                var b = new Sin(new Constant(5));
                var expr = a / b;
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.IsConstant, false);
                Assert.AreEqual(expr.ToString(), "a / (Sin(5))");
            }

            [TestMethod]
            public void DivisionFunctionVariable()
            {
                var a = new Variable("a");
                var b = new Cos(new Constant(5));
                var expr = b / a;
                Assert.AreEqual(expr.IsPolynom, false);
                Assert.AreEqual(expr.IsConstant, false);
                Assert.AreEqual(expr.ToString(), "(Cos(5)) / a");
            }

            [TestMethod]
            public void DivisionConstantAndFunction()
            {
                var a = new Constant(5);
                var b = new Cot(a);
                var expr = a / b;
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.IsConstant, true);
                Assert.AreEqual(expr.ToString(), "5 / (Cot(5))");
            }

            [TestMethod]
            public void DivisionFunctionAndConstant()
            {
                var a = new Constant(5);
                var b = new Tan(a);
                var expr = b / a;
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.IsConstant, true);
                Assert.AreEqual(expr.ToString(), "(Tan(5)) / 5");
            }

            [TestMethod]
            public void DivisionFunctionAndFunction()
            {
                var a = new Sin(new Constant(5));
                var b = new Cos(a);
                var expr = a / b;
                Assert.AreEqual(expr.IsPolynom, true);
                Assert.AreEqual(expr.IsConstant, true);
                Assert.AreEqual(expr.ToString(), "(Sin(5)) / (Cos(Sin(5)))");
            }
        }
    }
}