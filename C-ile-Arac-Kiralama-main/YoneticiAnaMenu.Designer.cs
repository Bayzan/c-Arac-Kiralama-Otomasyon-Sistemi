namespace Arac_kiralama
{
    partial class YoneticiAnaMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiAnaMenu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_saat = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btn_Kiralamalar = new System.Windows.Forms.Button();
            this.btn_aracekle = new System.Windows.Forms.Button();
            this.btn_sifredegistir = new System.Windows.Forms.Button();
            this.btn_uyeler = new System.Windows.Forms.Button();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.btn_harita = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_saat);
            this.groupBox1.Controls.Add(this.lbl_isim);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label_saat
            // 
            this.label_saat.AutoSize = true;
            this.label_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_saat.Location = new System.Drawing.Point(595, 20);
            this.label_saat.Name = "label_saat";
            this.label_saat.Size = new System.Drawing.Size(0, 20);
            this.label_saat.TabIndex = 1;
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_isim.Location = new System.Drawing.Point(63, 20);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(0, 20);
            this.lbl_isim.TabIndex = 0;
            // 
            // timerSaat
            // 
            this.timerSaat.Interval = 1000;
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Location = new System.Drawing.Point(298, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn_Kiralamalar
            // 
            this.btn_Kiralamalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kiralamalar.Location = new System.Drawing.Point(40, 107);
            this.btn_Kiralamalar.Name = "btn_Kiralamalar";
            this.btn_Kiralamalar.Size = new System.Drawing.Size(167, 31);
            this.btn_Kiralamalar.TabIndex = 2;
            this.btn_Kiralamalar.Text = "Mevcut Kiralamalar";
            this.btn_Kiralamalar.UseVisualStyleBackColor = true;
            this.btn_Kiralamalar.Click += new System.EventHandler(this.btn_Kiralamalar_Click);
            // 
            // btn_aracekle
            // 
            this.btn_aracekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_aracekle.Location = new System.Drawing.Point(259, 107);
            this.btn_aracekle.Name = "btn_aracekle";
            this.btn_aracekle.Size = new System.Drawing.Size(163, 31);
            this.btn_aracekle.TabIndex = 3;
            this.btn_aracekle.Text = "Yeni Araç Ekle";
            this.btn_aracekle.UseVisualStyleBackColor = true;
            this.btn_aracekle.Click += new System.EventHandler(this.btn_aracekle_Click);
            // 
            // btn_sifredegistir
            // 
            this.btn_sifredegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sifredegistir.Location = new System.Drawing.Point(635, 107);
            this.btn_sifredegistir.Name = "btn_sifredegistir";
            this.btn_sifredegistir.Size = new System.Drawing.Size(127, 31);
            this.btn_sifredegistir.TabIndex = 4;
            this.btn_sifredegistir.Text = "Şifre Değiştir";
            this.btn_sifredegistir.UseVisualStyleBackColor = true;
            this.btn_sifredegistir.Click += new System.EventHandler(this.btn_sifredegistir_Click);
            // 
            // btn_uyeler
            // 
            this.btn_uyeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyeler.Location = new System.Drawing.Point(477, 107);
            this.btn_uyeler.Name = "btn_uyeler";
            this.btn_uyeler.Size = new System.Drawing.Size(123, 31);
            this.btn_uyeler.TabIndex = 5;
            this.btn_uyeler.Text = "Uyeler";
            this.btn_uyeler.UseVisualStyleBackColor = true;
            this.btn_uyeler.Click += new System.EventHandler(this.btn_uyeler_Click);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikis.Location = new System.Drawing.Point(635, 367);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(131, 44);
            this.btn_Cikis.TabIndex = 6;
            this.btn_Cikis.Text = "Çıkış Yap";
            this.btn_Cikis.UseVisualStyleBackColor = true;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // btn_harita
            // 
            this.btn_harita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_harita.Location = new System.Drawing.Point(101, 358);
            this.btn_harita.Name = "btn_harita";
            this.btn_harita.Size = new System.Drawing.Size(106, 35);
            this.btn_harita.TabIndex = 7;
            this.btn_harita.Text = "Harita";
            this.btn_harita.UseVisualStyleBackColor = true;
            this.btn_harita.Click += new System.EventHandler(this.btn_harita_Click);
            // 
            // YoneticiAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_harita);
            this.Controls.Add(this.btn_Cikis);
            this.Controls.Add(this.btn_uyeler);
            this.Controls.Add(this.btn_sifredegistir);
            this.Controls.Add(this.btn_aracekle);
            this.Controls.Add(this.btn_Kiralamalar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "YoneticiAnaMenu";
            this.Text = "Yonetici_AnaMenu";
            this.Load += new System.EventHandler(this.YoneticiAnaMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_isim;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timerSaat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btn_Kiralamalar;
        private System.Windows.Forms.Button btn_aracekle;
        private System.Windows.Forms.Button btn_sifredegistir;
        private System.Windows.Forms.Button btn_uyeler;
        private System.Windows.Forms.Button btn_Cikis;
        private System.Windows.Forms.Label label_saat;
        private System.Windows.Forms.Button btn_harita;
    }
}