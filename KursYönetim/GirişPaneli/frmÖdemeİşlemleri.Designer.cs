namespace GirişPaneli
{
    partial class frmÖdemeİşlemleri
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
            this.lblOgrNo = new System.Windows.Forms.Label();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.btnTaksitGetir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblÖdenecekMiktar = new System.Windows.Forms.Label();
            this.txtÖdenecekMiktar = new System.Windows.Forms.TextBox();
            this.btnÖdenmişTaksitler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOgrNo
            // 
            this.lblOgrNo.AutoSize = true;
            this.lblOgrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrNo.Location = new System.Drawing.Point(12, 30);
            this.lblOgrNo.Name = "lblOgrNo";
            this.lblOgrNo.Size = new System.Drawing.Size(79, 13);
            this.lblOgrNo.TabIndex = 0;
            this.lblOgrNo.Text = "Öğrenci No :";
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOgrNo.Location = new System.Drawing.Point(89, 27);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(202, 20);
            this.txtOgrNo.TabIndex = 2;
            // 
            // btnTaksitGetir
            // 
            this.btnTaksitGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaksitGetir.Location = new System.Drawing.Point(322, 25);
            this.btnTaksitGetir.Name = "btnTaksitGetir";
            this.btnTaksitGetir.Size = new System.Drawing.Size(144, 23);
            this.btnTaksitGetir.TabIndex = 4;
            this.btnTaksitGetir.Text = "Taksitleri Getir";
            this.btnTaksitGetir.UseVisualStyleBackColor = true;
            this.btnTaksitGetir.Click += new System.EventHandler(this.btnTaksitGetir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(15, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 291);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ödeme";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Ödeme Yap";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // lblÖdenecekMiktar
            // 
            this.lblÖdenecekMiktar.AutoSize = true;
            this.lblÖdenecekMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblÖdenecekMiktar.Location = new System.Drawing.Point(12, 60);
            this.lblÖdenecekMiktar.Name = "lblÖdenecekMiktar";
            this.lblÖdenecekMiktar.Size = new System.Drawing.Size(112, 13);
            this.lblÖdenecekMiktar.TabIndex = 7;
            this.lblÖdenecekMiktar.Text = "Ödenecek Miktar :";
            // 
            // txtÖdenecekMiktar
            // 
            this.txtÖdenecekMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtÖdenecekMiktar.Location = new System.Drawing.Point(130, 57);
            this.txtÖdenecekMiktar.Name = "txtÖdenecekMiktar";
            this.txtÖdenecekMiktar.Size = new System.Drawing.Size(164, 20);
            this.txtÖdenecekMiktar.TabIndex = 8;
            // 
            // btnÖdenmişTaksitler
            // 
            this.btnÖdenmişTaksitler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnÖdenmişTaksitler.Location = new System.Drawing.Point(322, 54);
            this.btnÖdenmişTaksitler.Name = "btnÖdenmişTaksitler";
            this.btnÖdenmişTaksitler.Size = new System.Drawing.Size(144, 23);
            this.btnÖdenmişTaksitler.TabIndex = 9;
            this.btnÖdenmişTaksitler.Text = "Ödenmiş Taksitler";
            this.btnÖdenmişTaksitler.UseVisualStyleBackColor = true;
            this.btnÖdenmişTaksitler.Click += new System.EventHandler(this.btnÖdenmişTaksitler_Click);
            // 
            // frmÖdemeİşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.btnÖdenmişTaksitler);
            this.Controls.Add(this.txtÖdenecekMiktar);
            this.Controls.Add(this.lblÖdenecekMiktar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTaksitGetir);
            this.Controls.Add(this.txtOgrNo);
            this.Controls.Add(this.lblOgrNo);
            this.Name = "frmÖdemeİşlemleri";
            this.Text = "frmÖdemeİşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgrNo;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.Button btnTaksitGetir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Label lblÖdenecekMiktar;
        private System.Windows.Forms.TextBox txtÖdenecekMiktar;
        private System.Windows.Forms.Button btnÖdenmişTaksitler;
    }
}