using System;

namespace P_TabuadaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tabuada do 1 ao 10*/
            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                for (int cont = 1; cont <= 10; cont++)
                {
                    Console.WriteLine("{0} x {1} = {2}", cont, multiplicador, cont * multiplicador);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
