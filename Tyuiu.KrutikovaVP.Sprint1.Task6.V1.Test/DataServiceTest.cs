using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint1.Task6.V1.Lib;

namespace Tyuiu.KrutikovaVP.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value= "A";
            string wait = "65";
            var res = ds.SymbolCode(value);
            Assert.AreEqual(wait, res);

        }
    }
}
