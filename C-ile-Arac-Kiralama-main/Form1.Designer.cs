namespace Arac_kiralama
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_uye = new System.Windows.Forms.Button();
            this.btn_Eposta = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.btn_sifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btn_yonetici = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Location = new System.Drawing.Point(58, 110);
            this.btn_giris.Margin = new System.Windows.Forms.Padding(2);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(78, 26);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_uye
            // 
            this.btn_uye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uye.Location = new System.Drawing.Point(212, 111);
            this.btn_uye.Margin = new System.Windows.Forms.Padding(2);
            this.btn_uye.Name = "btn_uye";
            this.btn_uye.Size = new System.Drawing.Size(78, 26);
            this.btn_uye.TabIndex = 5;
            this.btn_uye.Text = "Üye Ol";
            this.btn_uye.UseVisualStyleBackColor = true;
            this.btn_uye.Click += new System.EventHandler(this.btn_uye_Click);
            // 
            // btn_Eposta
            // 
            this.btn_Eposta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Eposta.Location = new System.Drawing.Point(21, 18);
            this.btn_Eposta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_Eposta.Name = "btn_Eposta";
            this.btn_Eposta.Size = new System.Drawing.Size(102, 27);
            this.btn_Eposta.TabIndex = 7;
            this.btn_Eposta.Text = "Eposta";
            this.btn_Eposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEposta
            // 
            this.txtEposta.BackColor = System.Drawing.Color.IndianRed;
            this.txtEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEposta.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEposta.Location = new System.Drawing.Point(152, 18);
            this.txtEposta.Margin = new System.Windows.Forms.Padding(2);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(191, 26);
            this.txtEposta.TabIndex = 8;
            // 
            // btn_sifre
            // 
            this.btn_sifre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sifre.Location = new System.Drawing.Point(19, 61);
            this.btn_sifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_sifre.Name = "btn_sifre";
            this.btn_sifre.Size = new System.Drawing.Size(104, 24);
            this.btn_sifre.TabIndex = 9;
            this.btn_sifre.Text = "Şifre";
            this.btn_sifre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.IndianRed;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(152, 61);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(191, 26);
            this.txtSifre.TabIndex = 10;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // btn_yonetici
            // 
            this.btn_yonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yonetici.Location = new System.Drawing.Point(665, 356);
            this.btn_yonetici.Margin = new System.Windows.Forms.Padding(2);
            this.btn_yonetici.Name = "btn_yonetici";
            this.btn_yonetici.Size = new System.Drawing.Size(234, 33);
            this.btn_yonetici.TabIndex = 11;
            this.btn_yonetici.Text = "Yönetici Girişi için Tıklayın";
            this.btn_yonetici.UseVisualStyleBackColor = true;
            this.btn_yonetici.Click += new System.EventHandler(this.btn_yonetici_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(149, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "veya";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.btn_sifre);
            this.groupBox1.Controls.Add(this.txtEposta);
            this.groupBox1.Controls.Add(this.btn_Eposta);
            this.groupBox1.Controls.Add(this.btn_uye);
            this.groupBox1.Controls.Add(this.btn_giris);
            this.groupBox1.Location = new System.Drawing.Point(609, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 180);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Girişi";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Location = new System.Drawing.Point(76, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 437);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikis.Location = new System.Drawing.Point(751, 450);
            this.btn_Cikis.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(110, 31);
            this.btn_Cikis.TabIndex = 16;
            this.btn_Cikis.Text = "Çıkış Yap";
            this.btn_Cikis.UseVisualStyleBackColor = true;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1032, 576);
            this.Controls.Add(this.btn_Cikis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_yonetici);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_uye;
        private System.Windows.Forms.Label btn_Eposta;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label btn_sifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btn_yonetici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cikis;
    }
}

