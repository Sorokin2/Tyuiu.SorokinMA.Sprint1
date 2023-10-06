using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint1.Task2.V10.Lib;

namespace Tyuiu.SorokinMA.Sprint1.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            var res = ds.ConvertMetreToInchs(x);
            Assert.AreEqual(196.850, res);
        }
    }
}
