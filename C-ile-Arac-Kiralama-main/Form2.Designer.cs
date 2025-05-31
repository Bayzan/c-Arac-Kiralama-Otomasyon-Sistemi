namespace Arac_kiralama
{
    partial class Form2
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
            this.comboBoxSehir = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBitis = new System.Windows.Forms.DateTimePicker();
            this.groupBoxVites = new System.Windows.Forms.GroupBox();
            this.cb_manuel = new System.Windows.Forms.CheckBox();
            this.cb_otomatik = new System.Windows.Forms.CheckBox();
            this.groupBoxYakit = new System.Windows.Forms.GroupBox();
            this.cb_elektrikli = new System.Windows.Forms.CheckBox();
            this.cb_hibrit = new System.Windows.Forms.CheckBox();
            this.cb_dizel = new System.Windows.Forms.CheckBox();
            this.cb_benzin = new System.Windows.Forms.CheckBox();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.chkFiyatFiltrele = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkKmFiltrele = new System.Windows.Forms.CheckBox();
            this.nudKm = new System.Windows.Forms.NumericUpDown();
            this.btnAra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_geridon = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxVites.SuspendLayout();
            this.groupBoxYakit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSehir
            // 
            this.comboBoxSehir.FormattingEnabled = true;
            this.comboBoxSehir.Location = new System.Drawing.Point(195, 59);
            this.comboBoxSehir.Name = "comboBoxSehir";
            this.comboBoxSehir.Size = new System.Drawing.Size(129, 21);
            this.comboBoxSehir.TabIndex = 0;
            // 
            // dateTimePickerBaslangic
            // 
            this.dateTimePickerBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerBaslangic.Location = new System.Drawing.Point(363, 58);
            this.dateTimePickerBaslangic.Name = "dateTimePickerBaslangic";
            this.dateTimePickerBaslangic.Size = new System.Drawing.Size(232, 22);
            this.dateTimePickerBaslangic.TabIndex = 1;
            // 
            // dateTimePickerBitis
            // 
            this.dateTimePickerBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerBitis.Location = new System.Drawing.Point(656, 58);
            this.dateTimePickerBitis.Name = "dateTimePickerBitis";
            this.dateTimePickerBitis.Size = new System.Drawing.Size(226, 22);
            this.dateTimePickerBitis.TabIndex = 2;
            // 
            // groupBoxVites
            // 
            this.groupBoxVites.BackColor = System.Drawing.Color.SlateGray;
            this.groupBoxVites.Controls.Add(this.cb_manuel);
            this.groupBoxVites.Controls.Add(this.cb_otomatik);
            this.groupBoxVites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxVites.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxVites.Location = new System.Drawing.Point(482, 60);
            this.groupBoxVites.Name = "groupBoxVites";
            this.groupBoxVites.Size = new System.Drawing.Size(320, 79);
            this.groupBoxVites.TabIndex = 3;
            this.groupBoxVites.TabStop = false;
            this.groupBoxVites.Text = "Vites türü";
            // 
            // cb_manuel
            // 
            this.cb_manuel.AutoSize = true;
            this.cb_manuel.Location = new System.Drawing.Point(125, 44);
            this.cb_manuel.Name = "cb_manuel";
            this.cb_manuel.Size = new System.Drawing.Size(86, 24);
            this.cb_manuel.TabIndex = 6;
            this.cb_manuel.Text = "Manuel";
            this.cb_manuel.UseVisualStyleBackColor = true;
            // 
            // cb_otomatik
            // 
            this.cb_otomatik.AutoSize = true;
            this.cb_otomatik.Location = new System.Drawing.Point(6, 44);
            this.cb_otomatik.Name = "cb_otomatik";
            this.cb_otomatik.Size = new System.Drawing.Size(100, 24);
            this.cb_otomatik.TabIndex = 5;
            this.cb_otomatik.Text = "Otomatik";
            this.cb_otomatik.UseVisualStyleBackColor = true;
            // 
            // groupBoxYakit
            // 
            this.groupBoxYakit.BackColor = System.Drawing.Color.SlateGray;
            this.groupBoxYakit.Controls.Add(this.cb_elektrikli);
            this.groupBoxYakit.Controls.Add(this.cb_hibrit);
            this.groupBoxYakit.Controls.Add(this.cb_dizel);
            this.groupBoxYakit.Controls.Add(this.cb_benzin);
            this.groupBoxYakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxYakit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxYakit.Location = new System.Drawing.Point(6, 60);
            this.groupBoxYakit.Name = "groupBoxYakit";
            this.groupBoxYakit.Size = new System.Drawing.Size(470, 81);
            this.groupBoxYakit.TabIndex = 4;
            this.groupBoxYakit.TabStop = false;
            this.groupBoxYakit.Text = "Yakıt";
            // 
            // cb_elektrikli
            // 
            this.cb_elektrikli.AutoSize = true;
            this.cb_elektrikli.Location = new System.Drawing.Point(308, 44);
            this.cb_elektrikli.Name = "cb_elektrikli";
            this.cb_elektrikli.Size = new System.Drawing.Size(96, 24);
            this.cb_elektrikli.TabIndex = 7;
            this.cb_elektrikli.Text = "Elektrikli";
            this.cb_elektrikli.UseVisualStyleBackColor = true;
            // 
            // cb_hibrit
            // 
            this.cb_hibrit.AutoSize = true;
            this.cb_hibrit.Location = new System.Drawing.Point(207, 44);
            this.cb_hibrit.Name = "cb_hibrit";
            this.cb_hibrit.Size = new System.Drawing.Size(71, 24);
            this.cb_hibrit.TabIndex = 6;
            this.cb_hibrit.Text = "Hibrit";
            this.cb_hibrit.UseVisualStyleBackColor = true;
            // 
            // cb_dizel
            // 
            this.cb_dizel.AutoSize = true;
            this.cb_dizel.Location = new System.Drawing.Point(115, 44);
            this.cb_dizel.Name = "cb_dizel";
            this.cb_dizel.Size = new System.Drawing.Size(68, 24);
            this.cb_dizel.TabIndex = 5;
            this.cb_dizel.Text = "Dizel";
            this.cb_dizel.UseVisualStyleBackColor = true;
            // 
            // cb_benzin
            // 
            this.cb_benzin.AutoSize = true;
            this.cb_benzin.Location = new System.Drawing.Point(6, 44);
            this.cb_benzin.Name = "cb_benzin";
            this.cb_benzin.Size = new System.Drawing.Size(83, 24);
            this.cb_benzin.TabIndex = 4;
            this.cb_benzin.Text = "Benzin";
            this.cb_benzin.UseVisualStyleBackColor = true;
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(30, 175);
            this.nudFiyat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(165, 24);
            this.nudFiyat.TabIndex = 5;
            // 
            // chkFiyatFiltrele
            // 
            this.chkFiyatFiltrele.AutoSize = true;
            this.chkFiyatFiltrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkFiyatFiltrele.Location = new System.Drawing.Point(30, 147);
            this.chkFiyatFiltrele.Name = "chkFiyatFiltrele";
            this.chkFiyatFiltrele.Size = new System.Drawing.Size(167, 22);
            this.chkFiyatFiltrele.TabIndex = 6;
            this.chkFiyatFiltrele.Text = "Fiyat filtresi uygula";
            this.chkFiyatFiltrele.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(191, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Şehir Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(362, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Başlangıç tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(665, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bitiş tarihi";
            // 
            // chkKmFiltrele
            // 
            this.chkKmFiltrele.AutoSize = true;
            this.chkKmFiltrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkKmFiltrele.Location = new System.Drawing.Point(291, 147);
            this.chkKmFiltrele.Name = "chkKmFiltrele";
            this.chkKmFiltrele.Size = new System.Drawing.Size(203, 22);
            this.chkKmFiltrele.TabIndex = 11;
            this.chkKmFiltrele.Text = "Kilometre filtresi uygula";
            this.chkKmFiltrele.UseVisualStyleBackColor = true;
            // 
            // nudKm
            // 
            this.nudKm.Location = new System.Drawing.Point(291, 175);
            this.nudKm.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudKm.Name = "nudKm";
            this.nudKm.Size = new System.Drawing.Size(165, 24);
            this.nudKm.TabIndex = 10;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(558, 166);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(147, 33);
            this.btnAra.TabIndex = 13;
            this.btnAra.Text = "Uygun Araç Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.nudKm);
            this.groupBox1.Controls.Add(this.chkKmFiltrele);
            this.groupBox1.Controls.Add(this.groupBoxYakit);
            this.groupBox1.Controls.Add(this.chkFiyatFiltrele);
            this.groupBox1.Controls.Add(this.nudFiyat);
            this.groupBox1.Controls.Add(this.groupBoxVites);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(-1, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 226);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(380, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "İsteğe Bağlı Tercihler";
            // 
            // btn_geridon
            // 
            this.btn_geridon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geridon.Location = new System.Drawing.Point(0, -1);
            this.btn_geridon.Name = "btn_geridon";
            this.btn_geridon.Size = new System.Drawing.Size(183, 33);
            this.btn_geridon.TabIndex = 16;
            this.btn_geridon.Text = "Ana Sayfaya Dön";
            this.btn_geridon.UseVisualStyleBackColor = true;
            this.btn_geridon.Click += new System.EventHandler(this.btn_geridon_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(869, 0);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(183, 33);
            this.btn_cikis.TabIndex = 17;
            this.btn_cikis.Text = "Çıkış Yap";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.btn_cikis);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_geridon);
            this.groupBox2.Controls.Add(this.comboBoxSehir);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePickerBaslangic);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePickerBitis);
            this.groupBox2.Location = new System.Drawing.Point(-1, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1052, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 748);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBoxVites.ResumeLayout(false);
            this.groupBoxVites.PerformLayout();
            this.groupBoxYakit.ResumeLayout(false);
            this.groupBoxYakit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSehir;
        private System.Windows.Forms.DateTimePicker dateTimePickerBaslangic;
        private System.Windows.Forms.DateTimePicker dateTimePickerBitis;
        private System.Windows.Forms.GroupBox groupBoxVites;
        private System.Windows.Forms.GroupBox groupBoxYakit;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.CheckBox chkFiyatFiltrele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkKmFiltrele;
        private System.Windows.Forms.NumericUpDown nudKm;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_geridon;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_benzin;
        private System.Windows.Forms.CheckBox cb_manuel;
        private System.Windows.Forms.CheckBox cb_otomatik;
        private System.Windows.Forms.CheckBox cb_elektrikli;
        private System.Windows.Forms.CheckBox cb_hibrit;
        private System.Windows.Forms.CheckBox cb_dizel;
    }
}