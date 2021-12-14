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
    public partial class frmKullanıcıGüncelle : Form
    {
        public frmKullanıcıGüncelle()
        {
            InitializeComponent();
        }

        private void frmKullanıcıGüncelle_Load(object sender, EventArgs e)
        {
            KullanıcıListesi();
        }


        void KullanıcıListesi() 
        {

            VeriTabanıİşlmeleri vti = new VeriTabanıİşlmeleri();

            DataTable dt = new DataTable();

            dt = vti.KullanıcıListesi();

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



        }


        int Id = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;

            index = e.RowIndex;

            if (index >= 0)
            {
                Id = (int)dataGridView1.Rows[index].Cells[0].Value; // ID 
                txtKullanıcıAdı.Text = dataGridView1.Rows[index].Cells[1].Value.ToString(); // KULLANICI ADI
                txtŞifre.Text = dataGridView1.Rows[index].Cells[2].Value.ToString(); // ŞİFRE
                txtMail.Text = dataGridView1.Rows[index].Cells[3].Value.ToString(); // MAİL
                chkAdmin.Checked = (bool)dataGridView1.Rows[index].Cells[4].Value; // ADMİN
            }




        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            DialogResult dr;

            dr = MessageBox.Show("Güncellensin mi ?", "Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {


                Kullanıcı kullanıcı = new Kullanıcı();

                kullanıcı.Id = Id;

                kullanıcı.KullanıcıAdı = txtKullanıcıAdı.Text;
                kullanıcı.Şifre = txtŞifre.Text;
                kullanıcı.Mail = txtMail.Text;
                kullanıcı.Admin = chkAdmin.Checked ? true : false;

                VeriTabanıİşlmeleri vti = new VeriTabanıİşlmeleri();

                bool güncellendiMi;

                güncellendiMi = vti.KullanıcıGüncelle(kullanıcı);

                if (güncellendiMi)
                {
                    MessageBox.Show(kullanıcı.KullanıcıAdı + " Adlı Kullanıcı Güncellendi ");
                    KullanıcıListesi();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Güncellenmedi !!!!!!!!!");
                }

            }



        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnSil_Click(object sender, EventArgs e)
        {
            VeriTabanıİşlmeleri vti = new VeriTabanıİşlmeleri();
            bool silindiMi = vti.KullanıcıSil(Id);

            if (silindiMi)
            {
                MessageBox.Show("Kullanıcı Silindi");
                KullanıcıListesi();
            }
            else
            {
                MessageBox.Show("Kullanıcı Silinemedi");
            }






        }
    }
}
