namespace TN01_CadastroContato
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void mnu_cadastrar_Click(object sender, EventArgs e)
        {
            Cadastro form = new Cadastro();
            form.ShowDialog();
        }

        private void mnu_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
