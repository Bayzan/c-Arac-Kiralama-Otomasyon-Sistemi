namespace Arac_kiralama
{
    partial class Kiralamaİptal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kiralamaİptal));
            this.label1 = new System.Windows.Forms.Label();
            this.gb_iptalet = new System.Windows.Forms.GroupBox();
            this.btn_iptalet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "İptal Etmek istediğiniz Aracı Seçin";
            // 
            // gb_iptalet
            // 
            this.gb_iptalet.BackColor = System.Drawing.Color.Transparent;
            this.gb_iptalet.Location = new System.Drawing.Point(13, 103);
            this.gb_iptalet.Name = "gb_iptalet";
            this.gb_iptalet.Size = new System.Drawing.Size(738, 229);
            this.gb_iptalet.TabIndex = 1;
            this.gb_iptalet.TabStop = false;
            // 
            // btn_iptalet
            // 
            this.btn_iptalet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptalet.Location = new System.Drawing.Point(33, 369);
            this.btn_iptalet.Name = "btn_iptalet";
            this.btn_iptalet.Size = new System.Drawing.Size(200, 34);
            this.btn_iptalet.TabIndex = 2;
            this.btn_iptalet.Text = "Seçilen Aracı İptal Et";
            this.btn_iptalet.UseVisualStyleBackColor = true;
            // 
            // Kiralamaİptal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_iptalet);
            this.Controls.Add(this.gb_iptalet);
            this.Controls.Add(this.label1);
            this.Name = "Kiralamaİptal";
            this.Text = "Kiralamaİptal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_iptalet;
        private System.Windows.Forms.Button btn_iptalet;
    }
}