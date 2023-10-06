using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint1.Task3.V15.Lib;

namespace Tyuiu.SorokinMA.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 3, v2 = 4, S = 13, T = 5;
            var res = ds.DistanceOverTime(v1, v2, S, T);
            Assert.AreEqual(48.000, res);
        }
    }
}
