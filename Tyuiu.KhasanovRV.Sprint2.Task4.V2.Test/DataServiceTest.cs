using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint2.Task4.V2.Lib;

namespace Tyuiu.KhasanovRV.Sprint2.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 5.0, y = 1.0;
            var z = ds.Calculate(x,y);
            Assert.AreEqual(11,z);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2.0, y = 1.0;
            var z = ds.Calculate(x, y);
            Assert.AreEqual(2, z);
        }
    }
}
