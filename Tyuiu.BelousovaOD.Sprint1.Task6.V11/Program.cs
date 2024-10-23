﻿using Tyuiu.BelousovaOD.Sprint1.Task6.V11.Lib;
namespace Tyuiu.BelousovaOD.Sprint1.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Белоусова О. Д. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Белоусова О. Д. | СМАРТб-24-1                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что первая    *");
            Console.WriteLine("* буква строки входит в нее еще раз.                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string valid;

            Console.WriteLine("Введите строку (с маленькой буквы): ");
            valid = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (ds.CheckeFirstLetterRepetition(valid))
            {
                Console.WriteLine("Первая буква повторяется");
            }
            else
            {
                Console.WriteLine("Первая буква не повторяется");
            }
            Console.ReadKey();
        }
    }
}
