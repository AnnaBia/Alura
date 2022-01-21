using System;

namespace P_ExerciciosFor
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Imprimindo cadeia de números*/
            Console.WriteLine("Imprimindo cadeia de números");
            // forma 1
            for (int Linha = 1; Linha <= 5; Linha++)
            {
                for (int Coluna = 1; Coluna <= Linha; Coluna++)
                {
                    Console.Write(Coluna);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // forma 2
            for (int linha = 1; linha <= 5; linha++)
            {
                for (int coluna = 1; coluna <= 5; coluna++)
                {
                    if (coluna <= linha)
                    {
                        Console.Write(coluna);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /* múltiplos de 3 entre 1 e 100*/
            Console.WriteLine("Múltiplos de 3 entre 1 e 100");
            for (int cont = 1; cont <= 100; cont++)
            {
                if ((cont % 3) == 0)
                {
                    Console.WriteLine(cont);
                }
            }
        }
    }
}
