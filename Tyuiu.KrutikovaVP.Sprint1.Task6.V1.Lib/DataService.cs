using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KrutikovaVP.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {
        public string SymbolCode(string value)
        {
            char symbol = Convert.ToChar(value);
            string symbolCode = Convert.ToString((int)symbol);
            return symbolCode;

            
        }
    }
}
