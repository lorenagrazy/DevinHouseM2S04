using System;
using app;

namespace app
{
  public class PessoaFilha : Pessoa
  {
    private string escola;

    public PessoaFilha(string nome, int idade, string endereco, string escola) : base(nome, idade, endereco)
    {
      this.escola = escola;
    }

    public void infoEscola()
    {
      Console.WriteLine("Eu estudo na escola {0}.", escola);
    }
  }
}
