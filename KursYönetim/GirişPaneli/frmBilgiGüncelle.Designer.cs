namespace GirişPaneli
{
    partial class frmBilgiGüncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResimGüncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAdı = new System.Windows.Forms.TextBox();
            this.txtSoyadı = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.cmbEğitim = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rdbKesinKayıt = new System.Windows.Forms.RadioButton();
            this.rdbÖnKayıt = new System.Windows.Forms.RadioButton();
            this.rdbMezun = new System.Windows.Forms.RadioButton();
            this.cmbMeslek = new System.Windows.Forms.ComboBox();
            this.grpCinsiyet = new System.Windows.Forms.GroupBox();
            this.rdbKadın = new System.Windows.Forms.RadioButton();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtHakkında = new System.Windows.Forms.TextBox();
            this.lblSertifika = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblogrNo = new System.Windows.Forms.Label();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.cmbSertifika = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpCinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(191, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(613, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 173);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnResimGüncelle
            // 
            this.btnResimGüncelle.Location = new System.Drawing.Point(42, 216);
            this.btnResimGüncelle.Name = "btnResimGüncelle";
            this.btnResimGüncelle.Size = new System.Drawing.Size(117, 34);
            this.btnResimGüncelle.TabIndex = 2;
            this.btnResimGüncelle.Text = "Resim Güncelle";
            this.btnResimGüncelle.UseVisualStyleBackColor = true;
            this.btnResimGüncelle.Click += new System.EventHandler(this.btnResimGüncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Eğitim :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kayıt Durumu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "TC No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefon :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mail :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Meslek :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cinsiyet :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Adres :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(313, 427);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Doğum Tarihi : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(314, 451);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Hakkında :";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtAdı
            // 
            this.txtAdı.Location = new System.Drawing.Point(63, 290);
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.Size = new System.Drawing.Size(216, 20);
            this.txtAdı.TabIndex = 15;
            // 
            // txtSoyadı
            // 
            this.txtSoyadı.Location = new System.Drawing.Point(80, 317);
            this.txtSoyadı.Name = "txtSoyadı";
            this.txtSoyadı.Size = new System.Drawing.Size(199, 20);
            this.txtSoyadı.TabIndex = 16;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(351, 290);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(203, 20);
            this.txtMail.TabIndex = 17;
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(84, 427);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(195, 20);
            this.txtTCNo.TabIndex = 19;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(84, 453);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(195, 20);
            this.txtTelefon.TabIndex = 20;
            // 
            // cmbEğitim
            // 
            this.cmbEğitim.FormattingEnabled = true;
            this.cmbEğitim.Location = new System.Drawing.Point(77, 344);
            this.cmbEğitim.Name = "cmbEğitim";
            this.cmbEğitim.Size = new System.Drawing.Size(202, 21);
            this.cmbEğitim.TabIndex = 21;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(112, 371);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(167, 50);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // rdbKesinKayıt
            // 
            this.rdbKesinKayıt.AutoSize = true;
            this.rdbKesinKayıt.Location = new System.Drawing.Point(121, 379);
            this.rdbKesinKayıt.Name = "rdbKesinKayıt";
            this.rdbKesinKayıt.Size = new System.Drawing.Size(51, 17);
            this.rdbKesinKayıt.TabIndex = 23;
            this.rdbKesinKayıt.TabStop = true;
            this.rdbKesinKayıt.Text = "Kesin";
            this.rdbKesinKayıt.UseVisualStyleBackColor = true;
            // 
            // rdbÖnKayıt
            // 
            this.rdbÖnKayıt.AutoSize = true;
            this.rdbÖnKayıt.Location = new System.Drawing.Point(205, 379);
            this.rdbÖnKayıt.Name = "rdbÖnKayıt";
            this.rdbÖnKayıt.Size = new System.Drawing.Size(65, 17);
            this.rdbÖnKayıt.TabIndex = 24;
            this.rdbÖnKayıt.TabStop = true;
            this.rdbÖnKayıt.Text = "Ön Kayıt";
            this.rdbÖnKayıt.UseVisualStyleBackColor = true;
            // 
            // rdbMezun
            // 
            this.rdbMezun.AutoSize = true;
            this.rdbMezun.Location = new System.Drawing.Point(121, 400);
            this.rdbMezun.Name = "rdbMezun";
            this.rdbMezun.Size = new System.Drawing.Size(57, 17);
            this.rdbMezun.TabIndex = 25;
            this.rdbMezun.TabStop = true;
            this.rdbMezun.Text = "Mezun";
            this.rdbMezun.UseVisualStyleBackColor = true;
            // 
            // cmbMeslek
            // 
            this.cmbMeslek.FormattingEnabled = true;
            this.cmbMeslek.Location = new System.Drawing.Point(366, 317);
            this.cmbMeslek.Name = "cmbMeslek";
            this.cmbMeslek.Size = new System.Drawing.Size(188, 21);
            this.cmbMeslek.TabIndex = 26;
            // 
            // grpCinsiyet
            // 
            this.grpCinsiyet.Controls.Add(this.rdbKadın);
            this.grpCinsiyet.Controls.Add(this.rdbErkek);
            this.grpCinsiyet.Location = new System.Drawing.Point(371, 344);
            this.grpCinsiyet.Name = "grpCinsiyet";
            this.grpCinsiyet.Size = new System.Drawing.Size(183, 49);
            this.grpCinsiyet.TabIndex = 27;
            this.grpCinsiyet.TabStop = false;
            // 
            // rdbKadın
            // 
            this.rdbKadın.AutoSize = true;
            this.rdbKadın.Location = new System.Drawing.Point(100, 19);
            this.rdbKadın.Name = "rdbKadın";
            this.rdbKadın.Size = new System.Drawing.Size(52, 17);
            this.rdbKadın.TabIndex = 1;
            this.rdbKadın.TabStop = true;
            this.rdbKadın.Text = "Kadın";
            this.rdbKadın.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Location = new System.Drawing.Point(26, 19);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(53, 17);
            this.rdbErkek.TabIndex = 0;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(359, 397);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(195, 20);
            this.txtAdres.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(387, 422);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // txtHakkında
            // 
            this.txtHakkında.Location = new System.Drawing.Point(379, 448);
            this.txtHakkında.Name = "txtHakkında";
            this.txtHakkında.Size = new System.Drawing.Size(175, 20);
            this.txtHakkında.TabIndex = 30;
            // 
            // lblSertifika
            // 
            this.lblSertifika.AutoSize = true;
            this.lblSertifika.Location = new System.Drawing.Point(587, 293);
            this.lblSertifika.Name = "lblSertifika";
            this.lblSertifika.Size = new System.Drawing.Size(51, 13);
            this.lblSertifika.TabIndex = 31;
            this.lblSertifika.Text = "Sertifica :";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(645, 341);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(159, 39);
            this.btnGüncelle.TabIndex = 33;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(645, 412);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(159, 43);
            this.btnSil.TabIndex = 34;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblogrNo
            // 
            this.lblogrNo.AutoSize = true;
            this.lblogrNo.Location = new System.Drawing.Point(188, 13);
            this.lblogrNo.Name = "lblogrNo";
            this.lblogrNo.Size = new System.Drawing.Size(67, 13);
            this.lblogrNo.TabIndex = 35;
            this.lblogrNo.Text = "Öğrenci No :";
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Enabled = false;
            this.txtOgrNo.Location = new System.Drawing.Point(261, 10);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(186, 20);
            this.txtOgrNo.TabIndex = 36;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(468, 8);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 37;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            // 
            // cmbSertifika
            // 
            this.cmbSertifika.FormattingEnabled = true;
            this.cmbSertifika.Items.AddRange(new object[] {
            "Verildi",
            "Verilmedi"});
            this.cmbSertifika.Location = new System.Drawing.Point(644, 290);
            this.cmbSertifika.Name = "cmbSertifika";
            this.cmbSertifika.Size = new System.Drawing.Size(160, 21);
            this.cmbSertifika.TabIndex = 38;
            this.cmbSertifika.SelectedIndexChanged += new System.EventHandler(this.cmbSertifika_SelectedIndexChanged);
            // 
            // frmBilgiGüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(825, 497);
            this.Controls.Add(this.cmbSertifika);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtOgrNo);
            this.Controls.Add(this.lblogrNo);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.lblSertifika);
            this.Controls.Add(this.txtHakkında);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.grpCinsiyet);
            this.Controls.Add(this.cmbMeslek);
            this.Controls.Add(this.rdbMezun);
            this.Controls.Add(this.rdbÖnKayıt);
            this.Controls.Add(this.rdbKesinKayıt);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cmbEğitim);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtTCNo);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSoyadı);
            this.Controls.Add(this.txtAdı);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResimGüncelle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBilgiGüncelle";
            this.Text = "frmBilgiGüncelle";
            this.Load += new System.EventHandler(this.frmBilgiGüncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpCinsiyet.ResumeLayout(false);
            this.grpCinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnResimGüncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAdı;
        private System.Windows.Forms.TextBox txtSoyadı;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.ComboBox cmbEğitim;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton rdbKesinKayıt;
        private System.Windows.Forms.RadioButton rdbÖnKayıt;
        private System.Windows.Forms.RadioButton rdbMezun;
        private System.Windows.Forms.ComboBox cmbMeslek;
        private System.Windows.Forms.GroupBox grpCinsiyet;
        private System.Windows.Forms.RadioButton rdbKadın;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtHakkında;
        private System.Windows.Forms.Label lblSertifika;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblogrNo;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.ComboBox cmbSertifika;
    }
}