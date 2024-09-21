
using System;

using Tyuiu.DonskoiIA.Sprint1.Task4.V23.Lib;

namespace Tyuiu.DonskoiIA.Sprint1.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(60, 30);
            Assert.AreEqual(0.166, res);
        }
    }
}