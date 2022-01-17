using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresUnarios
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = false;
            var n1 = 6;
            var n2 = 5;
            var n3 = 7;
            var n4 = 8;

            Console.WriteLine(!x);
            n3++;
            Console.WriteLine(n3);
            n4--;
            Console.WriteLine(n4);

            Console.WriteLine(n2 == (--n1));
            Console.WriteLine(n1);
            Console.WriteLine(n2++ == ++n1);
            Console.WriteLine(n2);
            Console.WriteLine(n1);
            
            Console.ReadKey();
        }
    }
}
