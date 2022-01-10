using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFiltrandoComLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Atleta> atletas = new List<Atleta>()
            {
                new Atleta{ Posicao = 1, CodigoPais = "JAM", Nome = "BOLT Usain", Tempo = 9.81f },
                new Atleta{ Posicao = 2, CodigoPais = "USA", Nome = "GATLIN Justin", Tempo = 9.89f },
                new Atleta{ Posicao = 3, CodigoPais ="CAN", Nome = "DE GRASSE Andre", Tempo = 9.91f},
                new Atleta{ Posicao = 4, CodigoPais = "JAM", Nome = "BLAKE Yohan", Tempo = 9.93f},
                new Atleta{ Posicao = 5, CodigoPais = "RSA", Nome = "SIMBINE Akani", Tempo = 9.94f},
                new Atleta{ Posicao = 6, CodigoPais = "CIV", Nome = "MEITE Ben Youssef", Tempo = 9.96f},
                new Atleta{ Posicao = 7, CodigoPais = "FRA", Nome = "VICAUT Jimmy", Tempo = 10.04f},
                new Atleta{ Posicao = 8, CodigoPais = "USA", Nome = "BROMELL Trayvon", Tempo = 10.06f}
            };
            // outra solução
            // lista dos finalistas jamaicanos (CodigoPais = JAM) 
            //var query = from fj in atletas
            //            where (fj.CodigoPais.Contains("JAM"))
            //            select fj;

            var query = from fj in atletas
                        where fj.CodigoPais == "JAM"
                        select fj;

            Console.WriteLine("Pos\tCód\tNome\t\tTempo");
            foreach (var f in query)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", f.Posicao, f.CodigoPais, f.Nome, f.Tempo);
            }
            Console.ReadKey();
        }
    }
    public class Atleta
    {
        public int Posicao { get; set; }
        public string CodigoPais { get; set; }
        public string Nome { get; set; }
        public float Tempo { get; set; }
    }
}
