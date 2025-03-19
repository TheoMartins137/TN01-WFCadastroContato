namespace WFCadastroProduto
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAcessar = new Button();
            lblLogin = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            bkbMostrarSenha = new CheckBox();
            SuspendLayout();
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(37, 147);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(100, 23);
            btnAcessar.TabIndex = 3;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(37, 18);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(37, 36);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(37, 89);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 2;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(37, 71);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // bkbMostrarSenha
            // 
            bkbMostrarSenha.AutoSize = true;
            bkbMostrarSenha.Location = new Point(37, 122);
            bkbMostrarSenha.Name = "bkbMostrarSenha";
            bkbMostrarSenha.Size = new Size(107, 19);
            bkbMostrarSenha.TabIndex = 5;
            bkbMostrarSenha.Text = "Mostrar Senha?";
            bkbMostrarSenha.UseVisualStyleBackColor = true;
            bkbMostrarSenha.CheckedChanged += bkbMostrarSenha_CheckedChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(177, 200);
            Controls.Add(bkbMostrarSenha);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            Controls.Add(btnAcessar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcessar;
        private Label lblLogin;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label lblSenha;
        private CheckBox bkbMostrarSenha;
    }
}
