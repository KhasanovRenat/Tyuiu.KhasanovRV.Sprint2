using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KhasanovRV.Sprint2.Task6.V12.Lib;

namespace Tyuiu.KhasanovRV.Sprint2.Task6.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Хасанов Р. В. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Хасанов Ренат Владиславович | СМАРТб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("* Условие: Дата некоторого дня характеризуется тремя натуральными         *");
            Console.WriteLine("* числами: g (год), m (порядковый номер месяца) и n (число). По заданным  *");
            Console.WriteLine("* g, n и m определить дату предыдущего дня. Заданный год является         *");
            Console.WriteLine("* високосным.                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int g, m, n;

            Console.WriteLine("Введите год G:");
            g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц M:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день N:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var s = ds.FindDateOfPreviousDay(g, m, n);
            Console.WriteLine("Вчера было " + s);
            Console.ReadKey();
        }
    }
}
