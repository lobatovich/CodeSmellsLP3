using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmellRefactor
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public virtual void ImprimeInformacoes()
        {
            Console.WriteLine("Nome: {0}", this.Nome);
            Console.WriteLine("Idade: {0}", this.Idade);
            Console.WriteLine("Endereço: {0}", this.Endereco);
            Console.WriteLine("Telefone: {0}", this.Telefone);
            Console.WriteLine("E-mail: {0}", this.Email);
        }
    }
}
