using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFUsandoListagem
{
    public class Usuario
    {
        public Usuario(string? login, string? senha, int? codigo, DateTime data)
        {
            Login = login;
            Senha = senha;
            Codigo = codigo;
            Data = data;
        }
        
        public Usuario() { }

        public string? Login { get; set; }
        public string? Senha { get; set; }
        public int? Codigo { get; set; }
        public DateTime Data { get; set; }

        public static List<Usuario> ListaUsuarios = new List<Usuario>();
    }
}
