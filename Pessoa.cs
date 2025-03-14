using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN01_CadastroContato
{
    public enum ETipoTelefone
    {
        Pessoal = 1,
        Comercial,
        Recado
    }
    public class Pessoa
    {

        public Pessoa(string? nome, string? sobrenome, string? telefone, ETipoTelefone tipotelefone, string? email)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.telefone = telefone;
            this.tipotelefone = tipotelefone;
            this.email = email;
        }

        public Pessoa()
        {

        }

        public string? nome { get; set; }
        public string? sobrenome { get; set; }
        public string? telefone { get; set; }
        public ETipoTelefone tipotelefone { get; set; }
        public string? email { get; set; }
    }
}
