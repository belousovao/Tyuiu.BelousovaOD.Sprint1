using Tyuiu.BelousovaOD.Sprint1.Task7.V5.Lib;
namespace Tyuiu.BelousovaOD.Sprint1.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = -5;
            var res = ds.Calculate(x);
            Assert.AreEqual(res, -0.387);

        }
    }
}