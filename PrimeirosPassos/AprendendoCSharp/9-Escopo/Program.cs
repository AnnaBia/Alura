using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            // errado, pois fora do escopo if/else, a variável salario não foi declarada
            //bool foiPromovido = true;
            //if (foiPromovido)
            //{
            //    double salario = 4200.0;
            //}
            //else
            //{
            //    double salario = 3800.0;
            //}
            //Console.WriteLine(salario);
            //Console.ReadKey();

            bool foiPromovido = true;
            double salario;

            if (foiPromovido)
            {
                salario = 4200.0;
            }
            else
            {
                salario = 3800.0;
            }
            Console.WriteLine(salario);
            Console.ReadKey();
        }
    }
}
