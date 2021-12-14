namespace GirişPaneli
{
    partial class FrmGirişPaneli
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grşbttn = new System.Windows.Forms.Button();
            this.vzgçbttn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Yönetim Programı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(32, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(84, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullanıcıAdı.ForeColor = System.Drawing.Color.Maroon;
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(155, 125);
            this.txtKullanıcıAdı.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(326, 22);
            this.txtKullanıcıAdı.TabIndex = 1;
            this.txtKullanıcıAdı.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtKullanıcıAdı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullanıcıAdı_KeyPress);
            // 
            // txtŞifre
            // 
            this.txtŞifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtŞifre.ForeColor = System.Drawing.Color.Maroon;
            this.txtŞifre.Location = new System.Drawing.Point(155, 173);
            this.txtŞifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.PasswordChar = '*';
            this.txtŞifre.Size = new System.Drawing.Size(326, 22);
            this.txtŞifre.TabIndex = 2;
            this.txtŞifre.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(345, 208);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grşbttn
            // 
            this.grşbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grşbttn.ForeColor = System.Drawing.Color.Maroon;
            this.grşbttn.Location = new System.Drawing.Point(175, 246);
            this.grşbttn.Margin = new System.Windows.Forms.Padding(4);
            this.grşbttn.Name = "grşbttn";
            this.grşbttn.Size = new System.Drawing.Size(112, 28);
            this.grşbttn.TabIndex = 3;
            this.grşbttn.Text = "Giriş";
            this.grşbttn.UseVisualStyleBackColor = true;
            this.grşbttn.Click += new System.EventHandler(this.btnGiriş);
            // 
            // vzgçbttn
            // 
            this.vzgçbttn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.vzgçbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vzgçbttn.ForeColor = System.Drawing.Color.Maroon;
            this.vzgçbttn.Location = new System.Drawing.Point(345, 246);
            this.vzgçbttn.Margin = new System.Windows.Forms.Padding(4);
            this.vzgçbttn.Name = "vzgçbttn";
            this.vzgçbttn.Size = new System.Drawing.Size(112, 28);
            this.vzgçbttn.TabIndex = 4;
            this.vzgçbttn.Text = "Vazgeç";
            this.vzgçbttn.UseVisualStyleBackColor = true;
            this.vzgçbttn.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmGirişPaneli
            // 
            this.AcceptButton = this.grşbttn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.CancelButton = this.vzgçbttn;
            this.ClientSize = new System.Drawing.Size(615, 330);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.vzgçbttn);
            this.Controls.Add(this.grşbttn);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.txtKullanıcıAdı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGirişPaneli";
            this.Text = "Giriş Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGirişPaneli_FormClosing);
            this.Load += new System.EventHandler(this.FrmGirişPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button grşbttn;
        private System.Windows.Forms.Button vzgçbttn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

