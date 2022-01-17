using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo 1
            int x = 4;
            double y = x; // Conversão
            Console.WriteLine(y);

            //Exemplo 2
            double nota = 8.6;
            int notaConvertida = (int)nota; // Conversão
            Console.WriteLine(notaConvertida);

            //Exemplo 3
            Console.WriteLine("digite o número da sua casa: "); // writeline = imprime o texto
            string numerocasa = Console.ReadLine();
            int numero = int.Parse(numerocasa);
            Console.WriteLine("número da sua casa é: {0}", numero);
            numero = Convert.ToInt32(numero);

            //Exemplo 4
            Console.Write("Qual seu nome? ");
            String nome = Console.ReadLine();
            Console.Write("Quantos anos você tem? ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Quanto você tem de altura? ");
            double altura = double.Parse(Console.ReadLine());
            Console.Write("Quanto você pesa? ");
            int peso = int.Parse(Console.ReadLine());
            Console.WriteLine("Seu nome é {0}\nSua idade é de {1} anos\nSua altura é {2:f2}\nVocê pesa {3} kilos", nome, idade, altura, peso);

            Console.ReadKey();
        }
    }
}
