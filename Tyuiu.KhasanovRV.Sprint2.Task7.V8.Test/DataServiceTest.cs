using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint2.Task7.V8.Lib;

namespace Tyuiu.KhasanovRV.Sprint2.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea1()
        {
            DataService ds = new DataService();
            double x = 3, y = 2;
            var z = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, z);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea2()
        {
            DataService ds = new DataService();
            double x = 1, y = 3;
            var z = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(false, z);
        }
    }
}
