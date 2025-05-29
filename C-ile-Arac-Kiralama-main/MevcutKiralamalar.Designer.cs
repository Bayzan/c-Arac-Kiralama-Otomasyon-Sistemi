namespace Arac_kiralama
{
    partial class MevcutKiralamalar
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
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.cmbVitesTipi = new System.Windows.Forms.ComboBox();
            this.cmbYakitTipi = new System.Windows.Forms.ComboBox();
            this.dgvKiralamalar = new System.Windows.Forms.DataGridView();
            this.chkBireysel = new System.Windows.Forms.RadioButton();
            this.chkTicari = new System.Windows.Forms.RadioButton();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.btn_IptalEt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_GeriDon = new System.Windows.Forms.Button();
            this.btn_Cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralamalar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(76, 65);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(121, 21);
            this.cmbSehir.TabIndex = 0;
            // 
            // cmbVitesTipi
            // 
            this.cmbVitesTipi.FormattingEnabled = true;
            this.cmbVitesTipi.Location = new System.Drawing.Point(332, 65);
            this.cmbVitesTipi.Name = "cmbVitesTipi";
            this.cmbVitesTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbVitesTipi.TabIndex = 1;
            // 
            // cmbYakitTipi
            // 
            this.cmbYakitTipi.FormattingEnabled = true;
            this.cmbYakitTipi.Location = new System.Drawing.Point(574, 70);
            this.cmbYakitTipi.Name = "cmbYakitTipi";
            this.cmbYakitTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbYakitTipi.TabIndex = 2;
            // 
            // dgvKiralamalar
            // 
            this.dgvKiralamalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKiralamalar.Location = new System.Drawing.Point(12, 185);
            this.dgvKiralamalar.Name = "dgvKiralamalar";
            this.dgvKiralamalar.Size = new System.Drawing.Size(898, 390);
            this.dgvKiralamalar.TabIndex = 3;
            // 
            // chkBireysel
            // 
            this.chkBireysel.AutoSize = true;
            this.chkBireysel.Location = new System.Drawing.Point(85, 113);
            this.chkBireysel.Name = "chkBireysel";
            this.chkBireysel.Size = new System.Drawing.Size(61, 17);
            this.chkBireysel.TabIndex = 4;
            this.chkBireysel.TabStop = true;
            this.chkBireysel.Text = "Bireysel";
            this.chkBireysel.UseVisualStyleBackColor = true;
            // 
            // chkTicari
            // 
            this.chkTicari.AutoSize = true;
            this.chkTicari.Location = new System.Drawing.Point(231, 113);
            this.chkTicari.Name = "chkTicari";
            this.chkTicari.Size = new System.Drawing.Size(51, 17);
            this.chkTicari.TabIndex = 5;
            this.chkTicari.TabStop = true;
            this.chkTicari.Text = "Ticari";
            this.chkTicari.UseVisualStyleBackColor = true;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Location = new System.Drawing.Point(341, 126);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(142, 42);
            this.btnFiltrele.TabIndex = 6;
            this.btnFiltrele.Text = "Arama Yap";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // btn_IptalEt
            // 
            this.btn_IptalEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_IptalEt.Location = new System.Drawing.Point(940, 337);
            this.btn_IptalEt.Name = "btn_IptalEt";
            this.btn_IptalEt.Size = new System.Drawing.Size(96, 29);
            this.btn_IptalEt.TabIndex = 7;
            this.btn_IptalEt.Text = "İptal Et";
            this.btn_IptalEt.UseVisualStyleBackColor = true;
            this.btn_IptalEt.Click += new System.EventHandler(this.btnIptalEt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Şehir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vites Tipi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yakit Tipi";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.btn_GeriDon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_Cikis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFiltrele);
            this.groupBox1.Controls.Add(this.chkTicari);
            this.groupBox1.Controls.Add(this.chkBireysel);
            this.groupBox1.Controls.Add(this.cmbYakitTipi);
            this.groupBox1.Controls.Add(this.cmbVitesTipi);
            this.groupBox1.Controls.Add(this.cmbSehir);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 174);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btn_GeriDon
            // 
            this.btn_GeriDon.Location = new System.Drawing.Point(0, 0);
            this.btn_GeriDon.Name = "btn_GeriDon";
            this.btn_GeriDon.Size = new System.Drawing.Size(100, 36);
            this.btn_GeriDon.TabIndex = 13;
            this.btn_GeriDon.Text = "Geri Dön";
            this.btn_GeriDon.UseVisualStyleBackColor = true;
            this.btn_GeriDon.Click += new System.EventHandler(this.btn_GeriDon_Click_1);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.Location = new System.Drawing.Point(798, 3);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(100, 33);
            this.btn_Cikis.TabIndex = 12;
            this.btn_Cikis.Text = "Çıkış Yap";
            this.btn_Cikis.UseVisualStyleBackColor = true;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click_1);
            // 
            // MevcutKiralamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1048, 581);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_IptalEt);
            this.Controls.Add(this.dgvKiralamalar);
            this.Name = "MevcutKiralamalar";
            this.Text = "MevcutKiralamalar";
            this.Load += new System.EventHandler(this.Kiralamalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralamalar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.ComboBox cmbVitesTipi;
        private System.Windows.Forms.ComboBox cmbYakitTipi;
        private System.Windows.Forms.DataGridView dgvKiralamalar;
        private System.Windows.Forms.RadioButton chkBireysel;
        private System.Windows.Forms.RadioButton chkTicari;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Button btn_IptalEt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cikis;
        private System.Windows.Forms.Button btn_GeriDon;
    }
}