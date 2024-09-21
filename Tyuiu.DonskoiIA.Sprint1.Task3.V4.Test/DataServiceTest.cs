
using System;

using Tyuiu.DonskoiIA.Sprint1.Task3.V4.Lib;

namespace Tyuiu.DonskoiIA.Sprint1.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.PurchaseAmount(2.75, 0.5, 7);
            Assert.AreEqual(22.75, res);
        }
    }
}