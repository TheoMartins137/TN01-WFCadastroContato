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

        private void limpar()
        {
            txt_nome.Clear();
            txt_sobrenome.Clear();
            txt_email.Clear();
            mkt_ddd.Clear();
            rdb_pessoal.Checked = false;
            rdb_comercial.Checked = false;
            rdb_recado.Checked = false;
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


            ETipoTelefone tipoTelefone;

            if (rdb_pessoal.Checked)
            {
                tipoTelefone = ETipoTelefone.Pessoal;
            }
            else if (rdb_comercial.Checked)
            {
                tipoTelefone = ETipoTelefone.Comercial;
            }
            else if (rdb_recado.Checked)
            {
                tipoTelefone = ETipoTelefone.Recado;            }
            else
            {
                MessageBox.Show("Tipo de telefone não selecionado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string semmascara = mkt_ddd.Text;

            Contato c1 = new Contato();
            c1.codigo = 0;
            c1.nome = txt_nome.Text;
            c1.email = txt_email.Text;
            c1.sobrenome = txt_sobrenome.Text;
            c1.tipoTelefone = tipoTelefone;
            c1.ddd = semmascara.Substring(0, 2);
            c1.telefone = semmascara.Substring(2);

            Contato.ListaContatos.Add(c1);

            MessageBox.Show("Cadastrado com Sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar();
        }
    }
}
