using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KhasanovRV.Sprint2.Task2.V23.Lib;

namespace Tyuiu.KhasanovRV.Sprint2.Task2.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Хасанов Р. В. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Хасанов Ренат Владиславович | СМАРТб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной      *");
            Console.WriteLine("* области.                                                                *");
            Console.WriteLine("* _______________                                                         *");
            Console.WriteLine("* _______________                                                         *");
            Console.WriteLine("* __+++___++++___                                                         *");
            Console.WriteLine("* __+++___++++___                                                         *");
            Console.WriteLine("* __++++++++++___                                                         *");
            Console.WriteLine("* ______+++++++__                                                         *");
            Console.WriteLine("* ______+++++++__                                                         *");
            Console.WriteLine("* ______+++++++__                                                         *");
            Console.WriteLine("* _____+++++++___                                                         *");
            Console.WriteLine("* _____+++++++___                                                         *");
            Console.WriteLine("* __+++++++++++__                                                         *");
            Console.WriteLine("* _______++++_++__                                                         *");
            Console.WriteLine("* _______________                                                         *");
            Console.WriteLine("* _______________                                                         *");
            Console.WriteLine("* _______________                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x, y;
            Console.WriteLine("Введите значение переменной X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y:");
            y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.CheckDotInShadedArea(x, y);
            if (res)
                Console.WriteLine("Точка находится в заштрихованной области");
            else
                Console.WriteLine("Точка не находится в заштрихованной области");
            Console.ReadKey();
        }
    }
}
