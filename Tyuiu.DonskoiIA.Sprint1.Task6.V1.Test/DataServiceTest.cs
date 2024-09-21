
using System;

using Tyuiu.DonskoiIA.Sprint1.Task6.V1.Lib;

namespace Tyuiu.DonskoiIA.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.SymbolCode("1");
            Assert.AreEqual("Символ: 1 Код: 49", res);
        }
    }
}