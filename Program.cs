using Escola;

// string ObterNome(){
//   Console.WriteLine("Qual seu nome? ");
//   return Console.ReadLine();
// }

// void ImprimirNome(string nome){
//   Console.WriteLine(nome);
//   return;
// }

// string nome2 = ObterNome();
// ImprimirNome(nome2);

// string nome = ObterNome();
// ImprimirNome(nome);

// string nome3 = ObterNome();
// ImprimirNome(nome3);

Pessoa luciano = new Pessoa("Luciano");
luciano.Email = "Luciano@email";
luciano.Telefone = "123";
luciano.DataNascimento = new DateTime(2000,1,1);

Console.WriteLine(luciano.ObterNome());


Escola.Pessoa pessoa = new Escola.Pessoa();
//Chamando o Set da  propriedade Nome  que encapsulou automaticamente o _nome
pessoa.Nome = "Ana";

//Chamando manualmente o método set que encapsula a variavel _nome 
pessoa.SetNome("Ana");

//Chamando o Get da  propriedade Nome  que encapsulou automaticamente o _nome
Console.WriteLine(pessoa.Nome);

//Chamando manualmente o método Get que encapsula a variavel _nome 
Console.WriteLine(pessoa.GetNome());



Escola.Pessoa pessoa2 = new Escola.Pessoa("Marcos","marcos@email");
pessoa2.Telefone= "5689";