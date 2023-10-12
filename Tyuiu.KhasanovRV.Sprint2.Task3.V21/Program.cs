using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KhasanovRV.Sprint2.Task3.V21.Lib;

namespace Tyuiu.KhasanovRV.Sprint2.Task3.V21
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Хасанов Ренат Владиславович | СМАРТб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
            Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит      *");
            Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение до    *");
            Console.WriteLine("* трех знаков после запятой;                                              *");
            Console.WriteLine("*      {               x                                                  *");
            Console.WriteLine("*      {      ( x + 9 )                                                   *");
            Console.WriteLine("*      {  x * (-------)  , x > 1                                          *");
            Console.WriteLine("*      {      ( x - 1 )                                                   *");
            Console.WriteLine("*      {                                                                  *");
            Console.WriteLine("*      {      2                                                           *");
            Console.WriteLine("*      {     x  + 10                                                      *");
            Console.WriteLine("*      {  ------------------ , x = 0                                      *");
            Console.WriteLine("*      {    2        2                                                    *");
            Console.WriteLine("*      {   x  - sin x  + 12                                               *");
            Console.WriteLine("*      {                                                                  *");
            Console.WriteLine("*  y = {            x                                                     *");
            Console.WriteLine("*      {  (     1 )                                                       *");
            Console.WriteLine("*      {  (1 + ---)  , -25 < x < 2                                        *");
            Console.WriteLine("*      {  (      2)                                                       *");
            Console.WriteLine("*      {  (    x  )                                                       *");
            Console.WriteLine("*      {                                                                  *");
            Console.WriteLine("*      {            ( 1 )                                                 *");
            Console.WriteLine("*      {  x + 10x - (___) , x < -25                                       *");
            Console.WriteLine("*      {            ( x )                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x;
            Console.WriteLine("Введите значение переменной X:");
            x = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var y = ds.Calculate(x);
            Console.WriteLine("Переменная Y будет равна " + y);
            Console.ReadKey();
        }
    }
}
