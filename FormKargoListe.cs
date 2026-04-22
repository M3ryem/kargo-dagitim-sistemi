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
    public partial class FormKargoListe : Form
    {
        string connectionString = "Server=localhost;User Id=root;Password=Akdeniz.09;Database=kargo_sistemi;";

        public FormKargoListe()
        {
            InitializeComponent();
        }

        private void FormKargoListe_Load(object sender, EventArgs e)
        {
            YukleKargolar();
        }

        private void YukleKargolar()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM kargolar";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvKargolar.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kargolar yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHucreGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvKargolar.CurrentCell == null)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz hücreyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = dgvKargolar.CurrentCell.RowIndex;
            int columnIndex = dgvKargolar.CurrentCell.ColumnIndex;

            string columnName = dgvKargolar.Columns[columnIndex].Name;
            object yeniDeger = dgvKargolar.CurrentCell.Value;

            // Güncellenebilir sütunları sınırla
            List<string> guncellenebilirSutunlar = new List<string>
    {
        "barkod", "gonderici_adsoyad", "gonderici_telefon", "gonderici_adres",
        "alici_adsoyad", "alici_telefon", "alici_adres",
        "paket_turu", "agirlik", "tahmini_teslim_tarihi", "durum"
    };

            if (!guncellenebilirSutunlar.Contains(columnName.ToLower()))
            {
                MessageBox.Show("Bu sütun güncellenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int kargoId = Convert.ToInt32(dgvKargolar.Rows[rowIndex].Cells["id"].Value);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = $"UPDATE kargolar SET {columnName} = @yeniDeger WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@yeniDeger", yeniDeger);
                        cmd.Parameters.AddWithValue("@id", kargoId);
                        int sonuc = cmd.ExecuteNonQuery();
                        if (sonuc > 0)
                        {
                            MessageBox.Show("Hücre başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Seçilen hücre güncellenemedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                       
                    }
                   

                }

                KargolariYukle(); // tabloyu yenile

            }
            catch 
            {
                
            }
        }

        private void KargolariYukle()
        {
            throw new NotImplementedException();
        }
    }
}

