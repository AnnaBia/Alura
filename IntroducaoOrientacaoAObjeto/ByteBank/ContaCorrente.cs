using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public string titular;
        public int agencia;
        public int numero;
        public double saldo = 100;

        public bool Sacar(double valor) // quando há retorno é comum chamar de função, mas pode ser chamado de método
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }
        public void Depositar(double valor) // quando for tipo void é método
        {
            saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente contaDestino) // contaDestino pega os atributos da ContaCorrente
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                contaDestino.Depositar(valor); // contaDestino.saldo += valor; 
                return true;
            }
        }
    }
}
