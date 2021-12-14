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
    public partial class frmKullanıcıEkle : Form
    {
        public frmKullanıcıEkle()
        {
            InitializeComponent();
        }

        private void frmKullanıcıEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kullanıcı kullanıcı = new Kullanıcı();

            kullanıcı.KullanıcıAdı = txtKullanıcıAdı.Text;
            kullanıcı.Şifre = txtŞifre.Text;
            kullanıcı.Mail = txtMail.Text;
            kullanıcı.Admin = chkAdmin.Checked ? true : false;

            VeriTabanıİşlmeleri vti = new VeriTabanıİşlmeleri();

            bool EklendiMi;

            EklendiMi = vti.KullanıcıEkle(kullanıcı);

            if (EklendiMi)
            {
                MessageBox.Show(kullanıcı.KullanıcıAdı + " Adlı Kullanıcı Eklendi");
            }
            else
            {
                MessageBox.Show("Kullanıcı Eklenmedi !!!!!!!!!");
            }

        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
