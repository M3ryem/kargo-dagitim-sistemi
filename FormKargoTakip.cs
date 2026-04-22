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
    public partial class FormKargoTakip : Form
    {
        string connectionString = "Server=localhost;User Id=root;Password=Akdeniz.09;Database=kargo_sistemi";
        public FormKargoTakip()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void FormKargoTakip_Load(object sender, EventArgs e)
        {
            KargolariYukle();
        }


        public void KargolariYukle()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, barkod, gonderici_adsoyad, alici_adsoyad, paket_turu, agirlik, tahmini_teslim_tarihi, durum FROM kargolar";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvKargolar.DataSource = dt;

                        // Başlıkları daha okunabilir yap
                        dgvKargolar.Columns["id"].HeaderText = "ID";
                        dgvKargolar.Columns["barkod"].HeaderText = "Barkod No";
                        dgvKargolar.Columns["gonderici_adsoyad"].HeaderText = "Gönderici";
                        dgvKargolar.Columns["alici_adsoyad"].HeaderText = "Alıcı";
                        dgvKargolar.Columns["paket_turu"].HeaderText = "Paket Türü";
                        dgvKargolar.Columns["agirlik"].HeaderText = "Ağırlık (kg)";
                        dgvKargolar.Columns["tahmini_teslim_tarihi"].HeaderText = "Tahmini Teslim";
                        dgvKargolar.Columns["durum"].HeaderText = "Durum";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kargolar yüklenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvKargolar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek kargoyu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int kargoId = Convert.ToInt32(dgvKargolar.SelectedRows[0].Cells["id"].Value);
            string mevcutDurum = dgvKargolar.SelectedRows[0].Cells["durum"].Value.ToString();

            // Durumu değiştir (örneğin "Yolda" → "Teslim Edildi")
            string yeniDurum = mevcutDurum == "Yolda" ? "Beklemede" : "Teslim Edildi";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string updateQuery = "UPDATE kargolar SET durum = @durum WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@durum", yeniDurum);
                        cmd.Parameters.AddWithValue("@id", kargoId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kargo durumu güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KargolariYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Durum güncellenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string barkod = txtBarkodAra.Text.Trim();

            if (string.IsNullOrWhiteSpace(barkod))
            {
                MessageBox.Show("Lütfen bir barkod numarası girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BarkodaGoreKargolariYukle(barkod);
        }


        private void BarkodaGoreKargolariYukle(string barkod)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT id, barkod, gonderici_adsoyad, alici_adsoyad, paket_turu, agirlik, tahmini_teslim_tarihi, durum 
                             FROM kargolar 
                             WHERE barkod LIKE @barkod";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@barkod", "%" + barkod + "%");

                        DataTable dt = new DataTable();
                        adapter.Fill(dt); // Verileri dt tablosuna doldurur
                        dgvKargolar.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama sırasında hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBarkodAra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAra.PerformClick();
            }
        }

        private void btnKargoSil_Click(object sender, EventArgs e)
        {
            if (dgvKargolar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kargoyu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult sonuc = MessageBox.Show("Seçilen kargo kaydını silmek istediğinize emin misiniz?", "Kargo Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc != DialogResult.Yes) return;

            int kargoId = Convert.ToInt32(dgvKargolar.SelectedRows[0].Cells["id"].Value);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string silQuery = "DELETE FROM kargolar WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(silQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", kargoId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kargo başarıyla silindi.", "Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KargolariYukle(); // listeyi tazele
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi sırasında hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
