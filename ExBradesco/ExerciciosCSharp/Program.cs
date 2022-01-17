using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcao = true;

            Console.WriteLine("Ola, irei realizar a soma de números que você deseja até você deseja parar");
            Console.Write("Digite o valor inicial: ");
            double.TryParse(Console.ReadLine(), out double inicial);

            while (opcao == true)
            {
                Console.Write("Digite o número que deseja somar ao número inicial: ");
                double.TryParse(Console.ReadLine(), out double n1);
                inicial += n1;
                Console.WriteLine("A soma até o momento é de {0}", inicial);
                Console.WriteLine("Deseja sair do programa? 1 - sim, 2 - não");
                int.TryParse(Console.ReadLine(), out int saida);

                switch (saida)
                {
                    case 1:
                        Console.WriteLine("Saindo do programa...");
                        opcao = false;
                        break;
                    case 2:
                        Console.WriteLine("Continua a soma.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Retornando para soma.");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
