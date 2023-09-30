using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KrutikovaVP.Sprint1.Task7.V4.Lib;

namespace Tyuiu.KrutikovaVP.Sprint1.Task7.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Крутикова В.П. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Крутикова Валерия Павловна | АСОиУб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Напишите программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("         |                  (         y     )  |                          *");
            Console.WriteLine("  z = ln | (y - Sqrt(|x|) * ( x - --------- )  |                          *");
            Console.WriteLine("         |                  (            2  )  |                          *");
            Console.WriteLine("         |                  (           x   )  |                          *");
            Console.WriteLine("         |                  (      x + ---  )  |                          *");
            Console.WriteLine("         |                  (           4   )  |                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            Console.Write("Значение X = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Значение Y = ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.Calculate(x, y);
            Console.WriteLine(res);

            Console.ReadKey();



        }
    }
}
