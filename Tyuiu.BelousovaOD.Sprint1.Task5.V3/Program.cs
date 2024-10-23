using Tyuiu.BelousovaOD.Sprint1.Task5.V3.Lib;
namespace Tyuiu.BelousovaOD.Sprint1.Task5.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Булоусова О. Д. | СМАРТб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                               *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #3                                                               *");
            Console.WriteLine("* Выполнила: Булоусова О. Д. | СМАРТб-24-1                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Присвоить целой переменной h третью от конца цифру в записи              *");
            Console.WriteLine("* положительного целого числа k                                            *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int k;
            Console.WriteLine("Введите значение K: ");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Значение переменной h = " + ds.Calculate(k));
            Console.ReadLine();


        }
    }
}
