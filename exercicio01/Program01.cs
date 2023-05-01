using System;
using app;

class Program01
{
  static void Main(string[] args)
  {
    Pessoa pessoa1 = new Pessoa("João", 30, "Rua A, 123");
    pessoa1.saudacao();

    PessoaFilha pessoa2 = new PessoaFilha("Maria", 10, "Rua B, 456", "Escola X");
    pessoa2.saudacao();
    pessoa2.infoEscola();
  }
}
