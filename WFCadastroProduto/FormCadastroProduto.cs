﻿using System;
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
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (mtbCodigo.Text == "")
            {
                MessageBox.Show("Código não informado");
                return;
            }

            foreach (Produto codigo in Produto.ListaProdutos)
            {
                if (codigo.Codigo == Convert.ToInt32(mtbCodigo.Text)) ;
                {
                    MessageBox.Show("Produto ja cadastrado com esse código");
                    mtbCodigo.Text = "";
                    return;
                }
            }

            if (txtNomeProduto.Text == "")
            {
                MessageBox.Show("Nome não informado");
                return;
            }
            if (cbxCategoria.Text == "")
            {
                MessageBox.Show("Categoria não informada");
                return;
            }
            if (txtPreco.Text == "")
            {
                MessageBox.Show("Valor não informado");
                return;
            }
            if (dtpDataVencimento.Value == DateTime.Today)
            {
                MessageBox.Show("Data de vencimento não informada");
                return;
            }


            Produto Produtos = new Produto();
            Produtos.Codigo = Convert.ToInt32(mtbCodigo.Text);
            Produtos.Nome = txtNomeProduto.Text;
            Produtos.Categoria = cbxCategoria.Text;
            Produtos.Preco = Convert.ToDouble(txtPreco.Text);
            Produtos.DataVencimento = Convert.ToDateTime(dtpDataVencimento.Text);
            Produtos.Observacoes = txtObservacoes.Text;
            Produto.ListaProdutos.Add(Produtos);


            mtbCodigo.Text = "";
            txtNomeProduto.Text = "";
            cbxCategoria.Text = "";
            txtPreco.Text = "";
            txtObservacoes.Text = "";
            dtpDataVencimento.Value = DateTime.Today;

            MessageBox.Show("Produto Cadastrado com sucesso", "Cadastro Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            dtpDataVencimento.Value = DateTime.Today;
        }
    }
}
