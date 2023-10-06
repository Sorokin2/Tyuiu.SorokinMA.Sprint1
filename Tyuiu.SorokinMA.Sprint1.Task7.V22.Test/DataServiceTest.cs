using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint1.Task7.V22.Lib;

namespace Tyuiu.SorokinMA.Sprint1.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dt = new DataService();
            double x = 2, y = 1;
            var res = dt.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}
