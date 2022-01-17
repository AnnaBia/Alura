using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 17;
            int quantidadePessoas = 1;

            if (idade >= 18)
            {
                Console.WriteLine("Você tem mais que 18 anos\nSeja bem vindo!");
            }
            else
            {
                if (quantidadePessoas>=2)
                {
                    Console.WriteLine("Você não tem 18 anos, mas pode entrar, pois está acompanhado.");
                }
                else
                {
                    Console.WriteLine("Infelizmente você não pode entrar.");
                }
            }
            Console.ReadKey();

        }
    }
}
