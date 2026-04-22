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
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        public void btnKargoEkle_Click(object sender, EventArgs e)
        {
            FormKargoEkle frm = new FormKargoEkle(); // eski Form1’in adını buna çevirmiş olacağız
            this.Hide();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        public void btnKargoTakip_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ana formu gizle

            FormKargoTakip takipFormu = new FormKargoTakip();
            takipFormu.StartPosition = FormStartPosition.CenterScreen; // Ortada açılsın
            takipFormu.FormClosed += (s, args) => this.Show(); // Kargo takip formu kapanınca ana menü geri gelsin
            takipFormu.Show();
        }

        private void btnSoforPaneli_Click(object sender, EventArgs e)
        {
            FormSoforPaneli soforForm = new FormSoforPaneli();
            soforForm.StartPosition = FormStartPosition.CenterScreen;
            soforForm.Show();
        }

    }
}
