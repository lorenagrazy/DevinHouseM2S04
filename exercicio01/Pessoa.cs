namespace app
{
  public class Pessoa
  {
    public string nome;
    public int idade;
    public string endereco;

    public Pessoa(string nome, int idade, string endereco)
    {
      this.nome = nome;
      this.idade = idade;
      this.endereco = endereco;
    }

    public void saudacao()
    {
      Console.WriteLine("Olá, meu nome é {0}, tenho {1} anos e moro no endereço {2}.", nome, idade, endereco);
    }
  }
}
