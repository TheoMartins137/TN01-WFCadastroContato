namespace WFCadastroProduto
{
    partial class FormCadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCodigo = new Label();
            txtNomeProduto = new TextBox();
            lblNomeProduto = new Label();
            lblPreco = new Label();
            lblDataVencimento = new Label();
            txtObservacoes = new TextBox();
            lblObservacoes = new Label();
            lblCategoria = new Label();
            cbxCategoria = new ComboBox();
            btnSalvar = new Button();
            dtpDataVencimento = new DateTimePicker();
            mtbCodigo = new MaskedTextBox();
            txtPreco = new TextBox();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 9);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(12, 90);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(272, 23);
            txtNomeProduto.TabIndex = 3;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(12, 72);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(103, 15);
            lblNomeProduto.TabIndex = 3;
            lblNomeProduto.Text = "Nome do Produto";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(12, 126);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 5;
            lblPreco.Text = "Preço";
            // 
            // lblDataVencimento
            // 
            lblDataVencimento.AutoSize = true;
            lblDataVencimento.Location = new Point(138, 127);
            lblDataVencimento.Name = "lblDataVencimento";
            lblDataVencimento.Size = new Size(113, 15);
            lblDataVencimento.TabIndex = 7;
            lblDataVencimento.Text = "Data de Vencimento";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(12, 200);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(272, 114);
            txtObservacoes.TabIndex = 6;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Location = new Point(12, 182);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(74, 15);
            lblObservacoes.TabIndex = 9;
            lblObservacoes.Text = "Observações";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(138, 9);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 11;
            lblCategoria.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Produtos de Limpeza", "Laticinios ", "Carnes e Aves", "Congelados", "Encartelados", "Padaria", "Liquidos", "Alcoolicos", "Petiscos", "Mercearia", "" });
            cbxCategoria.Location = new Point(138, 27);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(146, 23);
            cbxCategoria.TabIndex = 2;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 320);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(272, 23);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dtpDataVencimento
            // 
            dtpDataVencimento.Format = DateTimePickerFormat.Short;
            dtpDataVencimento.Location = new Point(138, 146);
            dtpDataVencimento.Name = "dtpDataVencimento";
            dtpDataVencimento.Size = new Size(146, 23);
            dtpDataVencimento.TabIndex = 5;
            // 
            // mtbCodigo
            // 
            mtbCodigo.Location = new Point(12, 27);
            mtbCodigo.Name = "mtbCodigo";
            mtbCodigo.Size = new Size(120, 23);
            mtbCodigo.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(15, 144);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "0,00";
            txtPreco.Size = new Size(117, 23);
            txtPreco.TabIndex = 4;
            // 
            // FormCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 353);
            Controls.Add(txtPreco);
            Controls.Add(mtbCodigo);
            Controls.Add(dtpDataVencimento);
            Controls.Add(btnSalvar);
            Controls.Add(cbxCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(txtObservacoes);
            Controls.Add(lblObservacoes);
            Controls.Add(lblDataVencimento);
            Controls.Add(lblPreco);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblNomeProduto);
            Controls.Add(lblCodigo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastroProduto";
            Load += FormCadastroProduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCodigo;
        private TextBox txtNomeProduto;
        private Label lblNomeProduto;
        private Label lblPreco;
        private Label lblDataVencimento;
        private TextBox txtObservacoes;
        private Label lblObservacoes;
        private Label lblCategoria;
        private ComboBox cbxCategoria;
        private Button btnSalvar;
        private DateTimePicker dtpDataVencimento;
        private MaskedTextBox mtbCodigo;
        private TextBox txtPreco;
    }
}