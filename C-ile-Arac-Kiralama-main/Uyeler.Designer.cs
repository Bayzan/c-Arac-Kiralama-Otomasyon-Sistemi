namespace Arac_kiralama
{
    partial class Uyeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uyeler));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_toplamUye = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_bireyselUye = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ticariUye = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_uyeTip = new System.Windows.Forms.ComboBox();
            this.cmb_aramaKriter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_aramaMetni = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.dgv_uyeler = new System.Windows.Forms.DataGridView();
            this.btn_uyelikKaldir = new System.Windows.Forms.Button();
            this.btn_geriDon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_uyeler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(294, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üyeler";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_toplamUye
            // 
            this.lbl_toplamUye.AutoSize = true;
            this.lbl_toplamUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplamUye.Location = new System.Drawing.Point(161, 149);
            this.lbl_toplamUye.Name = "lbl_toplamUye";
            this.lbl_toplamUye.Size = new System.Drawing.Size(51, 20);
            this.lbl_toplamUye.TabIndex = 1;
            this.lbl_toplamUye.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(115, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toplam Üye";
            // 
            // lbl_bireyselUye
            // 
            this.lbl_bireyselUye.AutoSize = true;
            this.lbl_bireyselUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bireyselUye.Location = new System.Drawing.Point(327, 149);
            this.lbl_bireyselUye.Name = "lbl_bireyselUye";
            this.lbl_bireyselUye.Size = new System.Drawing.Size(51, 20);
            this.lbl_bireyselUye.TabIndex = 3;
            this.lbl_bireyselUye.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(283, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bireysel Üye";
            // 
            // lbl_ticariUye
            // 
            this.lbl_ticariUye.AutoSize = true;
            this.lbl_ticariUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ticariUye.Location = new System.Drawing.Point(530, 149);
            this.lbl_ticariUye.Name = "lbl_ticariUye";
            this.lbl_ticariUye.Size = new System.Drawing.Size(51, 20);
            this.lbl_ticariUye.TabIndex = 5;
            this.lbl_ticariUye.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(492, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ticaril Üye";
            // 
            // cmb_uyeTip
            // 
            this.cmb_uyeTip.FormattingEnabled = true;
            this.cmb_uyeTip.Location = new System.Drawing.Point(269, 212);
            this.cmb_uyeTip.Name = "cmb_uyeTip";
            this.cmb_uyeTip.Size = new System.Drawing.Size(121, 21);
            this.cmb_uyeTip.TabIndex = 7;
            // 
            // cmb_aramaKriter
            // 
            this.cmb_aramaKriter.FormattingEnabled = true;
            this.cmb_aramaKriter.Location = new System.Drawing.Point(269, 254);
            this.cmb_aramaKriter.Name = "cmb_aramaKriter";
            this.cmb_aramaKriter.Size = new System.Drawing.Size(121, 21);
            this.cmb_aramaKriter.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Üye Tipi Seçebilirsiniz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(16, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Arama Kriteri";
            // 
            // txt_aramaMetni
            // 
            this.txt_aramaMetni.Location = new System.Drawing.Point(494, 250);
            this.txt_aramaMetni.Name = "txt_aramaMetni";
            this.txt_aramaMetni.Size = new System.Drawing.Size(149, 20);
            this.txt_aramaMetni.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(489, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Burada aratınız";
            // 
            // btn_ara
            // 
            this.btn_ara.ForeColor = System.Drawing.Color.Black;
            this.btn_ara.Location = new System.Drawing.Point(136, 327);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(76, 35);
            this.btn_ara.TabIndex = 13;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.ForeColor = System.Drawing.Color.Black;
            this.btn_temizle.Location = new System.Drawing.Point(314, 327);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(76, 35);
            this.btn_temizle.TabIndex = 14;
            this.btn_temizle.Text = "temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // dgv_uyeler
            // 
            this.dgv_uyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_uyeler.Location = new System.Drawing.Point(-1, 382);
            this.dgv_uyeler.Name = "dgv_uyeler";
            this.dgv_uyeler.Size = new System.Drawing.Size(700, 240);
            this.dgv_uyeler.TabIndex = 15;
            this.dgv_uyeler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_uyeler_CellContentClick);
            this.dgv_uyeler.Click += new System.EventHandler(this.cmb_uyeTipi_SelectedIndexChanged);
            // 
            // btn_uyelikKaldir
            // 
            this.btn_uyelikKaldir.ForeColor = System.Drawing.Color.Black;
            this.btn_uyelikKaldir.Location = new System.Drawing.Point(534, 327);
            this.btn_uyelikKaldir.Name = "btn_uyelikKaldir";
            this.btn_uyelikKaldir.Size = new System.Drawing.Size(76, 35);
            this.btn_uyelikKaldir.TabIndex = 16;
            this.btn_uyelikKaldir.Text = "Üyeliği Kaldır";
            this.btn_uyelikKaldir.UseVisualStyleBackColor = true;
            this.btn_uyelikKaldir.Click += new System.EventHandler(this.btn_uyelikKaldir_Click);
            // 
            // btn_geriDon
            // 
            this.btn_geriDon.ForeColor = System.Drawing.Color.Black;
            this.btn_geriDon.Location = new System.Drawing.Point(-1, 1);
            this.btn_geriDon.Name = "btn_geriDon";
            this.btn_geriDon.Size = new System.Drawing.Size(85, 40);
            this.btn_geriDon.TabIndex = 17;
            this.btn_geriDon.Text = "Geri Dön";
            this.btn_geriDon.UseVisualStyleBackColor = true;
            this.btn_geriDon.Click += new System.EventHandler(this.btn_geriDon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(697, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 621);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // Uyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(931, 623);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_ticariUye);
            this.Controls.Add(this.btn_geriDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_bireyselUye);
            this.Controls.Add(this.btn_uyelikKaldir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_uyeler);
            this.Controls.Add(this.lbl_toplamUye);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_aramaMetni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_aramaKriter);
            this.Controls.Add(this.cmb_uyeTip);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Uyeler";
            this.Text = "Uyeler";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_uyeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_toplamUye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_bireyselUye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_ticariUye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_uyeTip;
        private System.Windows.Forms.ComboBox cmb_aramaKriter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_aramaMetni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.DataGridView dgv_uyeler;
        private System.Windows.Forms.Button btn_uyelikKaldir;
        private System.Windows.Forms.Button btn_geriDon;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}