using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            //character
            char primeiraletra = 'a';
            Console.WriteLine(primeiraletra);

            primeiraletra = (char)61;
            Console.WriteLine(primeiraletra);

            primeiraletra = (char)(primeiraletra + 1);
            Console.WriteLine(primeiraletra);

            //string
            string titulo = "alura cursos de tecnologia" + 2020;
            string cursosprogramacao =@"- .net 
- java 
- javascript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursosprogramacao);
            Console.ReadKey();
        }
    }
}
