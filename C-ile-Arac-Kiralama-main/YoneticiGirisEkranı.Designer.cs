namespace Arac_kiralama
{
    partial class YoneticiGirisEkranı
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btn_sifre = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.btn_Eposta = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_geriDon = new System.Windows.Forms.Button();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(272, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetici Giriş Ekranı";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.btn_sifre);
            this.groupBox1.Controls.Add(this.txtEposta);
            this.groupBox1.Controls.Add(this.btn_Eposta);
            this.groupBox1.Controls.Add(this.btn_giris);
            this.groupBox1.Location = new System.Drawing.Point(239, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 192);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.IndianRed;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(156, 76);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(138, 28);
            this.txtSifre.TabIndex = 10;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // btn_sifre
            // 
            this.btn_sifre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sifre.Location = new System.Drawing.Point(36, 76);
            this.btn_sifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_sifre.Name = "btn_sifre";
            this.btn_sifre.Size = new System.Drawing.Size(104, 24);
            this.btn_sifre.TabIndex = 9;
            this.btn_sifre.Text = "Şifre";
            this.btn_sifre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEposta
            // 
            this.txtEposta.BackColor = System.Drawing.Color.IndianRed;
            this.txtEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEposta.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEposta.Location = new System.Drawing.Point(156, 29);
            this.txtEposta.Margin = new System.Windows.Forms.Padding(2);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(138, 32);
            this.txtEposta.TabIndex = 8;
            // 
            // btn_Eposta
            // 
            this.btn_Eposta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Eposta.Location = new System.Drawing.Point(36, 34);
            this.btn_Eposta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_Eposta.Name = "btn_Eposta";
            this.btn_Eposta.Size = new System.Drawing.Size(102, 27);
            this.btn_Eposta.TabIndex = 7;
            this.btn_Eposta.Text = "Eposta";
            this.btn_Eposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_giris
            // 
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Location = new System.Drawing.Point(127, 135);
            this.btn_giris.Margin = new System.Windows.Forms.Padding(2);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(93, 32);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_geriDon
            // 
            this.btn_geriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geriDon.Location = new System.Drawing.Point(45, 34);
            this.btn_geriDon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_geriDon.Name = "btn_geriDon";
            this.btn_geriDon.Size = new System.Drawing.Size(93, 32);
            this.btn_geriDon.TabIndex = 15;
            this.btn_geriDon.Text = "Geri Dön";
            this.btn_geriDon.UseVisualStyleBackColor = true;
            this.btn_geriDon.Click += new System.EventHandler(this.btn_geriDon_Click);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikis.Location = new System.Drawing.Point(668, 34);
            this.btn_Cikis.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(93, 32);
            this.btn_Cikis.TabIndex = 16;
            this.btn_Cikis.Text = "Çıkış";
            this.btn_Cikis.UseVisualStyleBackColor = true;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // YoneticiGirisEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cikis);
            this.Controls.Add(this.btn_geriDon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "YoneticiGirisEkranı";
            this.Text = "YoneticiGirisEkranı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label btn_sifre;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label btn_Eposta;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_geriDon;
        private System.Windows.Forms.Button btn_Cikis;
    }
}