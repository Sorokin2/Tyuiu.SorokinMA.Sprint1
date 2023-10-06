﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint1.Task1.V10.Lib;

namespace Tyuiu.SorokinMA.Sprint1.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 9.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3, res);
        }
    }
}
