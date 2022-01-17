using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwichCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a nota você dar para o prato? 0, 5 ou 10?");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Comida muito ruim!");
                    break;
                case 5:
                    Console.WriteLine("Comida razoável!");
                    break;
                case 10:
                    Console.WriteLine("Comida muito boa!");
                    break;
                default:
                    Console.WriteLine("Nota inexistente!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
