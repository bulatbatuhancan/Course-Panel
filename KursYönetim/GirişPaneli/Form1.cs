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
    public partial class FrmGirişPaneli : Form
    {
        string KullanıcıAdı = "BULAT";
        string Şifre = "123456";
        int hak = 0;
        bool AppClose = true;



        public FrmGirişPaneli()
        {
            InitializeComponent();
        }




        private void FrmGirişPaneli_Load(object sender, EventArgs e)
        {


        }




        private void button2_Click(object sender, EventArgs e)
        {

        }




        private void label3_Click(object sender, EventArgs e)
        {

        }




        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }




        private void label2_Click(object sender, EventArgs e)
        {

        }




        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmGirişPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AppClose == true)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void txtKullanıcıAdı_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back )
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnGiriş(object sender, EventArgs e)
        {
            if (txtŞifre.Text.Length < 4)
            {
                MessageBox.Show("Şifre en az 4 karakterli olmalıdır");
                txtŞifre.Text = "";
                txtKullanıcıAdı.Text = "";
                return;
            }


            VeriTabanıİşlmeleri vti = new VeriTabanıİşlmeleri();


            bool KulVarMı;

            KulVarMı = vti.KullanıcıVarMı(txtKullanıcıAdı.Text, txtŞifre.Text);

            if (KulVarMı)
            {
                MessageBox.Show("Öğrenci yönetim paneline hoşgeldiniz");
                AppClose = false;
                this.Close();
                frmAnaPanel.kullanıcıAdı = txtKullanıcıAdı.Text;
                frmAnaPanel.Admin = VeriTabanıİşlmeleri.Admin;

            }
            else
            {
                MessageBox.Show("Kullanıcı adı / Şifre hatalı!");
                AppClose = true;

            }






        }
    }
}
