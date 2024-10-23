using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BelousovaOD.Sprint1.Task7.V5.Lib
{
    public class DataService : ISprint1Task7V5
    {
        public double Calculate(double x)
        {
            double a = (Math.Log10(Math.Abs(Math.Cos(x)))) / (Math.Log10(1 + Math.Pow(x, 2)));
            return Math.Round(a, 3);

        }
    }
}
