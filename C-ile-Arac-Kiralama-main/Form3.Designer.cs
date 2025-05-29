namespace Arac_kiralama
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btn_arackirala = new System.Windows.Forms.Button();
            this.btn_kiralamalarım = new System.Windows.Forms.Button();
            this.btn_sifredegistir = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_mevcut_araclarım = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btn_arackirala
            // 
            this.btn_arackirala.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_arackirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_arackirala.Location = new System.Drawing.Point(27, 82);
            this.btn_arackirala.Name = "btn_arackirala";
            this.btn_arackirala.Size = new System.Drawing.Size(98, 30);
            this.btn_arackirala.TabIndex = 0;
            this.btn_arackirala.Text = "Araç Kirala";
            this.btn_arackirala.UseVisualStyleBackColor = false;
            this.btn_arackirala.Click += new System.EventHandler(this.btn_arackirala_Click);
            // 
            // btn_kiralamalarım
            // 
            this.btn_kiralamalarım.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kiralamalarım.Location = new System.Drawing.Point(156, 80);
            this.btn_kiralamalarım.Name = "btn_kiralamalarım";
            this.btn_kiralamalarım.Size = new System.Drawing.Size(232, 34);
            this.btn_kiralamalarım.TabIndex = 1;
            this.btn_kiralamalarım.Text = "Araç Kiralalamalarım";
            this.btn_kiralamalarım.UseVisualStyleBackColor = true;
            this.btn_kiralamalarım.Click += new System.EventHandler(this.btn_kiralamalarım_Click);
            // 
            // btn_sifredegistir
            // 
            this.btn_sifredegistir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sifredegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sifredegistir.Location = new System.Drawing.Point(416, 80);
            this.btn_sifredegistir.Name = "btn_sifredegistir";
            this.btn_sifredegistir.Size = new System.Drawing.Size(129, 34);
            this.btn_sifredegistir.TabIndex = 2;
            this.btn_sifredegistir.Text = "Şifre Değiştir";
            this.btn_sifredegistir.UseVisualStyleBackColor = false;
            this.btn_sifredegistir.Click += new System.EventHandler(this.btn_sifredegistir_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptal.Location = new System.Drawing.Point(593, 78);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(160, 34);
            this.btn_iptal.TabIndex = 3;
            this.btn_iptal.Text = "Kiralama İptal Et";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(666, 450);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(136, 37);
            this.btn_cikis.TabIndex = 4;
            this.btn_cikis.Text = "Çıkış Yap";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(122, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yapmak İstediğiniz İşlemi Seçebilirsiniz";
            // 
            // gb_mevcut_araclarım
            // 
            this.gb_mevcut_araclarım.BackColor = System.Drawing.Color.Transparent;
            this.gb_mevcut_araclarım.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_mevcut_araclarım.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gb_mevcut_araclarım.Location = new System.Drawing.Point(12, 126);
            this.gb_mevcut_araclarım.Name = "gb_mevcut_araclarım";
            this.gb_mevcut_araclarım.Size = new System.Drawing.Size(721, 151);
            this.gb_mevcut_araclarım.TabIndex = 6;
            this.gb_mevcut_araclarım.TabStop = false;
            this.gb_mevcut_araclarım.Text = "Mevcut Araç Kiralamalarım";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 499);
            this.Controls.Add(this.gb_mevcut_araclarım);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_sifredegistir);
            this.Controls.Add(this.btn_kiralamalarım);
            this.Controls.Add(this.btn_arackirala);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_arackirala;
        private System.Windows.Forms.Button btn_kiralamalarım;
        private System.Windows.Forms.Button btn_sifredegistir;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_mevcut_araclarım;
    }
}