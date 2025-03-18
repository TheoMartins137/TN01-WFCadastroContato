namespace WFCadastroContato
{
    partial class Listagem
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
            dgv_listacontatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_listacontatos).BeginInit();
            SuspendLayout();
            // 
            // dgv_listacontatos
            // 
            dgv_listacontatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listacontatos.Location = new Point(12, 12);
            dgv_listacontatos.Name = "dgv_listacontatos";
            dgv_listacontatos.Size = new Size(536, 157);
            dgv_listacontatos.TabIndex = 0;
            // 
            // Listagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 181);
            Controls.Add(dgv_listacontatos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Listagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listagem de Contatos";
            Load += Listagem_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listacontatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_listacontatos;
    }
}