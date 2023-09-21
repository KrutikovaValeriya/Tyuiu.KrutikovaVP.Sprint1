using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KrutikovaVP.Sprint1.Task3.V19.Lib;

namespace Tyuiu.KrutikovaVP.Sprint1.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            
            double x1, y1, x2, y2;
            x1 = 4;
            y1 = 4;
            x2 = 7;
            y2 = 6;
           
            Console.WriteLine("Координаты первой ячейки: x1="+x1+"; y1="+y1);
            Console.WriteLine("Координаты второй ячейки: x2=" + x2 + "; y2=" + y2);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Переход шахматной фигурки 'слон' с одного заданного поля на другое: " + ds.ElephCanMove(x1, y1, x2, y2));
            
            Console.ReadKey();
        }
    }
}
