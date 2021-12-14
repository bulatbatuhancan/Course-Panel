namespace GirişPaneli
{
    partial class frmÖdemeYap
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
            this.btnÖdemeYap = new System.Windows.Forms.Button();
            this.lblÖdenenMiktar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnÖdemeYap
            // 
            this.btnÖdemeYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnÖdemeYap.Location = new System.Drawing.Point(342, 53);
            this.btnÖdemeYap.Name = "btnÖdemeYap";
            this.btnÖdemeYap.Size = new System.Drawing.Size(145, 27);
            this.btnÖdemeYap.TabIndex = 0;
            this.btnÖdemeYap.Text = "Ödeme Yap";
            this.btnÖdemeYap.UseVisualStyleBackColor = true;
            // 
            // lblÖdenenMiktar
            // 
            this.lblÖdenenMiktar.AutoSize = true;
            this.lblÖdenenMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblÖdenenMiktar.Location = new System.Drawing.Point(21, 56);
            this.lblÖdenenMiktar.Name = "lblÖdenenMiktar";
            this.lblÖdenenMiktar.Size = new System.Drawing.Size(136, 20);
            this.lblÖdenenMiktar.TabIndex = 1;
            this.lblÖdenenMiktar.Text = "Ödenen Miktar :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(163, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 26);
            this.textBox1.TabIndex = 2;
            // 
            // frmÖdemeYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(500, 128);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblÖdenenMiktar);
            this.Controls.Add(this.btnÖdemeYap);
            this.Name = "frmÖdemeYap";
            this.Text = "frmÖdemeYap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnÖdemeYap;
        private System.Windows.Forms.Label lblÖdenenMiktar;
        private System.Windows.Forms.TextBox textBox1;
    }
}