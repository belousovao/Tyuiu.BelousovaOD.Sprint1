using Tyuiu.BelousovaOD.Sprint1.Task0.V21.Lib;
namespace Tyuiu.BelousovaOD.Sprint1.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(17, res);
        }
    }
}