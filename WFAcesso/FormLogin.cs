using System.DirectoryServices;

namespace WFAcesso
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            AdicionarLista();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {

            Usuario user1 = new Usuario();
            user1.Login = txt_usuario.Text;
            user1.Senha = txt_senha.Text;



            foreach (Usuario us in Usuario.ListaUsuarios)
            {
                if (us.Login == txt_usuario.Text)
                {
                    if (us.Senha == txt_senha.Text)
                    {
                        MessageBox.Show("Usuario Autenticado com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            MessageBox.Show("Usuario Não Autenticado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;


        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            AdicionarLista();

        }

        private void FormLogin_Load_1(object sender, EventArgs e)
        {

        }

        public void AdicionarLista()
        {
            Usuario us = new Usuario();
            us.Codigo = 1;
            us.Login = "admin";
            us.Senha = "admin";
            us.DataCadastro = Convert.ToDateTime("01/01/2000");
            //us.DataCadastro = DateTime.Parse("01/01/2000");
            Usuario.ListaUsuarios.Add(us);

            us = new Usuario();
            us.Codigo = 2;
            us.Login = "user";
            us.Senha = "user";
            us.DataCadastro = Convert.ToDateTime("01/01/2010");
            //us.DataCadastro = DateTime.Parse("01/01/2010");
            Usuario.ListaUsuarios.Add(us);
        }
        private void txt_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_senha.Focus();
            }
        }

        private void txt_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_logar_Click(sender, e);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt_senha.PasswordChar = '\0';
            }
            else
            {
                txt_senha.PasswordChar = '*';
            }
        }
    }


}
