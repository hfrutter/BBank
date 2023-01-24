using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string? conta_corrente;
        public string? titular;
        public double saldo;


        public void Depositar(double valor)
        {
            this.saldo += valor;
            Console.WriteLine("O valor: R$" + valor + " foi depositado com sucesso a sua conta!");
            Console.WriteLine("Saldo atual: R$" + this.saldo);
            Console.WriteLine("======================");

        }

        public bool Sacar(double valor) 
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                Console.WriteLine("O saque no valor de: R$" + valor + " foi sacado com sucesso, aguarde a liberação das notas. O saldo atual é de: R$" + this.saldo);
                Console.WriteLine("======================");
                return true;
                
            }
            else
            {
                Console.WriteLine("O valor de saque é superior ao saldo que se possui na conta, você não tem saldo para completar essa transação.");
                Console.WriteLine("======================");
                return false;
            }

        }

        public bool Transferir(double valor, ContaCorrente destino) 
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                Console.WriteLine(this.titular + " transferiu: R$ " + valor + " para: " + destino.titular + ". O Saldo restante é de: R$ " + this.saldo);
                Console.WriteLine("======================");
                return true;
            }
        }
    }
}
