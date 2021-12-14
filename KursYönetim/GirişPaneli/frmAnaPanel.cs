using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klaslar;

namespace GirişPaneli
{



    public partial class frmAnaPanel : Form
    {


        public frmAnaPanel()
        {
            InitializeComponent();
        }

        public static List<Öğrenci> ÖğrenciListesi = new List<Öğrenci>(1);

        public static string kullanıcıAdı = "";

        public static bool Admin = false;

        private void frmAnaPanel_Load(object sender, EventArgs e)
        {


            FrmGirişPaneli frm = new FrmGirişPaneli();
            frm.ShowDialog();










            lblKullanıcı.Text = kullanıcıAdı;
            lblAdmin.Text = Admin == true ? "Admin" : "Kullanıcı";

            if (Admin == false)
            {
                kullanıcıEkle.Enabled = false;
                kullanıcıGüncelle.Enabled = false;
            }
            else
            {

            }

        }

        private void kayıtİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKayıtİşlemleri frm = new frmKayıtİşlemleri();
            frm.ShowDialog();
        }

        private void bilgiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBilgiGüncelle frm = new frmBilgiGüncelle();
            frm.ShowDialog();
        }

        private void öğrenciİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullanıcıEkle frm = new frmKullanıcıEkle();
            frm.ShowDialog();
            
        }

        private void kullanıcıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullanıcıGüncelle frm = new frmKullanıcıGüncelle();
            frm.ShowDialog();
        }

        private void ödemeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmÖdemeİşlemleri frm = new frmÖdemeİşlemleri();
            frm.ShowDialog();
        }

        private void ödemePlanıOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmÖdemePlanı frm = new frmÖdemePlanı();

            frm.txtOgrNo.Visible = true;


            frm.Show();
        }

        private void müzikAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMüzik frm = new frmMüzik();
            frm.ShowDialog();
        }

        private void mailGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMail frm = new frmMail();
            frm.ShowDialog();
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRaporlar frm = new frmRaporlar();
            frm.ShowDialog();
        }
    }









}
