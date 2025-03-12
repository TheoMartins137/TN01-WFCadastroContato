namespace TN01_CadastroContato
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new MenuStrip();
            mnu_cadastrar = new ToolStripMenuItem();
            mnu_sobre = new ToolStripMenuItem();
            mnu_sair = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnu_cadastrar, mnu_sobre, mnu_sair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(416, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnu_cadastrar
            // 
            mnu_cadastrar.Name = "mnu_cadastrar";
            mnu_cadastrar.Size = new Size(69, 20);
            mnu_cadastrar.Text = "Cadastrar";
            mnu_cadastrar.Click += mnu_cadastrar_Click;
            // 
            // mnu_sobre
            // 
            mnu_sobre.Name = "mnu_sobre";
            mnu_sobre.Size = new Size(49, 20);
            mnu_sobre.Text = "Sobre";
            // 
            // mnu_sair
            // 
            mnu_sair.Name = "mnu_sair";
            mnu_sair.Size = new Size(38, 20);
            mnu_sair.Text = "Sair";
            mnu_sair.Click += mnu_sair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(416, 332);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 356);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Name = "Main";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnu_cadastrar;
        private ToolStripMenuItem mnu_sobre;
        private ToolStripMenuItem mnu_sair;
        private PictureBox pictureBox1;
    }
}
