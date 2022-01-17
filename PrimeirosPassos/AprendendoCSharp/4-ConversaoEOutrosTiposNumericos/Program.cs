using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversaoEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            double Salario = 1200.50;

            //Objeto int é um tipo de variavel que suporta valores até 32 bits -- números inteiros
            int salarioEmInteiro = (int)Salario;
            Console.WriteLine(salarioEmInteiro);

            //Objeto long é uma variavel de 64 bits
            long idade = 1300000000000000000;
            Console.WriteLine(idade);

            // O short é um tipo de variável de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            // CONVERSÕES
            // int em double ok
            // double em int não
            double salario = 1270.50;
            int valor = (int)salario;
            Console.WriteLine(valor); // casting

            // exemplo double -- números com casa decimal
            double valor1 = 0.2, valor2 = 0.1;
            double total = valor1 + valor2;
            Console.WriteLine(total);

            // exemplo float
            float pontoFlutuante = 3.14f;

            Console.ReadKey();
        }
    }
}
