using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //float f1 = 35e2f; 35= valor e= potencia 10, 2 qtdd de 0, f por ser float
            //double d1 = 12e4;
            int x = 4;
            double y = 3.3;
            const double frequencia = 60;

            double area = x * y;

            Console.WriteLine("A área do quadrado é: " + area);
            Console.ReadKey();
        }
    }
}
