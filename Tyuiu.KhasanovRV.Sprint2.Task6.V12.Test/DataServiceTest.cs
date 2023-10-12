using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint2.Task6.V12.Lib;

namespace Tyuiu.KhasanovRV.Sprint2.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int g = 1992, m = 4, n = 1;
            var res = ds.FindDateOfPreviousDay(g, m, n);

            Assert.AreEqual("31.3.1992", res);
        }
    }
}
