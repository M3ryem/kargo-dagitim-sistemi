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
    public partial class FormSoforPaneli : Form
    {

        string connectionString = "Server=localhost;User Id=root;Password=Akdeniz.09;Database=kargo_sistemi";
        private object soforId;
       

        public FormSoforPaneli()
        {
            InitializeComponent();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            FormSoforKayit kayitFormu = new FormSoforKayit();
            kayitFormu.StartPosition = FormStartPosition.CenterScreen;
            kayitFormu.ShowDialog(); // kayıt sonrası geri dönsün
        }

        public void btnGirisYap_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string sifre = txtSifre.Text.Trim();


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT sofor_kodu FROM soforler WHERE adsoyad = @ad AND sifre = @sifre";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@sifre", sifre);
                    
                    
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {


                        FormSoforTeslimatlar teslimForm = new FormSoforTeslimatlar();
                        teslimForm.StartPosition = FormStartPosition.CenterScreen;
                        teslimForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz şoför bilgisi!");
                    }
                }
            }
        }






        private void FormSoforTeslimatlar_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, barkod, alici_adsoyad, durum FROM kargolar WHERE sofor_id = @id";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@id", soforId);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTeslimatlar.DataSource = dt;
                }
            }
        }


    }
}
