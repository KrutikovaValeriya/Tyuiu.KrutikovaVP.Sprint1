
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint1.Task5.V2.Lib;

namespace Tyuiu.KrutikovaVP.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double tempFahren = 140;
            var resOne = 4;
            var resTtwo = ds.FahrenheitToСelsius(tempFahren);
            Assert.AreEqual(resOne, resTtwo);


        }
    }
}
