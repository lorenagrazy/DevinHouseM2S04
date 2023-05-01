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
            ContaBancaria conta1 = new ContaBancaria(1234);

            // fazer deposito
            conta1.deposita(100);

            // fazer um saque 
            conta1.saca(50);

            // Verificar saldo disponível
            Console.WriteLine($"Saldo disponível da conta {conta1.getNumeroConta()}: R$ {conta1.getSaldo()}");
        }
    }
}