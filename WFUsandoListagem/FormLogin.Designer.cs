namespace WFUsandoListagem
{
    partial class FormLogin
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
            btnAcessarMain = new Button();
            lblLoginMain = new Label();
            txtLoginMain = new TextBox();
            txtSenhaMain = new TextBox();
            lblSenhaMain = new Label();
            SuspendLayout();
            // 
            // btnAcessarMain
            // 
            btnAcessarMain.Location = new Point(46, 121);
            btnAcessarMain.Name = "btnAcessarMain";
            btnAcessarMain.Size = new Size(100, 23);
            btnAcessarMain.TabIndex = 3;
            btnAcessarMain.Text = "Acessar";
            btnAcessarMain.UseVisualStyleBackColor = true;
            btnAcessarMain.Click += btnAcessar_Click;
            // 
            // lblLoginMain
            // 
            lblLoginMain.AutoSize = true;
            lblLoginMain.Location = new Point(48, 25);
            lblLoginMain.Name = "lblLoginMain";
            lblLoginMain.Size = new Size(37, 15);
            lblLoginMain.TabIndex = 1;
            lblLoginMain.Text = "Login";
            lblLoginMain.Click += lblLogin_Click;
            // 
            // txtLoginMain
            // 
            txtLoginMain.Location = new Point(46, 43);
            txtLoginMain.Name = "txtLoginMain";
            txtLoginMain.Size = new Size(100, 23);
            txtLoginMain.TabIndex = 1;
            // 
            // txtSenhaMain
            // 
            txtSenhaMain.Location = new Point(46, 92);
            txtSenhaMain.Name = "txtSenhaMain";
            txtSenhaMain.PasswordChar = '*';
            txtSenhaMain.Size = new Size(100, 23);
            txtSenhaMain.TabIndex = 2;
            // 
            // lblSenhaMain
            // 
            lblSenhaMain.AutoSize = true;
            lblSenhaMain.Location = new Point(46, 74);
            lblSenhaMain.Name = "lblSenhaMain";
            lblSenhaMain.Size = new Size(39, 15);
            lblSenhaMain.TabIndex = 3;
            lblSenhaMain.Text = "Senha";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(194, 176);
            Controls.Add(txtSenhaMain);
            Controls.Add(lblSenhaMain);
            Controls.Add(txtLoginMain);
            Controls.Add(lblLoginMain);
            Controls.Add(btnAcessarMain);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcessarMain;
        private Label lblLoginMain;
        private TextBox txtLoginMain;
        private TextBox txtSenhaMain;
        private Label lblSenhaMain;
    }
}