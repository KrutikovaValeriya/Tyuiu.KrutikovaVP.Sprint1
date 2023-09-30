using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint1.Task7.V4.Lib;
namespace Tyuiu.KrutikovaVP.Sprint1.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 0;
            var wait = 2.079;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
