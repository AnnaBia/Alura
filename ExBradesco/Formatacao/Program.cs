using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 20.232;
            Console.WriteLine(x.ToString("F1")); // Converte para float
            Console.WriteLine(x.ToString("C")); // Converte para moeda
            Console.WriteLine(x.ToString("P")); // Converte para porcentagem

            Console.ReadKey();
        }
    }
}
