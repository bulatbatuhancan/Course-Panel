using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klaslar;

namespace GirişPaneli
{
    public partial class frmRaporlar : Form
    {
        public frmRaporlar()
        {
            InitializeComponent();
        }

        private void frmRaporlar_Load(object sender, EventArgs e)
        {

        }

        private void btnToplamÖdemeler_Click(object sender, EventArgs e)
        {
            VeriTabanıİşlmeleri vti = new VeriTabanıİşlmeleri();
            dataGridView1.DataSource = vti.EğitimGelirleri();
        }

        private void btnÖdenmemiş_Click(object sender, EventArgs e)
        {
            // veritaabanından ödenmemişler tutarı getirelim....

            VeriTabanıİşlmeleri vti = new VeriTabanıİşlmeleri();
            dataGridView1.DataSource = vti.Ödenmemişler();

            // Toplam Ödemeyi bulalım

            int ToplamÖdeme = 0;
            int KalanÖdeme = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                ToplamÖdeme = ToplamÖdeme + Convert.ToInt32(row.Cells[3].Value);
                KalanÖdeme = KalanÖdeme + Convert.ToInt32(row.Cells[4].Value);

            }

            lblToplamTutar.Text = ToplamÖdeme.ToString();
            lblKalanToplam.Text = KalanÖdeme.ToString();
            lblGelecekÖdeme.Text = (ToplamÖdeme - KalanÖdeme).ToString();

            // Kalan Ödemeyi Bulalım

        }

        private void lblToplam_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
