using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klaslar;
using static Klaslar.Öğrenci;

namespace GirişPaneli
{
    public partial class frmBilgiGüncelle : Form
    {

        public frmBilgiGüncelle()
        {
            InitializeComponent();
        }


        private void label12_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void frmBilgiGüncelle_Load(object sender, EventArgs e)
        {

            ÖğrencileriListele();

        }


        void ÖğrencileriListele()
        {
            VeriTabanıİşlmeleri vti = new VeriTabanıİşlmeleri();
            DataSet ds = vti.ÖğrenciListesi();

            if (ds.Tables.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Veri Tabanı Hatası!!!");
            }

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // hangi satıra tıklandı ise o satırı alalım ve textbox vs lere yazalım.

            int SatırNo = 0;

            SatırNo = e.RowIndex;

            if (SatırNo >= 0)
            {
                txtOgrNo.Text = dataGridView1.Rows[SatırNo].Cells[1].Value.ToString();
                txtAdı.Text = dataGridView1.Rows[SatırNo].Cells[2].Value.ToString();
                txtSoyadı.Text = dataGridView1.Rows[SatırNo].Cells[3].Value.ToString();
                cmbEğitim.Text = dataGridView1.Rows[SatırNo].Cells[4].Value.ToString();

                String KayıtDurumu = dataGridView1.Rows[SatırNo].Cells[4].Value.ToString();

                if (KayıtDurumu == "KesinKayıt")
                {
                    rdbKesinKayıt.Checked = true;
                }
                else if (KayıtDurumu == "ÖnKayıt")
                {
                    rdbÖnKayıt.Checked = true;
                }
                else
                {
                    rdbMezun.Checked = true;
                }

                txtTCNo.Text = dataGridView1.Rows[SatırNo].Cells[6].Value.ToString();
                txtTelefon.Text = dataGridView1.Rows[SatırNo].Cells[7].Value.ToString();
                txtMail.Text = dataGridView1.Rows[SatırNo].Cells[8].Value.ToString();

                string Cinsiyet = dataGridView1.Rows[SatırNo].Cells[9].Value.ToString();

                if (true)
                {
                    rdbErkek.Checked = true;
                }
                else if (true)
                {
                    rdbKadın.Checked = true;
                }
                else
                {
                    //GİRİLMEDİ SONRA        
                }

                cmbMeslek.Text = dataGridView1.Rows[SatırNo].Cells[10].Value.ToString();
                txtAdres.Text = dataGridView1.Rows[SatırNo].Cells[11].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[SatırNo].Cells[12].Value.ToString();
                txtHakkında.Text = dataGridView1.Rows[SatırNo].Cells[13].Value.ToString();
                pictureBox1.Image = stringToImage(dataGridView1.Rows[SatırNo].Cells[14].Value.ToString());






            }


         




        }


        public Image stringToImage(string base64String)
        {
            if (string.IsNullOrWhiteSpace(base64String))
                return null;

            byte[] bytes = Convert.FromBase64String(base64String);
            MemoryStream stream = new MemoryStream(bytes);
            return Image.FromStream(stream);


        }


        private void cmbSertifika_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Öğrenci ogr = ÖğrenciVerileriniTopla();

            VeriTabanıİşlmeleri vti = new VeriTabanıİşlmeleri();

            bool güncellendiMi = vti.ÖğrenciGüncelle(ogr);

            if (güncellendiMi)
            {
                MessageBox.Show(ogr.Adı + " Adlı Kullanıcı Güncellendi ");
                ÖğrenciVerileriniTopla();
                ÖğrencileriListele();
            }
            else
            {
                MessageBox.Show("Kullanıcı Güncellenmedi !!!!!!!!!");
            }


        }


        public string ImageToString(Image İmage)
        {
            if (İmage == null)
                return String.Empty;

            MemoryStream stream = new MemoryStream();
            İmage.Save(stream, İmage.RawFormat);
            byte[] bytes = stream.ToArray();

            return Convert.ToBase64String(bytes);

        }


        Öğrenci ÖğrenciVerileriniTopla()
        {
            Öğrenci ogr = new Öğrenci();

            ogr.OgrNo = Convert.ToInt32(txtOgrNo.Text);
            ogr.Adı = txtAdı.Text;
            ogr.Soyadı = txtSoyadı.Text;
            ogr.KayıtDurumu = rdbKesinKayıt.Checked == true ? "Kesin Kayıt" : "Ön Kayıt";
            ogr.Eğitim = cmbEğitim.Text;

            ogr.TCno = txtTCNo.Text;
            ogr.Telefon = txtTelefon.Text;
            ogr.Mail = txtMail.Text;

            if (cmbMeslek.Text == "ÜnvÖğrencisi")
            {
                ogr.Meslek = Meslekler.ÜnvÖğrencisi;
            }
            else if (cmbMeslek.Text == "LiseÖğrencisi")
            {
                ogr.Meslek = Meslekler.LiseÖğrencisi;
            }
            else if (cmbMeslek.Text == "Mühendis")
            {
                ogr.Meslek = Meslekler.Mühendis;
            }
            else if (cmbMeslek.Text == "Çalışan")
            {
                ogr.Meslek = Meslekler.Çalışan;
            }
            else if (cmbMeslek.Text == "Diğer")
            {
                ogr.Meslek = Meslekler.Diğer;
            }

            ogr.DoğumTarihi = dateTimePicker1.Value;
            ogr.Adres = txtAdres.Text;
            ogr.Hakkında = txtHakkında.Text;
            ogr.Resim = ImageToString(pictureBox1.Image);

            if (rdbKadın.Checked)
            {
                ogr.Cinsiyet = "Kadın";
            }
            else if (rdbErkek.Checked)
            {
                ogr.Cinsiyet = "Erkek";
            }
            else
            {
                ogr.Cinsiyet = "Girilmedi";
            }


            ogr.Sertifika = cmbSertifika.Text;


            return ogr;



        }


        private void btnResimGüncelle_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if (ofd.FileName != " ")
            {

                pictureBox1.Image = Image.FromFile(ofd.FileName);

            }
            else
            {       // picture box'a daga önceden projemşze e

                if (DialogResult.No == MessageBox.Show("Eski Resim Kalsın mı ?", "Resim", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
                    pictureBox1.Image = Properties.Resources.Image1;

            }

        }


        private void btnSil_Click(object sender, EventArgs e)
        {

            int OgrNo;

            bool SilindiMi;

            OgrNo = int.Parse(txtOgrNo.Text);

            VeriTabanıİşlmeleri vti = new VeriTabanıİşlmeleri();

            SilindiMi = vti.ÖğrenciSil(OgrNo);

            if (SilindiMi)
            {
                MessageBox.Show(OgrNo + " Nolu Öğrenci Silindi");
                ÖğrencileriListele();
            }
            else
            {
                MessageBox.Show(OgrNo + " Nolu Öğrenci Silinemedi!!!!");
            }


        }


    }



}
