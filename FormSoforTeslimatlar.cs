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
    public partial class FormSoforTeslimatlar : Form
    {
        int soforId;
        int girisYapanSoforId;
        string soforKodu;
        string connectionString = "Server=localhost;User Id=root;Password=Akdeniz.09;Database=kargo_sistemi;";
        private string girisYapanSoforKodu;

        public FormSoforTeslimatlar()
        {
            InitializeComponent();
            this.Load += FormSoforTeslimatlar_Load;
        }

        private void FormSoforTeslimatlar_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM kargolar";


                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                   
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTeslimatlar.DataSource = dt;
                }
            }
        }


        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            // Seçili satır kontrolü
            if (dgvTeslimatlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen teslim ettiğiniz kargoyu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen kargonun ID’sini al
            int kargoId = Convert.ToInt32(dgvTeslimatlar.SelectedRows[0].Cells["id"].Value);

            // Veritabanında durumu güncelle
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE kargolar SET durum = 'Teslim Edildi' WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", kargoId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Kargo durumu 'Teslim Edildi' olarak güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Listeyi yenile
            FormSoforTeslimatlar_Load(null, null);
        }

    }
}
