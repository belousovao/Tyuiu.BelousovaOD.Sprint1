using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BelousovaOD.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            var h = (k % 1000 - k % 100) / 100;
            return h;
        }
    }
}
