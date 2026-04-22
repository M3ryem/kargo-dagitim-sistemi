namespace Kargo_Dağıtım_Sistemi
{
    partial class FormAna
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
            this.btnKargoEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKargoTakip = new System.Windows.Forms.Button();
            this.btnSoforPaneli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKargoEkle
            // 
            this.btnKargoEkle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnKargoEkle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKargoEkle.Location = new System.Drawing.Point(283, 88);
            this.btnKargoEkle.Name = "btnKargoEkle";
            this.btnKargoEkle.Size = new System.Drawing.Size(166, 61);
            this.btnKargoEkle.TabIndex = 0;
            this.btnKargoEkle.Text = "➕ Kargo Ekle";
            this.btnKargoEkle.UseVisualStyleBackColor = false;
            this.btnKargoEkle.Click += new System.EventHandler(this.btnKargoEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(220, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "KARGO DAĞITIM SİSTEMİ";
            // 
            // btnKargoTakip
            // 
            this.btnKargoTakip.BackColor = System.Drawing.Color.DarkViolet;
            this.btnKargoTakip.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKargoTakip.Location = new System.Drawing.Point(243, 198);
            this.btnKargoTakip.Name = "btnKargoTakip";
            this.btnKargoTakip.Size = new System.Drawing.Size(259, 65);
            this.btnKargoTakip.TabIndex = 2;
            this.btnKargoTakip.Text = "📦 Kargo Takip / Durum Güncelle";
            this.btnKargoTakip.UseVisualStyleBackColor = false;
            this.btnKargoTakip.Click += new System.EventHandler(this.btnKargoTakip_Click);
            // 
            // btnSoforPaneli
            // 
            this.btnSoforPaneli.BackColor = System.Drawing.Color.Fuchsia;
            this.btnSoforPaneli.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoforPaneli.Location = new System.Drawing.Point(264, 312);
            this.btnSoforPaneli.Name = "btnSoforPaneli";
            this.btnSoforPaneli.Size = new System.Drawing.Size(211, 52);
            this.btnSoforPaneli.TabIndex = 3;
            this.btnSoforPaneli.Text = "Şoför/Dağıtıcı Paneli";
            this.btnSoforPaneli.UseVisualStyleBackColor = false;
            this.btnSoforPaneli.Click += new System.EventHandler(this.btnSoforPaneli_Click);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSoforPaneli);
            this.Controls.Add(this.btnKargoTakip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKargoEkle);
            this.Name = "FormAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKargoEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKargoTakip;
        private System.Windows.Forms.Button btnSoforPaneli;
    }
}