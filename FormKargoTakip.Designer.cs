namespace Kargo_Dağıtım_Sistemi
{
    partial class FormKargoTakip
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKargolar = new System.Windows.Forms.DataGridView();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarkodAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnKargoSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKargolar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "KARGO TAKİP/DURUM GÜNCELLEME";
            // 
            // dgvKargolar
            // 
            this.dgvKargolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKargolar.Location = new System.Drawing.Point(12, 144);
            this.dgvKargolar.Name = "dgvKargolar";
            this.dgvKargolar.RowHeadersWidth = 51;
            this.dgvKargolar.RowTemplate.Height = 24;
            this.dgvKargolar.Size = new System.Drawing.Size(1036, 385);
            this.dgvKargolar.TabIndex = 1;
           
            // 
            // btnDurumGuncelle
            // 
            this.btnDurumGuncelle.BackColor = System.Drawing.Color.IndianRed;
            this.btnDurumGuncelle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurumGuncelle.Location = new System.Drawing.Point(700, 546);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(201, 60);
            this.btnDurumGuncelle.TabIndex = 2;
            this.btnDurumGuncelle.Text = "Durumu Güncelle";
            this.btnDurumGuncelle.UseVisualStyleBackColor = false;
            this.btnDurumGuncelle.Click += new System.EventHandler(this.btnDurumGuncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Barkod No Ara :";
            // 
            // txtBarkodAra
            // 
            this.txtBarkodAra.Location = new System.Drawing.Point(217, 95);
            this.txtBarkodAra.Name = "txtBarkodAra";
            this.txtBarkodAra.Size = new System.Drawing.Size(152, 22);
            this.txtBarkodAra.TabIndex = 4;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.LightCoral;
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(418, 89);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(92, 37);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnKargoSil
            // 
            this.btnKargoSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnKargoSil.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKargoSil.Location = new System.Drawing.Point(101, 552);
            this.btnKargoSil.Name = "btnKargoSil";
            this.btnKargoSil.Size = new System.Drawing.Size(144, 54);
            this.btnKargoSil.TabIndex = 6;
            this.btnKargoSil.Text = "Kargo Sil";
            this.btnKargoSil.UseVisualStyleBackColor = false;
            this.btnKargoSil.Click += new System.EventHandler(this.btnKargoSil_Click);
            // 
            // FormKargoTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1069, 628);
            this.Controls.Add(this.btnKargoSil);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtBarkodAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDurumGuncelle);
            this.Controls.Add(this.dgvKargolar);
            this.Controls.Add(this.label1);
            this.Name = "FormKargoTakip";
            this.Text = "FormKargoTakip";
            this.Load += new System.EventHandler(this.FormKargoTakip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKargolar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKargolar;
        private System.Windows.Forms.Button btnDurumGuncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarkodAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnKargoSil;
    }
}