using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint1.Task4.V11.Lib;

namespace Tyuiu.SorokinMA.Sprint1.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1, y = 0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.785, res);
        }
    }
}
