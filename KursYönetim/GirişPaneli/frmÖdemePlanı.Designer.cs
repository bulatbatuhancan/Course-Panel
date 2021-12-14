namespace GirişPaneli
{
    partial class frmÖdemePlanı
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbToplamTutar = new System.Windows.Forms.ComboBox();
            this.txtPeşinat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbPeşin = new System.Windows.Forms.RadioButton();
            this.rdbTaksitli = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTaksitSayısı = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TaksitKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TaksitNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaksitTutarı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÖdemeTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÖdemeDurumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOgrNo = new System.Windows.Forms.Label();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Tutar : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Peşinat : ";
            // 
            // cmbToplamTutar
            // 
            this.cmbToplamTutar.FormattingEnabled = true;
            this.cmbToplamTutar.Items.AddRange(new object[] {
            "5000",
            "4500",
            "4000",
            "3500",
            "3000"});
            this.cmbToplamTutar.Location = new System.Drawing.Point(140, 54);
            this.cmbToplamTutar.Name = "cmbToplamTutar";
            this.cmbToplamTutar.Size = new System.Drawing.Size(315, 21);
            this.cmbToplamTutar.TabIndex = 1;
            // 
            // txtPeşinat
            // 
            this.txtPeşinat.Location = new System.Drawing.Point(140, 81);
            this.txtPeşinat.Name = "txtPeşinat";
            this.txtPeşinat.Size = new System.Drawing.Size(315, 20);
            this.txtPeşinat.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ödeme Biçimi :";
            // 
            // rdbPeşin
            // 
            this.rdbPeşin.AutoSize = true;
            this.rdbPeşin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPeşin.Location = new System.Drawing.Point(193, 127);
            this.rdbPeşin.Name = "rdbPeşin";
            this.rdbPeşin.Size = new System.Drawing.Size(71, 24);
            this.rdbPeşin.TabIndex = 4;
            this.rdbPeşin.TabStop = true;
            this.rdbPeşin.Text = "Peşin";
            this.rdbPeşin.UseVisualStyleBackColor = true;
            // 
            // rdbTaksitli
            // 
            this.rdbTaksitli.AutoSize = true;
            this.rdbTaksitli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTaksitli.Location = new System.Drawing.Point(336, 127);
            this.rdbTaksitli.Name = "rdbTaksitli";
            this.rdbTaksitli.Size = new System.Drawing.Size(83, 24);
            this.rdbTaksitli.TabIndex = 5;
            this.rdbTaksitli.TabStop = true;
            this.rdbTaksitli.Text = "Taksitli";
            this.rdbTaksitli.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Taksit Sayısı : ";
            // 
            // cmbTaksitSayısı
            // 
            this.cmbTaksitSayısı.FormattingEnabled = true;
            this.cmbTaksitSayısı.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbTaksitSayısı.Location = new System.Drawing.Point(140, 177);
            this.cmbTaksitSayısı.Name = "cmbTaksitSayısı";
            this.cmbTaksitSayısı.Size = new System.Drawing.Size(128, 21);
            this.cmbTaksitSayısı.TabIndex = 7;
            this.cmbTaksitSayısı.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(274, 177);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "İlk Ödem Tarihi :  ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 205);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(424, 171);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // TaksitKaydet
            // 
            this.TaksitKaydet.Location = new System.Drawing.Point(140, 525);
            this.TaksitKaydet.Name = "TaksitKaydet";
            this.TaksitKaydet.Size = new System.Drawing.Size(216, 23);
            this.TaksitKaydet.TabIndex = 10;
            this.TaksitKaydet.Text = "Kaydet";
            this.TaksitKaydet.UseVisualStyleBackColor = true;
            this.TaksitKaydet.Click += new System.EventHandler(this.TaksitKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaksitNo,
            this.TaksitTutarı,
            this.ÖdemeTarihi,
            this.ÖdemeDurumu});
            this.dataGridView1.Location = new System.Drawing.Point(12, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 316);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TaksitNo
            // 
            this.TaksitNo.HeaderText = "Taksit No";
            this.TaksitNo.Name = "TaksitNo";
            // 
            // TaksitTutarı
            // 
            this.TaksitTutarı.HeaderText = "Taksit Tutarı";
            this.TaksitTutarı.Name = "TaksitTutarı";
            // 
            // ÖdemeTarihi
            // 
            this.ÖdemeTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ÖdemeTarihi.HeaderText = "Ödeme Tarihi";
            this.ÖdemeTarihi.Name = "ÖdemeTarihi";
            // 
            // ÖdemeDurumu
            // 
            this.ÖdemeDurumu.HeaderText = "Ödeme Durumu";
            this.ÖdemeDurumu.Name = "ÖdemeDurumu";
            // 
            // lblOgrNo
            // 
            this.lblOgrNo.AutoSize = true;
            this.lblOgrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrNo.Location = new System.Drawing.Point(40, 29);
            this.lblOgrNo.Name = "lblOgrNo";
            this.lblOgrNo.Size = new System.Drawing.Size(94, 16);
            this.lblOgrNo.TabIndex = 12;
            this.lblOgrNo.Text = "Öğrenci No :";
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(140, 28);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(315, 20);
            this.txtOgrNo.TabIndex = 13;
            // 
            // frmÖdemePlanı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(493, 635);
            this.Controls.Add(this.txtOgrNo);
            this.Controls.Add(this.lblOgrNo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TaksitKaydet);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbTaksitSayısı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdbTaksitli);
            this.Controls.Add(this.rdbPeşin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPeşinat);
            this.Controls.Add(this.cmbToplamTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmÖdemePlanı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmÖdemePlanı";
            this.Load += new System.EventHandler(this.frmÖdemePlanı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbToplamTutar;
        private System.Windows.Forms.TextBox txtPeşinat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbPeşin;
        private System.Windows.Forms.RadioButton rdbTaksitli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTaksitSayısı;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button TaksitKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaksitNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaksitTutarı;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÖdemeTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÖdemeDurumu;
        public System.Windows.Forms.Label lblOgrNo;
        public System.Windows.Forms.TextBox txtOgrNo;
    }
}