using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Sprint3.Task4.V16.Lib;

namespace Tyuiu.MolodykhVY.Sprint3.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(2.757, res);
        }
    }
}
