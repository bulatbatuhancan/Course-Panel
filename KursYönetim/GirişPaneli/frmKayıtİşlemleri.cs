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
    public partial class frmKayıtİşlemleri : Form
    {
        public frmKayıtİşlemleri()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            pngResim.Image = Image.FromFile(ofd.FileName);
        }


        Öğrenci ogr = new Öğrenci();

        public static ÖdemePlanı ödemePlanı;


        private void button3_Click(object sender, EventArgs e)
        { // Kayıt ekle Butonu



            ogr.Adı = TxtAdıSoyadı.Text;
            ogr.Soyadı = TxtAdıSoyadı.Text;
            ogr.KayıtDurumu = rdKesin.Checked == true ? "Kesin Kayıt" : "Ön Kayıt";
            ogr.Eğitim = cmbEğitim.Text;

            ogr.TCno = TxtTcNo.Text;
            ogr.Telefon = TxtTelefon.Text;
            ogr.Mail = TxtMail.Text;

            if (ComboMeslek.Text == "ÜnvÖğrencisi" )
            {
                ogr.Meslek = Meslekler.ÜnvÖğrencisi;
            }
            else if (ComboMeslek.Text == "LiseÖğrencisi")
            {
                ogr.Meslek = Meslekler.LiseÖğrencisi;
            }
            else if (ComboMeslek.Text == "Mühendis")
            {
                ogr.Meslek = Meslekler.Mühendis;
            }
            else if (ComboMeslek.Text == "Çalışan")
            {
                ogr.Meslek = Meslekler.Çalışan;
            }
            else if (ComboMeslek.Text == "Diğer")
            {
                ogr.Meslek = Meslekler.Diğer;
            }

            ogr.DoğumTarihi = DTDoğum.Value;
            ogr.Adres = TxtAdres.Text;
            ogr.Hakkında = TxtHakkında.Text;
            ogr.Resim = ImageToString(pngResim.Image);
            ogr.Sertifika = "Verilmedi";

            if (rdKadın.Checked)
            {
                ogr.Cinsiyet = "Kadın";
            }
            else if (rdErkek.Checked)
            {
                ogr.Cinsiyet = "Erkek";
            }
            else
            {
                ogr.Cinsiyet = "Girilmedi";
            }


            ogr.ödPlanı = ödemePlanı;


            // frmAnaPanel.ÖğrenciListesi.Add(ogr);

            // Öğrenci Bilgilerini formdan aldık SQL e bağlantı kuran klasa gönderiyoruz


            if (ogr.ödPlanı == null && ogr.KayıtDurumu == "Kesin Kayıt")
            {
                MessageBox.Show("Ödeme Durumu Eklemediniz!!");
            }
            else
            {
                VeriTabanıİşlmeleri vti = new VeriTabanıİşlmeleri();
                bool eklendiMi = vti.ÖğrenciBilgisiEkle(ogr);

                if (eklendiMi)
                {
                    MessageBox.Show("Öğrenci Eklendi");
                }
                else
                {
                    MessageBox.Show("Öğrenci Eklenmedi!!!!");
                }

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






        private void TxtAdıSoyadı_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdÖn_CheckedChanged(object sender, EventArgs e)
        {
            if (rdÖn.Checked)
            {
                btnÖdemePlanı.Enabled = false;
            }
            else
            {
                btnÖdemePlanı.Enabled = true;
            }
        }




        private void btnÖdeme(object sender, EventArgs e)
        {
            frmÖdemePlanı ofd = new frmÖdemePlanı();
            ofd.ShowDialog();
        }

        private void frmKayıtİşlemleri_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pngResim_Click(object sender, EventArgs e)
        {

        }

        private void rdErkek_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
