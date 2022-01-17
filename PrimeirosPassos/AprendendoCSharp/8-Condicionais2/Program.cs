using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 16, quantidadePessoas = 3;
            bool acompanhado = true;

            // Operadores Lógicos
            //if(idade>=18 || quantidadePessoas >= 2)
            //if(idade>=18 && quantidadePessoas>=2)
            if (idade >= 18 && acompanhado)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("Infelizmenteo voê não pode entrar");
            }
            Console.ReadKey(); ;
        }
    }
}
