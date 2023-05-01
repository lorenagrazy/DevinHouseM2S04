using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();

            // Depositar na conta
            conta.Depositar(1000);

            System.Console.WriteLine("Saldo após o depósito: " + conta.Saldo);

            // Tentar sacar o valor maior que o saldo disponível
            bool saque1 = conta.Sacar(2000);

            System.Console.WriteLine("Saque de R$ 2000.00" + (saque1 ? " realizado com sucesso!" : " não foi possível realizar o saque."));
    
            // Sacar valor menor que o saldo disponível

            bool saque2 = conta.Sacar(500);

            System.Console.WriteLine("Saque de R$ 500,00" + (saque2 ? " realizado com sucesso!" : " não foi possível realizar o saque."));


            System.Console.WriteLine("Saldo após os saques: " + conta.Saldo);
        }
    }
}