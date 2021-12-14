namespace GirişPaneli
{
    partial class frmRaporlar
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
            this.btnEğitimGelirleri = new System.Windows.Forms.Button();
            this.btnÖdenmemiş = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKalanToplam = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblGelecek = new System.Windows.Forms.Label();
            this.lblGelecekÖdeme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEğitimGelirleri
            // 
            this.btnEğitimGelirleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEğitimGelirleri.Location = new System.Drawing.Point(13, 135);
            this.btnEğitimGelirleri.Margin = new System.Windows.Forms.Padding(4);
            this.btnEğitimGelirleri.Name = "btnEğitimGelirleri";
            this.btnEğitimGelirleri.Size = new System.Drawing.Size(165, 28);
            this.btnEğitimGelirleri.TabIndex = 0;
            this.btnEğitimGelirleri.Text = "Eğitim Gelirleri :";
            this.btnEğitimGelirleri.UseVisualStyleBackColor = true;
            this.btnEğitimGelirleri.Click += new System.EventHandler(this.btnToplamÖdemeler_Click);
            // 
            // btnÖdenmemiş
            // 
            this.btnÖdenmemiş.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnÖdenmemiş.Location = new System.Drawing.Point(13, 184);
            this.btnÖdenmemiş.Margin = new System.Windows.Forms.Padding(4);
            this.btnÖdenmemiş.Name = "btnÖdenmemiş";
            this.btnÖdenmemiş.Size = new System.Drawing.Size(165, 28);
            this.btnÖdenmemiş.TabIndex = 1;
            this.btnÖdenmemiş.Text = "Ödenmemiş :";
            this.btnÖdenmemiş.UseVisualStyleBackColor = true;
            this.btnÖdenmemiş.Click += new System.EventHandler(this.btnÖdenmemiş_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(186, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(771, 363);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 397);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toplam :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblKalanToplam
            // 
            this.lblKalanToplam.AutoSize = true;
            this.lblKalanToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKalanToplam.Location = new System.Drawing.Point(740, 397);
            this.lblKalanToplam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKalanToplam.Name = "lblKalanToplam";
            this.lblKalanToplam.Size = new System.Drawing.Size(56, 16);
            this.lblKalanToplam.TabIndex = 4;
            this.lblKalanToplam.Text = "............";
            this.lblKalanToplam.Click += new System.EventHandler(this.lblToplam_Click);
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(643, 397);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(56, 16);
            this.lblToplamTutar.TabIndex = 5;
            this.lblToplamTutar.Text = "............";
            // 
            // lblGelecek
            // 
            this.lblGelecek.AutoSize = true;
            this.lblGelecek.Location = new System.Drawing.Point(567, 429);
            this.lblGelecek.Name = "lblGelecek";
            this.lblGelecek.Size = new System.Drawing.Size(116, 16);
            this.lblGelecek.TabIndex = 6;
            this.lblGelecek.Text = "Ödenen Miktar :";
            // 
            // lblGelecekÖdeme
            // 
            this.lblGelecekÖdeme.AutoSize = true;
            this.lblGelecekÖdeme.Location = new System.Drawing.Point(740, 429);
            this.lblGelecekÖdeme.Name = "lblGelecekÖdeme";
            this.lblGelecekÖdeme.Size = new System.Drawing.Size(56, 16);
            this.lblGelecekÖdeme.TabIndex = 7;
            this.lblGelecekÖdeme.Text = "............";
            // 
            // frmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(977, 469);
            this.Controls.Add(this.lblGelecekÖdeme);
            this.Controls.Add(this.lblGelecek);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lblKalanToplam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnÖdenmemiş);
            this.Controls.Add(this.btnEğitimGelirleri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRaporlar";
            this.Text = "frmRaporlar";
            this.Load += new System.EventHandler(this.frmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEğitimGelirleri;
        private System.Windows.Forms.Button btnÖdenmemiş;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKalanToplam;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblGelecek;
        private System.Windows.Forms.Label lblGelecekÖdeme;
    }
}