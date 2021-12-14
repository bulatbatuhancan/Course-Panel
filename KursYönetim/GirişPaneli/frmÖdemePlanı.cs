using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klaslar;

namespace GirişPaneli
{
    public partial class frmÖdemePlanı : Form
    {


        public frmÖdemePlanı()
        {
            InitializeComponent();
        }
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (rdbTaksitli.Checked)
            {
                 Taksitlendirme();
            }
        }


        void Taksitlendirme()
        {
            byte TaksitSayısı = Byte.Parse(cmbTaksitSayısı.Text);

            ushort KalanTutar = (ushort) (ushort.Parse(cmbToplamTutar.Text) - ushort.Parse(txtPeşinat.Text));

            float TaksitMiktarı = KalanTutar / TaksitSayısı;

            dataGridView1.Rows.Add(TaksitSayısı);

            for (int i = 0; i < TaksitSayısı; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                dataGridView1.Rows[i].Cells[1].Value = TaksitMiktarı;
                dataGridView1.Rows[i].Cells[2].Value = dateTimePicker1.Value.AddMonths(i);
                dataGridView1.Rows[i].Cells[3].Value = "Ödenmedi";
                dataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.Red;
            }



        }


        private void btnTaksitKaydet(object sender, EventArgs e)
        {
            DialogResult dr;

            dr = MessageBox.Show("Ödeme Planı Kaydedilsin mi ?", "Ödeme Planı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                öp.ToplamTutar = ushort.Parse(cmbToplamTutar.Text);
                öp.Peşinat = ushort.Parse(txtPeşinat.Text);
                öp.TaksitSayısı = byte.Parse(cmbTaksitSayısı.Text);
                öp.İlkÖdemeTarihi = dateTimePicker1.Value;
                //öp.ÖdemeDurumu = "Ödenmedi";

                if (rdbPeşin.Checked)
                {
                    öp.ÖdemeBiçimi = ÖdemeBiçimi.Peşin;
                }
                else if (rdbTaksitli.Checked)
                {
                    öp.ÖdemeBiçimi = ÖdemeBiçimi.Taksitli;

                }

                // Ödeme Biçimimnin Taksitleri - eğe varsa - datagridview içindedir
                // Oradan alacağız. Bunun için önce bir dataTable oluşturacağız.

                DataTable dt = new DataTable();

                if (rdbTaksitli.Checked && byte.Parse(cmbTaksitSayısı.Text) != 0)
                {
                    // DataTable oluşturalım. 


                    dt.Columns.Add("TaksitNo", typeof(byte));
                    dt.Columns.Add("TaksitMiktarı", typeof(ushort));
                    dt.Columns.Add("ÖdemeTarihi", typeof(DateTime));
                    dt.Columns.Add("Ödeme Durumu", typeof(string));

                    // GridView dan her bir satırı DataTable(dt diye Oluşturduk) a alalım.

                    foreach (DataGridViewRow rv in dataGridView1.Rows)
                    {
                        dt.Rows.Add(rv.Cells[0].Value, rv.Cells[1].Value, rv.Cells[2].Value);
                    }

                }

                öp.Taksitler = dt;

                frmKayıtİşlemleri.ödemePlanı = öp;
            }
            else
            {

            }


            MessageBox.Show("Ödeme Planını Kaydedildi");
            this.Close();


        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        ÖdemePlanı öp = new ÖdemePlanı();


        bool VeriControl()
        {

            if (cmbToplamTutar.Text == "" || txtPeşinat.Text == "" || (rdbPeşin.Checked && rdbTaksitli.Checked) == true || cmbTaksitSayısı.Text == "" || dateTimePicker1.Value <= DateTime.Today)
            {
                return true;
            }
            else
            {

                if (txtOgrNo.Visible && txtOgrNo.Text == "")
                {
                    return true;
                }
                else
                {
                    if (rdbTaksitli.Checked && cmbTaksitSayısı.Text == "")
                        return true;
                    else
                        return false;

                }
            }

        }


        private void TaksitKaydet_Click(object sender, EventArgs e)
        {
            // Veriler Eksiksiz Girilmiş mi ?

            DialogResult dr;

            dr = MessageBox.Show("Ödeme Planı Kaydedilsin mi ?", "Ödeme Planı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                öp.ToplamTutar = ushort.Parse(cmbToplamTutar.Text);
                öp.Peşinat = ushort.Parse(txtPeşinat.Text);
                //öp.TaksitSayısı = byte.Parse(cmbTaksitSayısı.Text);
                öp.İlkÖdemeTarihi = dateTimePicker1.Value;
                //öp.ÖdemeDurumu = "Ödenmedi";

                if (rdbPeşin.Checked)
                {
                    if (öp.ToplamTutar != öp.Peşinat)
                    {
                        MessageBox.Show("Peşinat Eksik Girildi");
                    }
                    else
                    {
                        öp.ÖdemeBiçimi = ÖdemeBiçimi.Peşin;
                        öp.TaksitSayısı = 0;
                    }
                }
                else if (rdbTaksitli.Checked)
                {
                    öp.ÖdemeBiçimi = ÖdemeBiçimi.Taksitli;

                }

                // Ödeme Biçimimnin Taksitleri - eğe varsa - datagridview içindedir
                // Oradan alacağız. Bunun için önce bir dataTable oluşturacağız.

                DataTable dt = new DataTable();

                if (rdbTaksitli.Checked && byte.Parse(cmbTaksitSayısı.Text) != 0)
                {
                    // DataTable oluşturalım. 


                    dt.Columns.Add("TaksitNo", typeof(byte));
                    dt.Columns.Add("TaksitMiktarı", typeof(decimal));
                    dt.Columns.Add("ÖdemeTarihi", typeof(DateTime));
                    dt.Columns.Add("ÖdemeDurumu", typeof(string));

                    // GridView dan her bir satırı DataTable(dt diye Oluşturduk) a alalım.

                    foreach (DataGridViewRow rv in dataGridView1.Rows)
                    {
                        if (rv.Cells[0].Value != null)
                        {
                            dt.Rows.Add(rv.Cells[0].Value, rv.Cells[1].Value, rv.Cells[2].Value, rv.Cells[3].Value);

                        }
                    }

                }

                öp.Taksitler = dt;


                if (txtOgrNo.Visible)
                {
                    int OgrNo = 0;
                    int.TryParse(txtOgrNo.Text, out OgrNo);

                    if (OgrNo != 0)
                    {
                        VeriTabanıİşlmeleri vti = new VeriTabanıİşlmeleri();
                        bool eklendiMi = vti.ÖdemePlanıEkle(öp, OgrNo);

                        if (eklendiMi)
                        {
                            MessageBox.Show("Öğrenci Bilgisi Eklendi !!");
                        }
                        else
                        {
                            MessageBox.Show("Öğrenci Bilgisi Eklenmedi !!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Öğrenci No Girmediniz");
                    }


                }
                else
                {
                    MessageBox.Show("Ödeme Planını Kaydedildi");
                    this.Close();
                }

                frmKayıtİşlemleri.ödemePlanı = öp;
            }
            else
            {

            }




            














            if ( VeriControl() )
            {
                MessageBox.Show("Eksik Bilgi Var");
                return;
            }
            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void frmÖdemePlanı_Load(object sender, EventArgs e)
        {

        }
    }
}
