using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastroContato
{
    //public enum ETipoTelefone
    //{
    //    Pessoal = 1,
    //    Comercial,
    //    Recado
    //}
    
    
    public class Contato
    {
        public Contato(int codigo, string? nome, string? sobrenome, string? telefone, string? ddd, ETipoTelefone tipoTelefone, string? email)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.telefone = telefone;
            this.ddd = ddd;
            this.tipoTelefone = tipoTelefone;
            this.email = email;
        }

        public Contato() { }

        public static List<Contato> ListaContatos = new List<Contato>();

        public int codigo { get; set; }
        public string? nome { get; set; }
        public string? sobrenome { get; set; }
        public string? telefone { get; set; }
        public string? ddd { get; set; }
        public ETipoTelefone tipoTelefone { get; set; }
        public string? email { get; set; }

    }
}
