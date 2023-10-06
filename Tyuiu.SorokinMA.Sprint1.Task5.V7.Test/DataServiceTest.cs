using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.SorokinMA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double f = 256.43;
            var res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(8, res);
        }
    }
}
