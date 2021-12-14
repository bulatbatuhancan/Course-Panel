using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klaslar;

namespace GirişPaneli
{
    public partial class frmMail : Form
    {
        public frmMail()
        {
            InitializeComponent();
        }

        private void frmMail_Load(object sender, EventArgs e)
        {
            MailListesi();
        }

        void MailListesi()
        {
            VeriTabanıİşlmeleri vti = new VeriTabanıİşlmeleri();

            DataTable dt = vti.ÖğrenciMailleri();

            dataGridView1.DataSource = dt;

            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Alıcı = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (rdbKime.Checked)
            {
                LsKime.Items.Add(Alıcı);
            }
            else if (rdbCC.Checked)
            {
                LsCC.Items.Add(Alıcı);
            }
            else
            {
                MessageBox.Show("Alıcı Seçmediniz !!!");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LsKime_DoubleClick(object sender, EventArgs e)
        {
            LsKime.Items.RemoveAt(LsKime.SelectedIndex);
        }

        private void LsCC_DoubleClick(object sender, EventArgs e)
        {
            LsCC.Items.RemoveAt(LsCC.SelectedIndex);
        }

        private void btnDosyaEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.ShowDialog();

            if (ofd.FileName != "")
            {
                txtEk.Text = ofd.FileName;
            }
            else
            {
                MessageBox.Show("Dosya Seçmediniz !!");
            }

        }

        private void btnGönder_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.live.com";
            client.EnableSsl = true;

            client.Credentials = new NetworkCredential("batuhancanbulat@hotmail.com","password");

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(txtKimden.Text);

            foreach (string adres in LsKime.Items)
            {
                mail.To.Add(adres);
            }

            foreach (string adres in LsCC.Items)
            {
                mail.To.Add(adres);
            }

            mail.Subject = txtKonu.Text;

            mail.Attachments.Add(new Attachment(txtEk.Text));

            mail.Body = txtMail.Text;
            mail.IsBodyHtml = true;

            client.Send(mail);

            
        }
    }
}