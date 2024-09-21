
using System;

using Tyuiu.DonskoiIA.Sprint1.Task7.V9.Lib;

namespace Tyuiu.DonskoiIA.Sprint1.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(0, 0);
            Assert.AreEqual(1.503, res);
        }
    }
}