using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresRelacionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo 1
            double nota1 = 8.0;
            double nota2 = 9.0;

            Console.WriteLine("Nota maior que 7? {0}", nota1 > 7.0);
            Console.WriteLine("Tirou 10? {0}", nota2 == 10.0);
            
            //Exemplo 2
            Console.WriteLine("Digite sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);

            Console.WriteLine("Nota maior que 7? {0}", nota > 7.0);
            Console.WriteLine("tirou 10? {0}", nota == 10.0);

            Console.ReadKey();
        }
    }
}
