using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            var media = 0.0;

            Console.WriteLine("Olá, bem vindo ao programa de cálculo de média!");
            Console.WriteLine("Irei auxiliar você a calcular a média do seu aluno!");
            Console.Write("Digite a primeira nota: ");
            double.TryParse(Console.ReadLine(), out double nota1);
            Console.Write("Digite a segunda nota: ");
            double.TryParse(Console.ReadLine(), out double nota2);
            Console.Write("Digite a terceira nota: ");
            double.TryParse(Console.ReadLine(), out double nota3);

            media = (nota1 + nota2 + nota3) / 3;

            if (media < 7)
            {
                Console.WriteLine("Aluno está em recuperação!");
            }
            else
            {
                Console.WriteLine("Aluno aprovado!");
            }
 
            Console.ReadKey();
        }
    }
}
