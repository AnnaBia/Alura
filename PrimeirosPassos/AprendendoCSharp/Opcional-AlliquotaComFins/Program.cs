using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcional_AlliquotaComFins
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3800.0;

            if(salario>=1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("O IR é de 7.5%\nPode deduzir R$142.00");
            }
            else if(salario>=2800.01 && salario <= 3751.0)
            {
                Console.WriteLine("O IR é de 15%\nPode deduzir R$350.00");
            }
            else if(salario>=3751.01 && salario <= 4664.0)
            {
                Console.WriteLine("O IR é de 22.5%\nPode deduzir R$636.00");
            }
            else
            {
                Console.WriteLine("Valor inválido! Reinicie o programa");
            }
            Console.ReadKey();
        }
    }
}
