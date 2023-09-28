using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KrutikovaVP.Sprint1.Task6.V1.Lib;

namespace Tyuiu.KrutikovaVP.Sprint1.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Крутикова В.П. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Крутикова Валерия Павловна | АСОиУб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Напишите программу, которая выводит код веденного пользователем символа *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите символ и нажмите <Enter> ");
            Console.WriteLine("Для завершения нажмите точку. ");

            Console.Write("-> ");
            string symbol = Console.ReadLine();
            do
            {
                var res = ds.SymbolCode(symbol);
                Console.WriteLine($"Символ: {symbol} Код: {res}");
                Console.Write("-> ");
                symbol = Console.ReadLine();
            }
            while (symbol != ".");
            Console.ReadKey();

            

        }
    }
}
