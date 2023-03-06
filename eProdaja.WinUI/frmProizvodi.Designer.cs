namespace eProdaja.WinUI
{
    partial class frmProizvodi
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
            dgvProizvodi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProizvodi).BeginInit();
            SuspendLayout();
            // 
            // dgvProizvodi
            // 
            dgvProizvodi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProizvodi.Location = new Point(20, 71);
            dgvProizvodi.Name = "dgvProizvodi";
            dgvProizvodi.RowTemplate.Height = 25;
            dgvProizvodi.Size = new Size(970, 532);
            dgvProizvodi.TabIndex = 1;
            // 
            // frmProizvodi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 651);
            Controls.Add(dgvProizvodi);
            Name = "frmProizvodi";
            Text = "Proizvodi";
            Load += frmProizvodi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProizvodi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPreuzmi;
        private DataGridView dgvProizvodi;
    }
}