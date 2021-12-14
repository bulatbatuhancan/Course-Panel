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
    public partial class frmÖdemeİşlemleri : Form
    {
        public frmÖdemeİşlemleri()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (txtOgrNo.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Öğrenci No girilmedi!!!!");
            }

        }

        private void btnTaksitGetir_Click(object sender, EventArgs e)
        {

            if (txtOgrNo.Text != "")
            {
                int OgrNo;
                int.TryParse(txtOgrNo.Text, out OgrNo);

                if (OgrNo != 0)
                {
                    VeriTabanıİşlmeleri vti = new VeriTabanıİşlmeleri();

                    DataTable dt = new DataTable();
                    dt = vti.TaksitleriGetir(OgrNo,"tblTaksitler");
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[1].Visible = false;
                    dataGridView1.Columns[2].Width = 50;
                    dataGridView1.Columns[3].Width = 50;
                    dataGridView1.Columns[4].Width = 75;
                    GridDüzenle();
                }
                else
                {
                    MessageBox.Show("Öğrenci No Doğru Girmediniz");
                }



            }
            else
            {
                MessageBox.Show("Öğrenci No girilmedi!!!!");
            }

        }

        void GridDüzenle()
        {
            int index = 0;


            foreach (DataGridViewRow rw in dataGridView1.Rows)
            {
                if (Convert.ToString( rw.Cells[6].Value ) == "Ödenmedi")
                {
                    dataGridView1.Rows[index].Cells[6].Style.BackColor = Color.Red;                    
                }
                else
                {
                    dataGridView1.Rows[index].Cells[6].Style.BackColor = Color.Green;
                    dataGridView1.Rows[index].Frozen = true;

                }
                index++;

            }





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int satır = e.RowIndex;

            //MessageBox.Show(e.ColumnIndex.ToString());

            int KalanTutar = 0;
            string ÖdemeDurumu = " ";
            int TaksitNo = 0;
            int TaksitMiktarı = 0;
            int ÖdenecekMiktar = 0;
            int OgrNo = 0;

            if (e.ColumnIndex == 0)
            {
                if (txtÖdenecekMiktar.Text == "")
                {
                    MessageBox.Show("Ödeme Miktarı Girilmedi!!!");
                    return;
                }



                TaksitMiktarı = Convert.ToInt32(dataGridView1.Rows[satır].Cells[4].Value);

                ÖdenecekMiktar = Convert.ToInt32(txtÖdenecekMiktar.Text);



                if (TaksitMiktarı == 0 || Convert.ToString(dataGridView1.Rows[satır].Cells["ÖdemeDurumu"].Value) == "Ödendi")
                {
                    MessageBox.Show("Bu Taksit Zaten Ödenmiş");
                    return;
                }



                if (MessageBox.Show("Ödeme Yapılsın mı ?","Ödeme",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No )
                {
                    return;
                }



                if (ÖdenecekMiktar > TaksitMiktarı)
                {

                    KalanTutar = 0;

                }
                else
                {
                    KalanTutar = TaksitMiktarı - Convert.ToInt32(txtÖdenecekMiktar.Text);
                }

                
                
                dataGridView1.Rows[satır].Cells[4].Value = KalanTutar;

                VeriTabanıİşlmeleri vti = new VeriTabanıİşlmeleri();

                bool ÖdemeOk = false;

                TaksitNo = Convert.ToInt32(dataGridView1.Rows[satır].Cells[3].Value);
                OgrNo = Convert.ToInt32(dataGridView1.Rows[satır].Cells[2].Value);

                if (KalanTutar == 0)
                {
                    dataGridView1.Rows[satır].Cells[6].Value = "Ödendi";
                    dataGridView1.Rows[satır].Cells[6].Style.BackColor = Color.Green;
                    ÖdemeOk = vti.ÖdemeYap(OgrNo, TaksitNo);
                }
                else
                {
                    ÖdemeOk = vti.ÖdemeYap(OgrNo, TaksitNo, KalanTutar);
                }

                if (ÖdemeOk)
                {
                    MessageBox.Show("Ödeme Yapıldı");
                }
                else
                {
                    MessageBox.Show("Ödeme Yapılmadı");
                }


                
                MessageBox.Show(KalanTutar.ToString());
            
            }




        }

        private void btnÖdenmişTaksitler_Click(object sender, EventArgs e)
        {
            if (txtOgrNo.Text != "")
            {
                int OgrNo;
                int.TryParse(txtOgrNo.Text, out OgrNo);

                if (OgrNo != 0)
                {
                    VeriTabanıİşlmeleri vti = new VeriTabanıİşlmeleri();

                    DataTable dt = new DataTable();
                    dt = vti.TaksitleriGetir(OgrNo,"tblÖdenmişTaksitler");
                    Form frm = new Form();
                    DataGridView grd = new DataGridView();
                    grd.DataSource = dt;

                    frm.Size = new Size(500, 400);
                    frm.Size = new Size(650, 400);

                    grd.Size = new Size(500, 400);
                    grd.Size = new Size(635, 300);

                    frm.Controls.Add(grd);

                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Öğrenci No Doğru Girmediniz");
                }



            }
            else
            {
                MessageBox.Show("Öğrenci No girilmedi!!!!");
            }
        }
    }
}
