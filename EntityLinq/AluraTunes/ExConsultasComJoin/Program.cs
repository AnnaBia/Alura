using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExConsultasComJoin
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
                new Musica { Id = 4, Nome = "Is This Love", GeneroId = 2 }
            };

            List<Genero> generos = new List<Genero>
            {
                new Genero { Id = 1, Nome = "Rock" },
                new Genero { Id = 2, Nome = "Reggae" },
                new Genero { Id = 3, Nome = "Rock Progressivo" },
                new Genero { Id = 4, Nome = "Jazz" },
                new Genero { Id = 5, Nome = "Punk Rock" },
                new Genero { Id = 6, Nome = "Classica" }
            };

            // listar os nomes das músicas cujo gênero tenha o nome "Reggae".
            var query = from m in musicas
                        join g in generos on m.GeneroId equals g.Id
                        where g.Nome == "Reggae"
                        select m.Nome;

            foreach(var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
    public class Musica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int GeneroId { get; set; }
    }
    public class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
