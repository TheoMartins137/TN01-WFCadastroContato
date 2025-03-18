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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario UserMain = new Usuario();
            UserMain.Login = "user";
            UserMain.Senha = "123456";
            UserMain.Codigo = 1000;
            UserMain.Data = Convert.ToDateTime("10/01/2025 18:30");
            Usuario.ListaUsuarios.Add(UserMain);
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {

            foreach (Usuario user in Usuario.ListaUsuarios)
            {
                if (user.Login == txtLoginMain.Text)
                {
                    if (user.Senha == txtSenhaMain.Text)
                    {
                        FormMain form = new FormMain();
                        form.ShowDialog();

                        this.txtLoginMain.Clear();
                        this.txtSenhaMain.Clear();
                        return;
                    }
                }
            }
            MessageBox.Show("Usuário não cadastrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
