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
            // PARTE 01
            
            // propriedade
            // pertence ao tipo e não a uma instância
            // serve como a "raiz", sempre fica na memória

            // Modificador de acesso

            // Quando é static, ele pertence a classe e não pertence ao objeto

            // Matematica matematica1 = new Matematica();

            // // int resultadoSoma2 = matematica1.Soma(100, 50);

            // int resultadoSoma = Matematica.Soma(100, 23);

            // Console.WriteLine($"O resultado da soma é: {resultadoSoma}");


            // PARTE 02

            // Contador c1 = new Contador(); // instancia objeto 01
            // Contador c2 = new Contador(); // instancia objeto 02
            // Contador c3 = new Contador(); // instancia objeto 02
            // Contador c4 = new Contador(); // instancia objeto 02
            // Contador c5 = new Contador(); // instancia objeto 02

            // // int Total = Contador.Total;

            // // Console.WriteLine($"Total: {Total}");

            // // PARTE 03

            // // Modificar acesso static para Classes
            //      // Ao definir uma classe como static, não tem a necessidade de criar instâncias dessa classe
            //      // Não pode ser instanciada, uma classe estática
            //      // Declara uma classe como estática, todos os membros da classe devem ser também estáticos

            // int resultadoSoma = Calculadora.Soma(10, 5);
            // int resultadoSubtracao = Calculadora.Subtracao(10, 5);

            // Console.WriteLine($"O resultado de soma é {resultadoSoma}, e da subtração é: {resultadoSubtracao}");

            // // Não é possíve devido a classe Calculadora se ESTATICA
            // // Calculadora cal1 = new Calculadora();

            // // Não permite HERANÇA

            // CalculadoraCientifica cc = new CalculadoraCientifica();

            // CalculadoraCientifica.imprimir();

            Cliente cliente = new Cliente("João Silva", "123.456.789-00");

            ContaBancaria conta = new ContaBancaria(123, cliente, new Banco());

            Console.WriteLine("Dados da conta: ");
            conta.ExibirDados();
            Console.WriteLine();

            Console.WriteLine("Depósito de R$1000.00");
            conta.Depositar(1000);
            Console.WriteLine(conta.ToString());
            Console.WriteLine();

            Console.WriteLine("Saque de R$500.00");
            conta.Sacar(500);
            Console.WriteLine(conta.ToString());
            Console.WriteLine();
        }
    }
}