using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KrutikovaVP.Sprint1.Task2.V12.Lib;
namespace Tyuiu.KrutikovaVP.Sprint1.Task2.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int value, valueTwo, valueThree;

            Console.WriteLine("Введите значение длины параллелепипида: ");
            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение ширины параллелепипида: ");
            valueTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение высоты параллелепипида: ");
            valueThree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Объем параллелепипида = " + ds.CalculateParallelepipedVolume(value, valueTwo, valueThree));

            Console.ReadKey();
        }
    }
}
