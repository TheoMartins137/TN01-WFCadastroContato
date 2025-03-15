namespace WFAcesso
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
            lbl_usuario = new Label();
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            lbl_senha = new Label();
            btn_logar = new Button();
            SuspendLayout();
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(29, 30);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(50, 15);
            lbl_usuario.TabIndex = 0;
            lbl_usuario.Text = "Usuário:";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(29, 48);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(100, 23);
            txt_usuario.TabIndex = 1;
            txt_usuario.KeyDown += this.txt_usuario_KeyDown;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(29, 104);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(100, 23);
            txt_senha.TabIndex = 3;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Location = new Point(29, 86);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(42, 15);
            lbl_senha.TabIndex = 2;
            lbl_senha.Text = "Senha:";
            // 
            // btn_logar
            // 
            btn_logar.Location = new Point(29, 146);
            btn_logar.Name = "btn_logar";
            btn_logar.Size = new Size(100, 23);
            btn_logar.TabIndex = 4;
            btn_logar.Text = "Logar";
            btn_logar.UseVisualStyleBackColor = true;
            btn_logar.Click += btn_logar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(164, 200);
            Controls.Add(btn_logar);
            Controls.Add(txt_senha);
            Controls.Add(lbl_senha);
            Controls.Add(txt_usuario);
            Controls.Add(lbl_usuario);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FormLogin_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_usuario;
        private TextBox txt_usuario;
        private TextBox txt_senha;
        private Label lbl_senha;
        private Button btn_logar;
    }
}
