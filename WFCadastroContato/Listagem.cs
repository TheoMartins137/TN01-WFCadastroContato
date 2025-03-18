using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCadastroContato
{
    public partial class Listagem : Form
    {
        public Listagem()
        {
            InitializeComponent();
        }

        private void Listagem_Load(object sender, EventArgs e)
        {
            dgv_listacontatos.DataSource = Contato.ListaContatos;
        }
    }
}
