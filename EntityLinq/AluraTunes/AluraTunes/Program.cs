using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraTunes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Listar os gêneros rock
            var generos = new List<Genero>
            {
                new Genero{Id=1,Nome="Rock" },
                new Genero{Id=2,Nome="Reggae"},
                new Genero{Id=3,Nome="Rock Progressivo"},
                new Genero{Id=4,Nome="Punk Rock"},
                new Genero{Id=5,Nome="Clássica"}
            };

            // Imprimir em c#
            foreach (var genero in generos) // para cada genero uma lista de generos
            {
                if (genero.Nome.Contains("Rock"))
                {
                    Console.WriteLine("{0}\t{1}", genero.Id, genero.Nome);
                }
            }

            //Imprimir de forma similar a SQL
            //LINQ - Language Integrated Query ou Consulta Integrada a Linguagem(.NET, C#)
            var query = from g in generos // da tabela g busque em generos
                        where (g.Nome.Contains("Rock")) // onde contem Rock
                        select g; // seleciona
            Console.WriteLine(); // apenas para pular linha

            // apresenta
            foreach (var genero in query)
            {
                Console.WriteLine("{0}\t{1}", genero.Id, genero.Nome);
            }
            Console.ReadKey();
        }
    }
    class Genero
    {
        // atributos, getters and setters
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
