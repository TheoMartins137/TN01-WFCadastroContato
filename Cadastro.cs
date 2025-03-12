using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01_CadastroContato
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Pessoa p1 = new Pessoa();

            if(txt_nome.Text == "")
            {
                MessageBox.Show("Nome não Informado");
                return;
            }
            else
            {
                p1.nome = txt_nome.Text;
            }


            if(txt_sobrenome.Text == "")
            {
                MessageBox.Show("Sobrenome não informado");
                return;
            }
            else
            {
                p1.sobrenome = txt_sobrenome.Text;
            }


            if(mkt_ddd.Text == "")
            {
                MessageBox.Show("Número não informado");
                return;
            }
            else
            {
                p1.telefone = mkt_ddd.Text;
            }


            if (txt_email.Text == "")
            {
                MessageBox.Show("Email não informado");
                return;
            }
            else
            {
                p1.email = txt_email.Text;
            }




            if (rdb_pessoal.Checked)
            {
                p1.tipotelefone = "Pessoal";
            }
            else if (rdb_comercial.Checked)
            {
                p1.tipotelefone = "Comercial";
            }
            else if (rdb_recado.Checked)
            {
                p1.tipotelefone = "Recado";
            }
            else
            {
                MessageBox.Show("Tipo de telefone não selecionado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Nome: {p1.nome}\n Sobrenome: {p1.sobrenome}\n Telefone: {p1.telefone}\n Tipo de Telefone: {p1.tipotelefone}\n Email {p1.email}", "Cadastro Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
