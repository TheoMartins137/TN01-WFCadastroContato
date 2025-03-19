namespace WFCadastroProduto
{
    partial class FormMenu
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
            menuStrip1 = new MenuStrip();
            mnuCadastrar = new ToolStripMenuItem();
            mnuListar = new ToolStripMenuItem();
            mnuSair = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuCadastrar, mnuListar, mnuSair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(425, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuCadastrar
            // 
            mnuCadastrar.Name = "mnuCadastrar";
            mnuCadastrar.Size = new Size(69, 20);
            mnuCadastrar.Text = "Cadastrar";
            mnuCadastrar.Click += mnuCadastrar_Click_1;
            // 
            // mnuListar
            // 
            mnuListar.Name = "mnuListar";
            mnuListar.Size = new Size(47, 20);
            mnuListar.Text = "Listar";
            mnuListar.Click += mnuListar_Click_1;
            // 
            // mnuSair
            // 
            mnuSair.Name = "mnuSair";
            mnuSair.Size = new Size(38, 20);
            mnuSair.Text = "Sair";
            mnuSair.Click += mnuSair_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(425, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 312);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuCadastrar;
        private ToolStripMenuItem mnuListar;
        private ToolStripMenuItem mnuSair;
    }
}