namespace TN01_CadastroContato
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            lbl_nome = new Label();
            txt_nome = new TextBox();
            txt_sobrenome = new TextBox();
            lbl_sobrenome = new Label();
            label1 = new Label();
            lbl_ddd = new Label();
            mkt_ddd = new MaskedTextBox();
            gbx_tipotele = new GroupBox();
            rdb_recado = new RadioButton();
            rdb_pessoal = new RadioButton();
            rdb_comercial = new RadioButton();
            label2 = new Label();
            txt_email = new TextBox();
            lbl_email = new Label();
            btn_voltar = new Button();
            btn_salvar = new Button();
            gbx_tipotele.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(22, 9);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(43, 15);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Nome:";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(22, 27);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(165, 23);
            txt_nome.TabIndex = 1;
            // 
            // txt_sobrenome
            // 
            txt_sobrenome.Location = new Point(220, 27);
            txt_sobrenome.Name = "txt_sobrenome";
            txt_sobrenome.Size = new Size(180, 23);
            txt_sobrenome.TabIndex = 3;
            // 
            // lbl_sobrenome
            // 
            lbl_sobrenome.AutoSize = true;
            lbl_sobrenome.Location = new Point(220, 9);
            lbl_sobrenome.Name = "lbl_sobrenome";
            lbl_sobrenome.Size = new Size(71, 15);
            lbl_sobrenome.TabIndex = 2;
            lbl_sobrenome.Text = "Sobrenome:";
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(22, 53);
            label1.Name = "label1";
            label1.Size = new Size(378, 10);
            label1.TabIndex = 4;
            // 
            // lbl_ddd
            // 
            lbl_ddd.AutoSize = true;
            lbl_ddd.Location = new Point(22, 79);
            lbl_ddd.Name = "lbl_ddd";
            lbl_ddd.Size = new Size(83, 15);
            lbl_ddd.TabIndex = 5;
            lbl_ddd.Text = "DDD/Telefone:";
            // 
            // mkt_ddd
            // 
            mkt_ddd.Location = new Point(22, 97);
            mkt_ddd.Mask = "(00) 00000-0000";
            mkt_ddd.Name = "mkt_ddd";
            mkt_ddd.Size = new Size(100, 23);
            mkt_ddd.TabIndex = 6;
            mkt_ddd.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // gbx_tipotele
            // 
            gbx_tipotele.Controls.Add(rdb_recado);
            gbx_tipotele.Controls.Add(rdb_pessoal);
            gbx_tipotele.Controls.Add(rdb_comercial);
            gbx_tipotele.Location = new Point(161, 79);
            gbx_tipotele.Name = "gbx_tipotele";
            gbx_tipotele.Size = new Size(239, 41);
            gbx_tipotele.TabIndex = 7;
            gbx_tipotele.TabStop = false;
            gbx_tipotele.Text = "Tipo Telefone";
            // 
            // rdb_recado
            // 
            rdb_recado.AutoSize = true;
            rdb_recado.Location = new Point(161, 19);
            rdb_recado.Name = "rdb_recado";
            rdb_recado.Size = new Size(64, 19);
            rdb_recado.TabIndex = 12;
            rdb_recado.TabStop = true;
            rdb_recado.Text = "Recado";
            rdb_recado.UseVisualStyleBackColor = true;
            // 
            // rdb_pessoal
            // 
            rdb_pessoal.AutoSize = true;
            rdb_pessoal.Location = new Point(6, 19);
            rdb_pessoal.Name = "rdb_pessoal";
            rdb_pessoal.Size = new Size(64, 19);
            rdb_pessoal.TabIndex = 10;
            rdb_pessoal.TabStop = true;
            rdb_pessoal.Text = "Pessoal";
            rdb_pessoal.UseVisualStyleBackColor = true;
            // 
            // rdb_comercial
            // 
            rdb_comercial.AutoSize = true;
            rdb_comercial.Location = new Point(76, 19);
            rdb_comercial.Name = "rdb_comercial";
            rdb_comercial.Size = new Size(79, 19);
            rdb_comercial.TabIndex = 11;
            rdb_comercial.TabStop = true;
            rdb_comercial.Text = "Comercial";
            rdb_comercial.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(22, 123);
            label2.Name = "label2";
            label2.Size = new Size(378, 10);
            label2.TabIndex = 8;
            label2.Click += label2_Click;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(22, 163);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(378, 23);
            txt_email.TabIndex = 9;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(22, 145);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(39, 15);
            lbl_email.TabIndex = 10;
            lbl_email.Text = "Email:";
            // 
            // btn_voltar
            // 
            btn_voltar.Image = (Image)resources.GetObject("btn_voltar.Image");
            btn_voltar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_voltar.Location = new Point(237, 216);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(79, 33);
            btn_voltar.TabIndex = 11;
            btn_voltar.Text = "VOLTAR";
            btn_voltar.TextAlign = ContentAlignment.MiddleRight;
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Image = (Image)resources.GetObject("btn_salvar.Image");
            btn_salvar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salvar.Location = new Point(325, 216);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(75, 33);
            btn_salvar.TabIndex = 12;
            btn_salvar.Text = "Salvar";
            btn_salvar.TextAlign = ContentAlignment.MiddleRight;
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 278);
            Controls.Add(btn_salvar);
            Controls.Add(btn_voltar);
            Controls.Add(lbl_email);
            Controls.Add(txt_email);
            Controls.Add(label2);
            Controls.Add(gbx_tipotele);
            Controls.Add(mkt_ddd);
            Controls.Add(lbl_ddd);
            Controls.Add(label1);
            Controls.Add(txt_sobrenome);
            Controls.Add(lbl_sobrenome);
            Controls.Add(txt_nome);
            Controls.Add(lbl_nome);
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            gbx_tipotele.ResumeLayout(false);
            gbx_tipotele.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nome;
        private TextBox txt_nome;
        private TextBox txt_sobrenome;
        private Label lbl_sobrenome;
        private Label label1;
        private Label lbl_ddd;
        private MaskedTextBox mkt_ddd;
        private GroupBox gbx_tipotele;
        private RadioButton rdb_pessoal;
        private RadioButton rdb_comercial;
        private RadioButton rdb_recado;
        private Label label2;
        private TextBox txt_email;
        private Label lbl_email;
        private Button btn_voltar;
        private Button btn_salvar;
    }
}