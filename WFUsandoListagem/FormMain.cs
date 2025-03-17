namespace WFUsandoListagem
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void mnuCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro form = new FormCadastro();
            form.ShowDialog();

        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuListar_Click(object sender, EventArgs e)
        {
            FormListagem form = new FormListagem();
            form.ShowDialog();
        }
    }
}
