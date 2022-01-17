using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupancaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000;
            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                // valorInvestido += valorInvestdido * 0.005
                valorInvestido *= 1.005;
                Console.WriteLine("Após {0} meses, você terá R${1:f2}", contadorMes, valorInvestido);
            }
            Console.ReadKey();
        }
    }
}
