using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            var atividade1 = true;
            var atividade2 = false;

            var todas = atividade1 && atividade2;
            Console.WriteLine("Fez todas as atividades? {0}", todas);

            var umaApenas = atividade1 || atividade2;
            Console.WriteLine("Fez pelo menos uma das atividades? {0}", umaApenas);
            Console.WriteLine("Não fez nenhuma? {0}", !umaApenas);

            Console.ReadKey();
        }
    }
}
