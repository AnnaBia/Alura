using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOperadorDeIgualdade
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Musica> musicas = new List<Musica>
            {
                new Musica { Id = 1, Nome = "Sweet Child O'Mine", GeneroId = 1 },
                new Musica { Id = 2, Nome = "I Shot The Sheriff", GeneroId = 2 },
                new Musica { Id = 3, Nome = "Danúbio Azul", GeneroId = 6 },
                new Musica { Id = 4, Nome = "Galinha Pintadinha", GeneroId = 1 }
            };
            // Todas as músicas cujo GeneroId seja igual a 1.
            var query = from m in musicas
                        where m.GeneroId == 1
                        select m;

            foreach (var m in query)
            {
                Console.WriteLine(m.Nome);
            }
            Console.ReadKey();
        }
        public class Musica
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public int GeneroId { get; set; }
        }
    }
}