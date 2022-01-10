using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExConsultaComFiltro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Genero> generos = new List<Genero>
            {
                new Genero{ Id = 1, Nome = "Rock"},
                new Genero{ Id = 2, Nome = "Reggae"},
                new Genero{ Id = 3, Nome = "Rock Progressivo"},
                new Genero{ Id = 4, Nome = "Jazz"},
                new Genero{ Id = 5, Nome = "Punk Rock"},
                new Genero{ Id = 6, Nome = "Classica"}
            };
            // trazer somente os gêneros que contenham a palavra "Rock"
            var query = from gen in generos
                        where (gen.Nome.Contains("Rock"))
                        select gen;

            foreach(var g in query)
            {
                Console.WriteLine(g.Nome);
            }
            Console.ReadKey();
        }
        public class Genero
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}
