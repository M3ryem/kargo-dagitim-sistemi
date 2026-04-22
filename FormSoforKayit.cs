using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kargo_Dağıtım_Sistemi
{
    public partial class FormSoforKayit : Form
    {
        string connectionString = "Server=localhost;User Id=root;Password=Akdeniz.09;Database=kargo_sistemi;";

        public FormSoforKayit()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string adsoyad = txtAdSoyad.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrWhiteSpace(adsoyad) || string.IsNullOrWhiteSpace(telefon) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Rastgele Şoför Kodu Üret
            string soforKodu = "S" + Guid.NewGuid().ToString("N").Substring(0, 7).ToUpper();


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO soforler (adsoyad, telefon, sifre, sofor_kodu) 
                                     VALUES (@adsoyad, @telefon, @sifre, @sofor_kodu)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@adsoyad", adsoyad);
                    cmd.Parameters.AddWithValue("@telefon", telefon);
                    cmd.Parameters.AddWithValue("@sifre", sifre);
                    cmd.Parameters.AddWithValue("@sofor_kodu", soforKodu);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Şoför başarıyla kaydedildi.\nŞoför Kodu: " + soforKodu, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }

            this.Close(); // kayıt ekranı kapansın
        }

    }
}
