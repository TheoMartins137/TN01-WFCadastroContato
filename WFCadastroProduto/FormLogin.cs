namespace WFCadastroProduto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            foreach (Usuario user in Usuario.ListaUsuarios)
            {
                if (user.Login == txtLogin.Text)
                {
                    if (user.Senha == txtSenha.Text)
                    {
                        FormMenu form = new FormMenu();
                        form.ShowDialog();

                        this.txtLogin.Clear();
                        this.txtSenha.Clear();
                        return;
                    }
                }
            }
            MessageBox.Show("Usuário não cadastrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.txtLogin.Clear();
            this.txtSenha.Clear();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario UserMain = new Usuario();
            UserMain.Login = "admin";
            UserMain.Senha = "123456";
            UserMain.Codigo = 001;
            UserMain.DtCadastro = Convert.ToDateTime("18/03/2025 18:30");
            Usuario.ListaUsuarios.Add(UserMain);
        }

        private void bkbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (bkbMostrarSenha.Checked == true)
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
