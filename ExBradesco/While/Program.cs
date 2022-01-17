using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = 1;

            while (n1 <= 15)
            {
                Console.WriteLine(n1);
                n1++;
            }
            Console.ReadKey();
        }
    }
}
