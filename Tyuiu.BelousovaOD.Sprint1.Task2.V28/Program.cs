using Tyuiu.BelousovaOD.Sprint1.Task2.V28.Lib;
namespace Tyuiu.BelousovaOD.Sprint1.Task2.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Sprint #1 | Выполнила: Белоусова О. Д. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Sprint #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("*  Выполнила: Белоусова О. Д. | СМАРТб-24-1                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Формулировка задания:                                                   *");
            Console.WriteLine("*  Известна температура в градусах Цельсия.                               *");
            Console.WriteLine("* Перевести температуру в градусы Кельвина.                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Что пользователь вводит?                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Температура в градусах Цельсия (целое число)                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Что программа печатает на экране?                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Температура в градусах Кельвина (целое число)                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите температуру в градусах Цельсия:");
            int celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int kelvin = celsius + 273;

            Console.WriteLine($"Температура в градусах Кельвина: {kelvin}");
            Console.ReadLine();

        }
    }
}
