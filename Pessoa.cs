using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escola
{
    public class Pessoa
    {
       
        public DateTime DataNascimento {get ; set;}
        public string Telefone {get ; set;}
        public string Email {get ; set;}
        
        //Dot net cria essa Variavel privada para cada propriedade por debaixo dos panos (assim encapsulando ela);
        private string _nome; 
        //Simulação do que o dot net faz por baixo dos panos quando usamos a propriedade   
        //public string Nome {get ; set;}
        public string Nome { get { return _nome; }  set {_nome = value;} }

        //Construtor
        public Pessoa(){
            Nome = "Não Definido";
            Telefone= "Não Definido";
            DataNascimento = new DateTime(2000,1,1);
        }
        public Pessoa(string nome){
            Nome = nome;
        }
        public Pessoa(string nome, string email){
            Nome = nome;
            Email = email;
        }


        //Métodos 
        public string ObterNome(){
            return Nome;
        }

        //Métodos exemplo para encapsulamento rudmentar.
        public string GetNome(){
            return _nome;
        }
        public void SetNome(string value){
            _nome = value;
        }
    }
}