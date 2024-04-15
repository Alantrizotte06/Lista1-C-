// ./Pessoa.cs
using System;
using System.Collections.Generic;
public class Pessoa
{
  public string Cpf { get; set; }
  public string Nome { get; set; }
  public List<Livro> Livros = new List<Livro>();

  public string exibirInformacoes()
  {
    return "";
  }

  public void adicionarLivros(Livro Livro)
  {
    this.Livros.Add(Livro);
  }

  public List<Livro> pegarLivro()
  {
    return this.Livros;
  }

  public void imprimirInfo()
  {
    Console.WriteLine("Nome: " + Nome);
    Console.WriteLine("CPF: " + Cpf);

    foreach (Livro livro in Livros)
    {
      Console.WriteLine("\nTitulo: " + livro.Titulo);
      Console.WriteLine("Autor: " + livro.Autor);
    }
  }
}