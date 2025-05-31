using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Arac_kiralama
{
    public partial class AracDetayForm : Form
    {
        private int aracID;
        private int kullaniciID;
        private string uyeTipi;
        private DateTime baslangicTarihi;
        private DateTime bitisTarihi;

        // Form kontrolleri
        private PictureBox pictureBoxArac;
        private Label lblMarka, lblModel, lblYil, lblKm, lblYakit, lblVites, lblSehir, lblUcret;
        private Label lblBaslangic, lblBitis, lblToplamGun, lblToplamUcret;
        private Button btnHarita, btnGeri, btnIptal;

        public AracDetayForm(int aracID, int kullaniciID, string uyeTipi, DateTime baslangic, DateTime bitis)
        {
            InitializeComponent();
            this.aracID = aracID;
            this.kullaniciID = kullaniciID;
            this.uyeTipi = uyeTipi;
            this.baslangicTarihi = baslangic;
            this.bitisTarihi = bitis;

            InitializeControls();
            AracBilgileriniYukle();
        }

        private void InitializeControls()
        {
            this.Text = "Araç Detayları";
            this.Size = new Size(600, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Araç resmi
            pictureBoxArac = new PictureBox();
            pictureBoxArac.Location = new Point(20, 20);
            pictureBoxArac.Size = new Size(300, 200);
            pictureBoxArac.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxArac.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(pictureBoxArac);

            // Araç bilgileri
            int labelX = 350;
            int labelY = 20;
            int labelSpacing = 25;

            lblMarka = CreateLabel("Marka: ", labelX, labelY);
            lblModel = CreateLabel("Model: ", labelX, labelY += labelSpacing);
            lblYil = CreateLabel("Yıl: ", labelX, labelY += labelSpacing);
            lblKm = CreateLabel("Kilometre: ", labelX, labelY += labelSpacing);
            lblYakit = CreateLabel("Yakıt Tipi: ", labelX, labelY += labelSpacing);
            lblVites = CreateLabel("Vites Tipi: ", labelX, labelY += labelSpacing);
            lblSehir = CreateLabel("Şehir: ", labelX, labelY += labelSpacing);
            lblUcret = CreateLabel("Günlük Ücret: ", labelX, labelY += labelSpacing);

            // Kiralama bilgileri
            labelY = 250;
            lblBaslangic = CreateLabel("Başlangıç: ", 20, labelY);
            lblBitis = CreateLabel("Bitiş: ", 20, labelY += labelSpacing);
            lblToplamGun = CreateLabel("Toplam Gün: ", 20, labelY += labelSpacing);
            lblToplamUcret = CreateLabel("Toplam Ücret: ", 20, labelY += labelSpacing);

            // Butonlar
            btnHarita = new Button();
            btnHarita.Text = "Harita";
            btnHarita.Location = new Point(200, 400);
            btnHarita.Size = new Size(80, 30);
            btnHarita.BackColor = Color.Blue;
            btnHarita.ForeColor = Color.White;
            btnHarita.Click += BtnHarita_Click;
            this.Controls.Add(btnHarita);

            btnGeri = new Button();
            btnGeri.Text = "Geri";
            btnGeri.Location = new Point(300, 400);
            btnGeri.Size = new Size(80, 30);
            btnGeri.BackColor = Color.Gray;
            btnGeri.ForeColor = Color.White;
            btnGeri.Click += BtnGeri_Click;
            this.Controls.Add(btnGeri);

            btnIptal = new Button();
            btnIptal.Text = "İptal";
            btnIptal.Location = new Point(400, 400);
            btnIptal.Size = new Size(80, 30);
            btnIptal.BackColor = Color.Red;
            btnIptal.ForeColor = Color.White;
            btnIptal.Click += BtnIptal_Click;
            this.Controls.Add(btnIptal);
        }

        private Label CreateLabel(string text, int x, int y)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.Location = new Point(x, y);
            lbl.AutoSize = true;
            lbl.Font = new Font("Arial", 10);
            this.Controls.Add(lbl);
            return lbl;
        }

        private void AracBilgileriniYukle()
        {
            using (MySqlConnection baglanti = Arac_kiralama.Veritabani.BaglantiOlustur())
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "SELECT * FROM araclar WHERE aracID = @aracID";
                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@aracID", aracID);

                    MySqlDataReader reader = komut.ExecuteReader();
                    if (reader.Read())
                    {
                        // Araç bilgilerini doldur
                        lblMarka.Text = "Marka: " + reader["marka"].ToString();
                        lblModel.Text = "Model: " + reader["model"].ToString();
                        lblYil.Text = "Yıl: " + reader["yil"].ToString();
                        lblKm.Text = "Kilometre: " + reader["kilometre"].ToString() + " km";
                        lblYakit.Text = "Yakıt Tipi: " + reader["yakit_tipi"].ToString();
                        lblVites.Text = "Vites Tipi: " + reader["vites_tipi"].ToString();
                        lblSehir.Text = "Şehir: " + reader["sehir"].ToString();

                        decimal gunlukUcret = Convert.ToDecimal(reader["gunluk_ucret"]);
                        lblUcret.Text = "Günlük Ücret: " + gunlukUcret.ToString("C");

                        // Resmi yükle
                        string resimYolu = reader["resim_yolu"].ToString();
                        if (!string.IsNullOrEmpty(resimYolu) && File.Exists(resimYolu))
                        {
                            try
                            {
                                pictureBoxArac.Image = Image.FromFile(resimYolu);
                            }
                            catch
                            {
                                pictureBoxArac.BackColor = Color.LightGray;
                            }
                        }
                        else
                        {
                            pictureBoxArac.BackColor = Color.LightGray;
                        }

                        // Kiralama bilgilerini hesapla
                        int toplamGun = (int)(bitisTarihi - baslangicTarihi).TotalDays;
                        decimal toplamUcret = toplamGun * gunlukUcret;

                        lblBaslangic.Text = "Başlangıç: " + baslangicTarihi.ToShortDateString();
                        lblBitis.Text = "Bitiş: " + bitisTarihi.ToShortDateString();
                        lblToplamGun.Text = "Toplam Gün: " + toplamGun + " gün";
                        lblToplamUcret.Text = "Toplam Ücret: " + toplamUcret.ToString("C");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Araç bilgileri yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        private void BtnHarita_Click(object sender, EventArgs e)
        {
            try
            {
                // KullaniciHarita formunu aç
                KullaniciHarita haritaForm = new KullaniciHarita(aracID, kullaniciID, uyeTipi, baslangicTarihi, bitisTarihi);
                haritaForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Harita formu açılırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(kullaniciID, uyeTipi);
            form2.Show();
            this.Close();
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(kullaniciID, uyeTipi);
            form3.Show();
            this.Close();
        }
    }
}