using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFUsandoListagem
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int codigo = 1;

            Usuario usuario = new Usuario();
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Data = DateTime.Now;
            usuario.Codigo = codigo;
            if (txtConfirmSenha.Text == txtSenha.Text)
            {
                codigo = codigo + 1;
                Usuario.ListaUsuarios.Add(usuario);
                MessageBox.Show("Cadastrado com sucesso");

            }
            else
            {
                MessageBox.Show("Senhas incompativeis. Tente novamente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
