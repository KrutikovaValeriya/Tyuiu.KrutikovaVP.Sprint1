using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint1.Task1.V12.Lib;


namespace Tyuiu.KrutikovaVP.Sprint1.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 9.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2,res);
        }
    }
}
