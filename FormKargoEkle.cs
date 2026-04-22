using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Kargo_Dağıtım_Sistemi
{
    public partial class FormKargoEkle : Form
    {
        string connectionString = "Server=localhost;User Id=root;Password=Akdeniz.09;Database=kargo_sistemi;";



        public FormKargoEkle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBarkod.Text = BarkodUret();
        }

        private string BarkodUret()
        {
            return Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
        }

        private void btnKargoKaydet_Click(object sender, EventArgs e)
        {
            // Önce boş alan kontrolü
            if (string.IsNullOrWhiteSpace(txtGondericiAd.Text) ||
                string.IsNullOrWhiteSpace(txtGondericiTelefon.Text) ||
                string.IsNullOrWhiteSpace(txtGondericiAdres.Text) ||

                string.IsNullOrWhiteSpace(txtAliciAd.Text) ||
                string.IsNullOrWhiteSpace(txtAliciTelefon.Text) ||
                string.IsNullOrWhiteSpace(txtAliciAdres.Text))
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanına kayıt işlemi
            try
            {
                string connectionString = "Server=localhost;User Id=root;Password=Akdeniz.09;Database=kargo_sistemi;";



                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO kargolar 
                        (gonderici_adsoyad, gonderici_telefon, gonderici_adres, 
                         alici_adsoyad, alici_telefon, alici_adres, 
                         paket_turu, agirlik, tahmini_teslim_tarihi, barkod)
                        VALUES 
                        (@gonderici_adsoyad, @gonderici_telefon, @gonderici_adres, 
                         @alici_adsoyad, @alici_telefon, @alici_adres, 
                         @paket_turu, @agirlik, @tahmini_teslim_tarihi, @barkod)";


                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@barkod", txtBarkod.Text.Trim());

                        cmd.Parameters.AddWithValue("@gonderici_adsoyad", txtGondericiAd.Text.Trim());

                        cmd.Parameters.AddWithValue("@gonderici_telefon", txtGondericiTelefon.Text.Trim());
                        cmd.Parameters.AddWithValue("@gonderici_adres", txtGondericiAdres.Text.Trim());
                        cmd.Parameters.AddWithValue("@alici_adsoyad", txtAliciAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@alici_telefon", txtAliciTelefon.Text.Trim());
                        cmd.Parameters.AddWithValue("@alici_adres", txtAliciAdres.Text.Trim());
                        cmd.Parameters.AddWithValue("@paket_turu", cmbPaketTuru.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@agirlik", nudAgirlik.Value);
                        cmd.Parameters.AddWithValue("@tahmini_teslim_tarihi", dtpTahminiTeslim.Value.Date);
                       

                        cmd.ExecuteNonQuery();//select dışındaki işlemleri çalıştırır.
                    }
                }

                MessageBox.Show("Kargo başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Kaydettikten sonra formu temizle
                Temizle();
                txtBarkod.Text = BarkodUret();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            txtGondericiAd.Clear();
            txtGondericiTelefon.Clear();
            txtGondericiAdres.Clear();
            txtAliciAd.Clear();
            txtAliciTelefon.Clear();
            txtAliciAdres.Clear();

            if (cmbPaketTuru.Items.Count > 0)
                cmbPaketTuru.SelectedIndex = 0;

            nudAgirlik.Value = 0;
            dtpTahminiTeslim.Value = DateTime.Today;
        }

        private void btnKargoListesi_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ana formu gizle
            FormKargoListe listeFormu = new FormKargoListe();
            listeFormu.StartPosition = FormStartPosition.CenterScreen;
            listeFormu.FormClosed += (s, args) => this.Show(); // Kapanınca ana form geri gelsin
            listeFormu.Show(); // veya ShowDialog() kullanabilirsin
        }

    }
}
