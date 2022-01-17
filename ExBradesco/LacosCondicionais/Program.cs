using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = 5;
            var n2 = 9;
            var n3 = 10;

            if (n1 < n2)
            {
                Console.WriteLine(n1 + n2);
            }
            if (n3 < n2)
            {
                Console.WriteLine(n3 + n2);
            }

            Console.ReadKey();
        }
    }
}
