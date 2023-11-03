using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Sprint3.Task3.V19.Lib;

namespace Tyuiu.MolodykhVY.Sprint3.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckReplaceCharInString()
        {
            DataService ds = new DataService();

            string str = "xaaaxaxaxa";
            char chr = 'x';
            char rhc = '2';
            string res = ds.ReplaceCharOnNum(str, chr, rhc);
            string wait = "2aaa2a2a2a";
            Assert.AreEqual(wait, res);

        }
    }
}
