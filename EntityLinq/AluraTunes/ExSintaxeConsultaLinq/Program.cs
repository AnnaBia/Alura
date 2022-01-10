using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSintaxeConsultaLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>()
            {
                new Cliente{Id=1, Nome="José Raimundo Bernardino"},
                new Cliente{Id=2, Nome="Alexandre Marciano da Luz"},
                new Cliente{Id=3, Nome="Milton Guilherme da Silva"}
            };

            // apresente a lista de clientes
            var query = from cli in clientes
                        select cli;

            foreach(var c in clientes)
            {
                Console.WriteLine(c.Nome);
            }
            Console.ReadKey();
        }
        public class Cliente
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}
