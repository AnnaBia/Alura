using System;

namespace ExEndereco
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa guilherme = new Pessoa();
            guilherme.nome = "Guilherme";
            guilherme.endereco.logradouro = "Avenida XYZ";
            guilherme.endereco.numero = 123;

            Console.WriteLine("Nome: {0}\nEnd: {1} nº {2}",guilherme.nome,guilherme.endereco.logradouro, guilherme.endereco.numero);
            Console.ReadKey();
        }
    }
}
