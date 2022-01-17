using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupancaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000;
            double rendimentoMensal = 0.005;//0.5% = 0.005
            int contador = 1;

            while (contador<=12)
            {
                valorInvestido += valorInvestido * rendimentoMensal;
                Console.WriteLine("Após {0} mês, você terá R${1:f2}", contador, valorInvestido);
                contador++;
            }
            Console.ReadKey();
        }
    }
}
