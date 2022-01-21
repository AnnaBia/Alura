using System;

namespace P_OpicionalFatorial
{
    class Program
    {
        /* imprima os fatoriais de 1 a 10*/
        static void Main(string[] args)
        {
            int fatorial = 1;

            for(int n = 1; n <= 10; n++)
            {
                fatorial *= n;
                Console.WriteLine("O fatorial de {0} é {1}", n, fatorial);
            }
            Console.ReadKey();
        }
    }
}
