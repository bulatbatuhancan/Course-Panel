namespace GirişPaneli
{
    partial class frmMail
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
            this.lblKimden = new System.Windows.Forms.Label();
            this.lblKime = new System.Windows.Forms.Label();
            this.lblCC = new System.Windows.Forms.Label();
            this.lblKonu = new System.Windows.Forms.Label();
            this.lblEk = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtKimden = new System.Windows.Forms.TextBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.txtEk = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.LsKime = new System.Windows.Forms.ListBox();
            this.LsCC = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCC = new System.Windows.Forms.RadioButton();
            this.rdbKime = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGönder = new System.Windows.Forms.Button();
            this.btnDosyaEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKimden
            // 
            this.lblKimden.AutoSize = true;
            this.lblKimden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKimden.Location = new System.Drawing.Point(-1, 41);
            this.lblKimden.Name = "lblKimden";
            this.lblKimden.Size = new System.Drawing.Size(67, 16);
            this.lblKimden.TabIndex = 0;
            this.lblKimden.Text = "Kimden :";
            // 
            // lblKime
            // 
            this.lblKime.AutoSize = true;
            this.lblKime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKime.Location = new System.Drawing.Point(11, 86);
            this.lblKime.Name = "lblKime";
            this.lblKime.Size = new System.Drawing.Size(50, 16);
            this.lblKime.TabIndex = 1;
            this.lblKime.Text = "Kime :";
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCC.Location = new System.Drawing.Point(20, 158);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(36, 16);
            this.lblCC.TabIndex = 2;
            this.lblCC.Text = "CC :";
            // 
            // lblKonu
            // 
            this.lblKonu.AutoSize = true;
            this.lblKonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKonu.Location = new System.Drawing.Point(9, 230);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(50, 16);
            this.lblKonu.TabIndex = 3;
            this.lblKonu.Text = "Konu :";
            // 
            // lblEk
            // 
            this.lblEk.AutoSize = true;
            this.lblEk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEk.Location = new System.Drawing.Point(21, 274);
            this.lblEk.Name = "lblEk";
            this.lblEk.Size = new System.Drawing.Size(34, 16);
            this.lblEk.TabIndex = 4;
            this.lblEk.Text = "Ek :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(15, 323);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(45, 16);
            this.lblMail.TabIndex = 5;
            this.lblMail.Text = "Mail :";
            // 
            // txtKimden
            // 
            this.txtKimden.Location = new System.Drawing.Point(66, 40);
            this.txtKimden.Name = "txtKimden";
            this.txtKimden.Size = new System.Drawing.Size(187, 20);
            this.txtKimden.TabIndex = 6;
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(66, 229);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(187, 20);
            this.txtKonu.TabIndex = 7;
            // 
            // txtEk
            // 
            this.txtEk.Location = new System.Drawing.Point(66, 273);
            this.txtEk.Name = "txtEk";
            this.txtEk.Size = new System.Drawing.Size(187, 20);
            this.txtEk.TabIndex = 8;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(66, 322);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(300, 157);
            this.txtMail.TabIndex = 9;
            // 
            // LsKime
            // 
            this.LsKime.FormattingEnabled = true;
            this.LsKime.Location = new System.Drawing.Point(66, 88);
            this.LsKime.Name = "LsKime";
            this.LsKime.Size = new System.Drawing.Size(187, 43);
            this.LsKime.TabIndex = 10;
            this.LsKime.DoubleClick += new System.EventHandler(this.LsKime_DoubleClick);
            // 
            // LsCC
            // 
            this.LsCC.FormattingEnabled = true;
            this.LsCC.Location = new System.Drawing.Point(66, 160);
            this.LsCC.Name = "LsCC";
            this.LsCC.Size = new System.Drawing.Size(187, 43);
            this.LsCC.TabIndex = 11;
            this.LsCC.DoubleClick += new System.EventHandler(this.LsCC_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCC);
            this.groupBox1.Controls.Add(this.rdbKime);
            this.groupBox1.Location = new System.Drawing.Point(259, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 124);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // rdbCC
            // 
            this.rdbCC.AutoSize = true;
            this.rdbCC.Location = new System.Drawing.Point(6, 90);
            this.rdbCC.Name = "rdbCC";
            this.rdbCC.Size = new System.Drawing.Size(61, 17);
            this.rdbCC.TabIndex = 1;
            this.rdbCC.TabStop = true;
            this.rdbCC.Text = "<<<<<<";
            this.rdbCC.UseVisualStyleBackColor = true;
            // 
            // rdbKime
            // 
            this.rdbKime.AutoSize = true;
            this.rdbKime.Location = new System.Drawing.Point(6, 19);
            this.rdbKime.Name = "rdbKime";
            this.rdbKime.Size = new System.Drawing.Size(61, 17);
            this.rdbKime.TabIndex = 0;
            this.rdbKime.TabStop = true;
            this.rdbKime.Text = "<<<<<<";
            this.rdbKime.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(372, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(412, 250);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btnGönder
            // 
            this.btnGönder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGönder.Location = new System.Drawing.Point(372, 323);
            this.btnGönder.Name = "btnGönder";
            this.btnGönder.Size = new System.Drawing.Size(412, 157);
            this.btnGönder.TabIndex = 14;
            this.btnGönder.Text = "GÖNDER";
            this.btnGönder.UseVisualStyleBackColor = true;
            this.btnGönder.Click += new System.EventHandler(this.btnGönder_Click);
            // 
            // btnDosyaEkle
            // 
            this.btnDosyaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDosyaEkle.Location = new System.Drawing.Point(259, 260);
            this.btnDosyaEkle.Name = "btnDosyaEkle";
            this.btnDosyaEkle.Size = new System.Drawing.Size(93, 45);
            this.btnDosyaEkle.TabIndex = 15;
            this.btnDosyaEkle.Text = "Dosya Ekle";
            this.btnDosyaEkle.UseVisualStyleBackColor = true;
            this.btnDosyaEkle.Click += new System.EventHandler(this.btnDosyaEkle_Click);
            // 
            // frmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(796, 515);
            this.Controls.Add(this.btnDosyaEkle);
            this.Controls.Add(this.btnGönder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LsCC);
            this.Controls.Add(this.LsKime);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtEk);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.txtKimden);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblEk);
            this.Controls.Add(this.lblKonu);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.lblKime);
            this.Controls.Add(this.lblKimden);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmMail";
            this.Text = "frmMail";
            this.Load += new System.EventHandler(this.frmMail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKimden;
        private System.Windows.Forms.Label lblKime;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Label lblKonu;
        private System.Windows.Forms.Label lblEk;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtKimden;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.TextBox txtEk;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ListBox LsKime;
        private System.Windows.Forms.ListBox LsCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCC;
        private System.Windows.Forms.RadioButton rdbKime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGönder;
        private System.Windows.Forms.Button btnDosyaEkle;
    }
}