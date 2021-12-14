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
    public partial class frmÖğrenciListesi : Form
    {
        public frmÖğrenciListesi()
        {
            InitializeComponent();
        }

        private void frmÖğrenciListesi_Load(object sender, EventArgs e)
        {
            ogrListesi();
        }




        void ogrListesi()
        {
            System.Collections.IList list = frmAnaPanel.ÖğrenciListesi;
            for (int i = 0; i < list.Count; i++)
            {
                Öğrenci ogr = (Öğrenci)list[i];
                richTextBox1.AppendText(" ");
                richTextBox1.AppendText("Adı: " + " " + ogr.Adı + "\n");
                richTextBox1.AppendText(" ");
                richTextBox1.AppendText("TC No: " + " " + ogr.TCno + "\n");
                richTextBox1.AppendText(" ");
                richTextBox1.AppendText("Telefon: " + " " + "+9" + ogr.Telefon + "\n");
                richTextBox1.AppendText(" ");
                richTextBox1.AppendText("Mail: " + " " + ogr.Mail + "\n");
                richTextBox1.AppendText(" ");
                richTextBox1.AppendText("Cinsiyet: " + " " + ogr.Cinsiyet + "\n");
                richTextBox1.AppendText(" ");
                richTextBox1.AppendText("Meslek: " + " " + ogr.Meslek + "\n");
                richTextBox1.AppendText(" ");
                richTextBox1.AppendText("Doğum Tarihi: " + " " + ogr.DoğumTarihi + "\n");
                richTextBox1.AppendText(" ");
                richTextBox1.AppendText("Adres: " + " " + ogr.Adres + "\n");
                richTextBox1.AppendText(" ");
                richTextBox1.AppendText("Hakkında: " + ogr.Hakkında + "\n");
                richTextBox1.AppendText(" ");
                richTextBox1.AppendText("Resim: " + ogr.Resim + "\n");
            }



        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
