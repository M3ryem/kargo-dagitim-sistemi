namespace Kargo_Dağıtım_Sistemi
{
    partial class FormKargoEkle
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGondericiAdres = new System.Windows.Forms.TextBox();
            this.txtGondericiTelefon = new System.Windows.Forms.TextBox();
            this.txtGondericiAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAliciAdres = new System.Windows.Forms.TextBox();
            this.txtAliciTelefon = new System.Windows.Forms.TextBox();
            this.txtAliciAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpTahminiTeslim = new System.Windows.Forms.DateTimePicker();
            this.nudAgirlik = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPaketTuru = new System.Windows.Forms.ComboBox();
            this.btnKargoKaydet = new System.Windows.Forms.Button();
            this.btnKargoListesi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgirlik)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(472, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yeni Kargo Girişi";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Thistle;
            this.groupBox1.Controls.Add(this.txtGondericiAdres);
            this.groupBox1.Controls.Add(this.txtGondericiTelefon);
            this.groupBox1.Controls.Add(this.txtGondericiAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 252);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gönderici Bilgileri";
            // 
            // txtGondericiAdres
            // 
            this.txtGondericiAdres.Location = new System.Drawing.Point(121, 165);
            this.txtGondericiAdres.Name = "txtGondericiAdres";
            this.txtGondericiAdres.Size = new System.Drawing.Size(183, 27);
            this.txtGondericiAdres.TabIndex = 5;
            // 
            // txtGondericiTelefon
            // 
            this.txtGondericiTelefon.Location = new System.Drawing.Point(121, 100);
            this.txtGondericiTelefon.Name = "txtGondericiTelefon";
            this.txtGondericiTelefon.Size = new System.Drawing.Size(183, 27);
            this.txtGondericiTelefon.TabIndex = 4;
            // 
            // txtGondericiAd
            // 
            this.txtGondericiAd.Location = new System.Drawing.Point(121, 46);
            this.txtGondericiAd.Name = "txtGondericiAd";
            this.txtGondericiAd.Size = new System.Drawing.Size(183, 27);
            this.txtGondericiAd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı Soyadı:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Thistle;
            this.groupBox2.Controls.Add(this.txtAliciAdres);
            this.groupBox2.Controls.Add(this.txtAliciTelefon);
            this.groupBox2.Controls.Add(this.txtAliciAd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(383, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 252);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alıcı Bilgileri";
            // 
            // txtAliciAdres
            // 
            this.txtAliciAdres.Location = new System.Drawing.Point(130, 163);
            this.txtAliciAdres.Name = "txtAliciAdres";
            this.txtAliciAdres.Size = new System.Drawing.Size(184, 27);
            this.txtAliciAdres.TabIndex = 5;
            // 
            // txtAliciTelefon
            // 
            this.txtAliciTelefon.Location = new System.Drawing.Point(130, 100);
            this.txtAliciTelefon.Name = "txtAliciTelefon";
            this.txtAliciTelefon.Size = new System.Drawing.Size(184, 27);
            this.txtAliciTelefon.TabIndex = 4;
            // 
            // txtAliciAd
            // 
            this.txtAliciAd.Location = new System.Drawing.Point(130, 46);
            this.txtAliciAd.Name = "txtAliciAd";
            this.txtAliciAd.Size = new System.Drawing.Size(184, 27);
            this.txtAliciAd.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Adres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(10, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adı Soyadı:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Thistle;
            this.groupBox3.Controls.Add(this.txtBarkod);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dtpTahminiTeslim);
            this.groupBox3.Controls.Add(this.nudAgirlik);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmbPaketTuru);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(762, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 252);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kargo Detayları";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(208, 121);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(146, 27);
            this.txtBarkod.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "Barkod :";
            // 
            // dtpTahminiTeslim
            // 
            this.dtpTahminiTeslim.Location = new System.Drawing.Point(208, 174);
            this.dtpTahminiTeslim.Name = "dtpTahminiTeslim";
            this.dtpTahminiTeslim.Size = new System.Drawing.Size(220, 27);
            this.dtpTahminiTeslim.TabIndex = 5;
            // 
            // nudAgirlik
            // 
            this.nudAgirlik.Location = new System.Drawing.Point(208, 73);
            this.nudAgirlik.Name = "nudAgirlik";
            this.nudAgirlik.Size = new System.Drawing.Size(84, 27);
            this.nudAgirlik.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(-4, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tahmini Teslim Tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "kg cinsinden ağırlık:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Paket Türü:";
            // 
            // cmbPaketTuru
            // 
            this.cmbPaketTuru.FormattingEnabled = true;
            this.cmbPaketTuru.Items.AddRange(new object[] {
            "Küçük Paket",
            "Orta Boy",
            "Büyük Paket"});
            this.cmbPaketTuru.Location = new System.Drawing.Point(208, 26);
            this.cmbPaketTuru.Name = "cmbPaketTuru";
            this.cmbPaketTuru.Size = new System.Drawing.Size(146, 27);
            this.cmbPaketTuru.TabIndex = 0;
            // 
            // btnKargoKaydet
            // 
            this.btnKargoKaydet.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnKargoKaydet.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKargoKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKargoKaydet.Location = new System.Drawing.Point(823, 431);
            this.btnKargoKaydet.Name = "btnKargoKaydet";
            this.btnKargoKaydet.Size = new System.Drawing.Size(167, 60);
            this.btnKargoKaydet.TabIndex = 4;
            this.btnKargoKaydet.Text = "Kargo Kaydet";
            this.btnKargoKaydet.UseVisualStyleBackColor = false;
            this.btnKargoKaydet.Click += new System.EventHandler(this.btnKargoKaydet_Click);
            // 
            // btnKargoListesi
            // 
            this.btnKargoListesi.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnKargoListesi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKargoListesi.Location = new System.Drawing.Point(164, 431);
            this.btnKargoListesi.Name = "btnKargoListesi";
            this.btnKargoListesi.Size = new System.Drawing.Size(265, 60);
            this.btnKargoListesi.TabIndex = 5;
            this.btnKargoListesi.Text = "Kargo Listesini Görüntüle";
            this.btnKargoListesi.UseVisualStyleBackColor = false;
            this.btnKargoListesi.Click += new System.EventHandler(this.btnKargoListesi_Click);
            // 
            // FormKargoEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1236, 600);
            this.Controls.Add(this.btnKargoListesi);
            this.Controls.Add(this.btnKargoKaydet);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "FormKargoEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgirlik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGondericiAdres;
        private System.Windows.Forms.TextBox txtGondericiTelefon;
        private System.Windows.Forms.TextBox txtGondericiAd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAliciAdres;
        private System.Windows.Forms.TextBox txtAliciTelefon;
        private System.Windows.Forms.TextBox txtAliciAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbPaketTuru;
        private System.Windows.Forms.DateTimePicker dtpTahminiTeslim;
        private System.Windows.Forms.NumericUpDown nudAgirlik;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnKargoKaydet;
        private System.Windows.Forms.Button btnKargoListesi;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label11;
    }
}

