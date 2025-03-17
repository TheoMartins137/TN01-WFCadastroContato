namespace WFUsandoListagem
{
    partial class FormListagem
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
            dgvListagem = new DataGridView();
            lblListagem = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListagem).BeginInit();
            SuspendLayout();
            // 
            // dgvListagem
            // 
            dgvListagem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListagem.Location = new Point(12, 33);
            dgvListagem.Name = "dgvListagem";
            dgvListagem.Size = new Size(762, 162);
            dgvListagem.TabIndex = 0;
            // 
            // lblListagem
            // 
            lblListagem.AutoSize = true;
            lblListagem.Location = new Point(315, 9);
            lblListagem.Name = "lblListagem";
            lblListagem.Size = new Size(119, 15);
            lblListagem.TabIndex = 1;
            lblListagem.Text = "Listagem de Usuários";
            // 
            // FormListagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 207);
            Controls.Add(lblListagem);
            Controls.Add(dgvListagem);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormListagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormListagem";
            Load += FormListagem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListagem;
        private Label lblListagem;
    }
}