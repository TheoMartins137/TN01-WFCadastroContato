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
            button1 = new Button();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            txtNomeProduto = new TextBox();
            lblNomeProduto = new Label();
            lblPreco = new Label();
            lblDataVencimento = new Label();
            txtObservacoes = new TextBox();
            lblObservacoes = new Label();
            lblCategoria = new Label();
            cbxCategoria = new ComboBox();
            nudPreco = new NumericUpDown();
            mtxDataVencimento = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 365);
            button1.Name = "button1";
            button1.Size = new Size(301, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
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
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 27);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(120, 23);
            txtCodigo.TabIndex = 2;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(12, 90);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(302, 23);
            txtNomeProduto.TabIndex = 4;
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
            txtObservacoes.Size = new Size(302, 150);
            txtObservacoes.TabIndex = 10;
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
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(138, 27);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(176, 23);
            cbxCategoria.TabIndex = 12;
            // 
            // nudPreco
            // 
            nudPreco.Location = new Point(12, 146);
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(120, 23);
            nudPreco.TabIndex = 13;
            // 
            // mtxDataVencimento
            // 
            mtxDataVencimento.Location = new Point(138, 145);
            mtxDataVencimento.Name = "mtxDataVencimento";
            mtxDataVencimento.Size = new Size(176, 23);
            mtxDataVencimento.TabIndex = 14;
            // 
            // FormCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 411);
            Controls.Add(mtxDataVencimento);
            Controls.Add(nudPreco);
            Controls.Add(cbxCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(txtObservacoes);
            Controls.Add(lblObservacoes);
            Controls.Add(lblDataVencimento);
            Controls.Add(lblPreco);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblNomeProduto);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroProduto";
            Text = "FormCadastroProduto";
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private TextBox txtNomeProduto;
        private Label lblNomeProduto;
        private Label lblPreco;
        private Label lblDataVencimento;
        private TextBox txtObservacoes;
        private Label lblObservacoes;
        private Label lblCategoria;
        private ComboBox cbxCategoria;
        private NumericUpDown nudPreco;
        private MaskedTextBox mtxDataVencimento;
    }
}