using System;

namespace LacoDeRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            /* Imprimindo número de 0 a 10*/
            // laço while
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
            Console.WriteLine();
            // laço for
            for (contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine(contador);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
