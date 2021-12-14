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

namespace GirişPaneli
{
    public partial class frmMüzik : Form
    {
        public frmMüzik()
        {
            InitializeComponent();
        }

        private void btnMüzikSeç_Click(object sender, EventArgs e)
        {
            string şarkıYolu = "";

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.ShowDialog();

            if (ofd.FileName != "")
            {
                axWindowsMediaPlayer1.URL = ofd.FileName;
            }
            else
            {

            }

        }

        private void frmMüzik_FormClosing(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer1.Dispose();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {

            string[] şarkıListesi = null;
            
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.ShowDialog();

            if (fb.SelectedPath != "")
            {
                şarkıListesi = Directory.GetFiles(fb.SelectedPath);

                FileInfo finfo;

                foreach (var şarkı in şarkıListesi)
                {
                    finfo = new FileInfo(şarkı);
                    listBox1.Items.Add(finfo.Name);
                }
            }
            else
            {

            }



            
        }
    }
}
