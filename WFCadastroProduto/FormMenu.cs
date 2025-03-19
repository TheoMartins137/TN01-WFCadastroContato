using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCadastroProduto
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuListar_Click(object sender, EventArgs e)
        {
            FormListaProduto form = new FormListaProduto();
            form.ShowDialog();
        }

        private void mnuCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroProduto form = new FormCadastroProduto();
            form.ShowDialog();
        }

        private void mnuCadastrar_Click_1(object sender, EventArgs e)
        {
            FormCadastroProduto form = new FormCadastroProduto();
            form.ShowDialog();
        }

        private void mnuListar_Click_1(object sender, EventArgs e)
        {
            FormListaProduto form = new FormListaProduto();
            form.ShowDialog();
        }

        private void mnuSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
