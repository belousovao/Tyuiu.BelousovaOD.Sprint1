using Tyuiu.BelousovaOD.Sprint1.Task3.V11.Lib;
namespace Tyuiu.BelousovaOD.Sprint1.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x1 = -2, x2 = 1, x3 = 5, y1 = 5, y2 = 7, y3 = -3;
            var res = ds.TriangleArea(x1, x2, x3, y1, y2, y3);
            Assert.AreEqual(19, res);

        }
    }
}