using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Sprint3.Task2.V21.Lib;

namespace Tyuiu.MolodykhVY.Sprint3.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 1.5;
            double res = ds.GetSumSeries(x);
            double wait = 0.298;
            Assert.AreEqual(wait, res);

        }
    }
}
