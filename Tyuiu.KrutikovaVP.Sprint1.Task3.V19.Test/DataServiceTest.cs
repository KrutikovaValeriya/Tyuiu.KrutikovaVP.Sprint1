using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint1.Task3.V19.Lib;
namespace Tyuiu.KrutikovaVP.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressionTrue()
        {
            DataService ds = new DataService();
            double x1 = 1;
            double y1 = 1;
            double x2 = 3;
            double y2 = 3;
            var res = ds.ElephCanMove(x1, y1, x2, y2);
            Assert.IsTrue(res, "true");

            double X1 = 1;
            double Y1 = 1;
            double X2 = 3;
            double Y2 = 4;
            var res1 = ds.ElephCanMove(X1, Y1, X2, Y2);
            Assert.IsFalse(res1, "false");
        }
 

 

    }
}
