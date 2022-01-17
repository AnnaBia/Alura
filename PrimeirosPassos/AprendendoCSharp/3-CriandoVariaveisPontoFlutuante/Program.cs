using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1250.70;
            Console.WriteLine(salario);
            double idade = 15.0/2; // não esquecer do '.0'
            Console.WriteLine(idade);

            int divisao = 5 / 2;
            Console.WriteLine(divisao);
            double divisao2 = 5.0 / 2;
            Console.WriteLine(divisao2);
            
            double peso = 4.0;
            int quantidade = 10;
            Console.WriteLine(peso*quantidade);

            int brindes = 15;
            int pessoas = 2;
            Console.WriteLine(brindes/pessoas);

            int dia = 4;
            int outroDia = 4 + dia;
            Console.WriteLine(outroDia);

            double preco = 5.5;
            int ingressos = 4;
            Console.WriteLine(preco*ingressos);
            Console.ReadKey();
        }
    }
}
