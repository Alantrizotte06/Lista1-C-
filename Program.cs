// ./Program.cs

Carro carro = new Carro();
carro.Marca = "Fiat";
carro.Modelo = "500";
carro.Ano = 2016;
Console.WriteLine(carro.Marca);
Console.WriteLine(carro.Modelo);
Console.WriteLine(carro.Ano);

Pessoa pessoa = new Pessoa();
pessoa.Nome = "José";
pessoa.Cpf = "999.999.999-99";

Livro livro1 = new Livro();
livro1.Titulo = "O teste";
livro1.Autor = "João Silva";
pessoa.adicionarLivros(livro1);

Livro livro2 = new Livro();
livro2.Titulo = "Codigo";
livro2.Autor = "Bruno Lima";
pessoa.adicionarLivros(livro2);

pessoa.imprimirInfo();