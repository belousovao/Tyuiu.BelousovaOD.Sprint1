using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BelousovaOD.Sprint1.Task4.V12.Lib;
namespace Tyuiu.BelousovaOD.Sprint1.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
