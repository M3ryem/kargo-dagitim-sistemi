namespace Kargo_Dağıtım_Sistemi
{
    partial class FormKargoListe
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
            this.dgvKargolar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHucreGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKargolar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKargolar
            // 
            this.dgvKargolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKargolar.Location = new System.Drawing.Point(7, 97);
            this.dgvKargolar.Name = "dgvKargolar";
            this.dgvKargolar.RowHeadersWidth = 51;
            this.dgvKargolar.RowTemplate.Height = 24;
            this.dgvKargolar.Size = new System.Drawing.Size(1224, 376);
            this.dgvKargolar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(485, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "KARGO LİSTESİ";
            // 
            // btnHucreGuncelle
            // 
            this.btnHucreGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHucreGuncelle.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHucreGuncelle.Location = new System.Drawing.Point(477, 510);
            this.btnHucreGuncelle.Name = "btnHucreGuncelle";
            this.btnHucreGuncelle.Size = new System.Drawing.Size(307, 71);
            this.btnHucreGuncelle.TabIndex = 2;
            this.btnHucreGuncelle.Text = "Seçili Hücreyi Güncelle";
            this.btnHucreGuncelle.UseVisualStyleBackColor = false;
            this.btnHucreGuncelle.Click += new System.EventHandler(this.btnHucreGuncelle_Click);
            // 
            // FormKargoListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1243, 633);
            this.Controls.Add(this.btnHucreGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKargolar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormKargoListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKargoListe";
            this.Load += new System.EventHandler(this.FormKargoListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKargolar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKargolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHucreGuncelle;
    }
}