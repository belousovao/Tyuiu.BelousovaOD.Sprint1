using Tyuiu.BelousovaOD.Sprint1.Task6.V11.Lib;
namespace Tyuiu.BelousovaOD.Sprint1.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressionTrue()
            {
                DataService ds = new DataService();
                string value = "барабан";
                var res = ds.CheckeFirstLetterRepetition(value);
                Assert.AreEqual(true, res);
            }
            [TestMethod]
        public void ValidExpressionFalse()
            {
                DataService ds = new DataService();
                string value = "арбуз";
                var res = ds.CheckeFirstLetterRepetition(value);
                Assert.AreEqual(false, res);
            }

        }
    }
