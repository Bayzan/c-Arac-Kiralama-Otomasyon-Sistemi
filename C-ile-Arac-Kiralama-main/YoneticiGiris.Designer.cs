namespace Arac_kiralama
{
    partial class YoneticiGiris
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYoneticiSifre = new System.Windows.Forms.TextBox();
            this.btn_sifre = new System.Windows.Forms.Label();
            this.txtYoneticiEposta = new System.Windows.Forms.TextBox();
            this.btn_Ad = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_geriDon = new System.Windows.Forms.Button();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.txtYoneticiSifre);
            this.groupBox1.Controls.Add(this.btn_sifre);
            this.groupBox1.Controls.Add(this.txtYoneticiEposta);
            this.groupBox1.Controls.Add(this.btn_Ad);
            this.groupBox1.Controls.Add(this.btn_giris);
            this.groupBox1.Location = new System.Drawing.Point(191, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 176);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // txtYoneticiSifre
            // 
            this.txtYoneticiSifre.BackColor = System.Drawing.Color.IndianRed;
            this.txtYoneticiSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiSifre.Location = new System.Drawing.Point(152, 61);
            this.txtYoneticiSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtYoneticiSifre.Name = "txtYoneticiSifre";
            this.txtYoneticiSifre.Size = new System.Drawing.Size(233, 26);
            this.txtYoneticiSifre.TabIndex = 10;
            this.txtYoneticiSifre.UseSystemPasswordChar = true;
            // 
            // btn_sifre
            // 
            this.btn_sifre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sifre.Location = new System.Drawing.Point(32, 61);
            this.btn_sifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_sifre.Name = "btn_sifre";
            this.btn_sifre.Size = new System.Drawing.Size(104, 28);
            this.btn_sifre.TabIndex = 9;
            this.btn_sifre.Text = "Şifre";
            this.btn_sifre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtYoneticiEposta
            // 
            this.txtYoneticiEposta.BackColor = System.Drawing.Color.IndianRed;
            this.txtYoneticiEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiEposta.ForeColor = System.Drawing.SystemColors.Window;
            this.txtYoneticiEposta.Location = new System.Drawing.Point(152, 14);
            this.txtYoneticiEposta.Margin = new System.Windows.Forms.Padding(2);
            this.txtYoneticiEposta.Name = "txtYoneticiEposta";
            this.txtYoneticiEposta.Size = new System.Drawing.Size(233, 26);
            this.txtYoneticiEposta.TabIndex = 8;
            // 
            // btn_Ad
            // 
            this.btn_Ad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ad.Location = new System.Drawing.Point(32, 19);
            this.btn_Ad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_Ad.Name = "btn_Ad";
            this.btn_Ad.Size = new System.Drawing.Size(102, 27);
            this.btn_Ad.TabIndex = 7;
            this.btn_Ad.Text = "E-posta";
            this.btn_Ad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_giris
            // 
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Location = new System.Drawing.Point(113, 123);
            this.btn_giris.Margin = new System.Windows.Forms.Padding(2);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(124, 36);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(220, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "Yönetici Girişi";
            // 
            // btn_geriDon
            // 
            this.btn_geriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geriDon.Location = new System.Drawing.Point(46, 49);
            this.btn_geriDon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_geriDon.Name = "btn_geriDon";
            this.btn_geriDon.Size = new System.Drawing.Size(124, 36);
            this.btn_geriDon.TabIndex = 16;
            this.btn_geriDon.Text = "Geri Dön";
            this.btn_geriDon.UseVisualStyleBackColor = true;
            this.btn_geriDon.Click += new System.EventHandler(this.btn_geriDon_Click);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikis.Location = new System.Drawing.Point(542, 49);
            this.btn_Cikis.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(124, 36);
            this.btn_Cikis.TabIndex = 17;
            this.btn_Cikis.Text = "Çıkış Yap";
            this.btn_Cikis.UseVisualStyleBackColor = true;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // YoneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(692, 419);
            this.Controls.Add(this.btn_Cikis);
            this.Controls.Add(this.btn_geriDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "YoneticiGiris";
            this.Text = "YoneticiGiris";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYoneticiSifre;
        private System.Windows.Forms.Label btn_sifre;
        private System.Windows.Forms.TextBox txtYoneticiEposta;
        private System.Windows.Forms.Label btn_Ad;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_geriDon;
        private System.Windows.Forms.Button btn_Cikis;
    }
}