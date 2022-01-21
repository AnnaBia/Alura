using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encadeando laços for
            double valorInvestido = 1000;
            double fatorRendimento = 1.005;
            int contadorAno = 1, contadorMes = 1;

            //projetando rendimento de 5 anos
            for (contadorAno=1; contadorAno<=5; contadorAno++)
            {
                //calculando o rendimento de 1 ano
                for(contadorMes=1; contadorMes<=12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.010;
            }
            Console.WriteLine("Ao término do investimento você terá R${0:f2}", valorInvestido);

            Console.ReadKey();
        }
    }
}
