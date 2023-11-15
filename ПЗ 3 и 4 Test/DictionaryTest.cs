using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ПЗ_3_и_4.IExpr.MainStruct;
using ПЗ_3_и_4.IExpr;
using ПЗ_3_и_4.Dictionary;


namespace ПЗ_3_и_4_Test;

[TestClass]
public class DictionaryTest
{
    [TestMethod]
    public void MultiplicationVariableVariousVariables()
    {
        var x = new string[] { "a", "b" };
        AbstractExpr expr = new Variable("a") * new Variable("b");
        var actual = expr.Variables.ToList();
        for (int i = 0; i < x.Length - 1; i++)
            Assert.AreEqual(x[i], actual[i]);
    }

    [TestMethod]
    public void MultiplicationVariableSameVariables()
    {
        var x = new string[] { "b" };
        AbstractExpr expr = new Variable("b") * new Variable("b");
        var actual = expr.Variables.ToList();
        for (int i = 0; i < x.Length - 1; i++)
            Assert.AreEqual(x[i], actual[i]);
    }
    [TestMethod]
    public void VariablesAndValues()
    {
        var values = new Dictionary<string, double> { ["a"] = 7, ["b"] = 4 };
        Console.WriteLine($"значения переменных: {values}");
    }
}
