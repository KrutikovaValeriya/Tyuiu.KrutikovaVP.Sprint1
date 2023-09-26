
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint1.Task4.V12.Lib;

namespace Tyuiu.KrutikovaVP.Sprint1.Task4.V12.Test
{
    [TestClass]
    public class DataserviceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0.25;
            double y = 4;
            var wait = 0.314;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(wait, res);

        }
    }
}
