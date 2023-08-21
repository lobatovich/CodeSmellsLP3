using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmellRefactor
{
    public class Aluno : Pessoa
    {
        public string Curso { get; set; }

        public Aluno(string nome, int idade, string endereco, string telefone, string email, string curso)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
            this.Curso = curso;
        }

        public override void ImprimeInformacoes()
        {
            //base.ImprimeInformacoes();
            Console.WriteLine("Nome: {0}", this.Nome);
            Console.WriteLine("Idade: {0}", this.Idade);
            Console.WriteLine("Endereço: {0}", this.Endereco);
            Console.WriteLine("Telefone: {0}", this.Telefone);
            Console.WriteLine("E-mail: {0}", this.Email);
            Console.WriteLine("Curso: {0}", this.Curso);
        }
    }
}
