using Tyuiu.BelousovaOD.Sprint1.Task2.V28.Lib;
namespace Tyuiu.BelousovaOD.Sprint1.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            var res = ds.ConvertCelsiusToKelvin(x);
            Assert.AreEqual(276, res);
        }
    }
}