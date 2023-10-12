using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint2.Task3.V21.Lib;

namespace Tyuiu.KhasanovRV.Sprint2.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2.0;
            var y = ds.Calculate(x);
            Assert.AreEqual(242, y);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0.0;
            var y = ds.Calculate(x);
            Assert.AreEqual(0.833, y);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -1.0;
            var y = ds.Calculate(x);
            Assert.AreEqual(0.5, y);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -30.0;
            var y = ds.Calculate(x);
            Assert.AreEqual(-329.967, y);
        }
    }
}
