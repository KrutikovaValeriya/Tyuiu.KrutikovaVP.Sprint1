using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint1.Task2.V12.Lib;


namespace Tyuiu.KrutikovaVP.Sprint1.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var a = 5;
            var b = 6;
            var c = 7;
            var res = ds.CalculateParallelepipedVolume(a, b, c);
            Assert.AreEqual(res, 210);
        }
    }
}
