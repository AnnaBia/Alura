using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicaoDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            int idadeGustavo = idade;
            idade = 20;
            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

            string parcela_1 = "10", parcela_2 = "30";
            Console.WriteLine(parcela_1+parcela_2);
            Console.ReadKey();
        }
    }
}
