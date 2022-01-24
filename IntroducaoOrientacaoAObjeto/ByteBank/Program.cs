using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente pessoa1 = new Cliente();
            pessoa1.titular.titular = "Gabriela";
            pessoa1.cpf = "434.562.878-20";
            //pessoa1.profissao = "Desenvolvedora c#";
            pessoa1.titular.agencia = 863;
            pessoa1.titular.numero = 863452;

            Console.WriteLine("Dados titular\n{0}\nCpf: {1}\nProfissão: {2}", pessoa1.titular.titular, pessoa1.cpf, pessoa1.profissao);
            if (pessoa1.profissao == null)// null permite retornar uma mensagem de erro na ausencia de algum dado
            {
                Console.WriteLine("Campo profissão é NULL");
            }
            Console.WriteLine("\nDados conta\nAgência: {0}\nNúmero: {1}\nSaldo: R${2:f2}", pessoa1.titular.agencia, pessoa1.titular.numero, pessoa1.titular.saldo);

            pessoa1.titular.Depositar(200);
            Console.WriteLine("\nDepósito realizado com sucesso\nNovo saldo: R$ {0:f2}", pessoa1.titular.saldo);

            bool resSaque = pessoa1.titular.Sacar(150.0);
            Console.WriteLine("\nSaque {0}\nNovo saldo: R$ {1:f2}", resSaque, pessoa1.titular.saldo);

            Cliente pessoa2 = new Cliente();
            pessoa2.titular.titular = "Bruno";
            pessoa2.cpf = "435.573.889-30";
            pessoa2.profissao = "Desenvolvedor c#";
            pessoa2.titular.agencia = 863;
            pessoa2.titular.numero = 863473;

            Console.WriteLine("\nDados titular\n{0}\nCpf: {1}\nProfissão: {2}", pessoa2.titular.titular, pessoa2.cpf, pessoa2.profissao);
            Console.WriteLine("\nDados conta\nAgência: {0}\nNúmero: {1}\nSaldo: R${2:f2}", pessoa2.titular.agencia, pessoa2.titular.numero, pessoa2.titular.saldo);

            bool resTransferencia = pessoa1.titular.Transferir(50.0, pessoa2.titular);
            Console.WriteLine("\nTransferência {0}\nSaldo Gabriela: R$ {1:f2}\nSaldo Bruno: R$ {2:f2}", resTransferencia, pessoa1.titular.saldo, pessoa2.titular.saldo);
            Console.ReadKey();
        }
    }
}
