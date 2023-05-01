using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class ContaBancaria
    {
        private int numeroConta;
        private double saldo;

        public ContaBancaria(int numeroConta, double saldo)
        {
            this.numeroConta = numeroConta;
            this.saldo = saldo;
        }

        public ContaBancaria(int numeroConta)
        {
            this.numeroConta = numeroConta;
        }

        public void deposita(double valor)
        {
            this.saldo += valor;
        }


        public void saca(double valor)
        {
            if (valor <= saldo)
            {
                this.saldo -= valor;
            } 
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public double getSaldo()
        {
            return saldo;
        }


        public double getNumeroConta()
        {
            return numeroConta;
        }
    }
}