using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CodeSmellRefactor
{
    public class Aluno : Pessoa
    {
        public string Curso { get; set; }
        public Aluno(string nome, int idade, string endereco, string telefone, string email, string curso):
        base(nome, idade, endereco, telefone, email)
        {
            this.Curso = curso;
        }

        public override void ImprimeInformacoes()
        {
            base.ImprimeInformacoes();
            Console.WriteLine("Curso: {0}", this.Curso);
        }
    }
}
