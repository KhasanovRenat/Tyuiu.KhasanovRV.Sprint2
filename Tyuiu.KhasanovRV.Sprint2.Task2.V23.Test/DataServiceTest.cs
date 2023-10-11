using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint2.Task2.V23.Lib;

namespace Tyuiu.KhasanovRV.Sprint2.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4, y = 4;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
