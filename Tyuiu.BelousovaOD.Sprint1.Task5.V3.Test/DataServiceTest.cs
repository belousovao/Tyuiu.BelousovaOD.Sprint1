using Tyuiu.BelousovaOD.Sprint1.Task5.V3.Lib;
namespace Tyuiu.BelousovaOD.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 23456;

            var h = ds.Calculate(k);
            Assert.AreEqual(4, h);
        }
    }
}