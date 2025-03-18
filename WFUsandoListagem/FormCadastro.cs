using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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

            if(string.IsNullOrEmpty(txtLogin.Text))
            {
                MessageBox.Show("Login não pode estar vázio", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Senha não pode estar vázio", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (txtConfirmSenha.Text == txtSenha.Text)
            {
                codigo = codigo + 1;
                Usuario.ListaUsuarios.Add(usuario);
                MessageBox.Show("Cadastrado com sucesso");

                this.txtLogin.Clear();
                this.txtSenha.Clear();
                this.txtConfirmSenha.Clear();
            }
            else
            {
                MessageBox.Show("Senhas incompativeis. Tente novamente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSenha.Clear();
                this.txtConfirmSenha.Clear();
            }
        }

        private void ckbSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSenha.Checked == true)
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }
    }
}
