using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arac_kiralama.Arac_kiralama;
using MySql.Data.MySqlClient;
using System.IO;

namespace Arac_kiralama
{
    public partial class Form2 : Form
    {
        private int kullaniciID;
        private string uyeTipi; // "bireysel" veya "ticari"
        private FlowLayoutPanel panelAraclar; // Araç resimlerini gösterecek panel

        public Form2(int kullaniciID, string uyeTipi)
        {
            InitializeComponent();
            this.kullaniciID = kullaniciID;
            this.uyeTipi = uyeTipi;

            // FlowLayoutPanel oluştur (eğer tasarımda yoksa)
            InitializeAraclarPanel();
        }

        private void InitializeAraclarPanel()
        {
            // Eğer panelAraclar tasarımda yoksa burada oluşturun
            if (panelAraclar == null)
            {
                panelAraclar = new FlowLayoutPanel();
                panelAraclar.AutoScroll = true;
                panelAraclar.FlowDirection = FlowDirection.LeftToRight;
                panelAraclar.WrapContents = true;
                panelAraclar.Dock = DockStyle.Bottom;
                panelAraclar.Height = 400; // veya istediğiniz boyut
                this.Controls.Add(panelAraclar);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxSehir.Items.Add("İstanbul");
            comboBoxSehir.Items.Add("Ankara");
            comboBoxSehir.Items.Add("İzmir");
            comboBoxSehir.Items.Add("Antalya");
            comboBoxSehir.Items.Add("Bursa");
            comboBoxSehir.SelectedIndex = 0;

            // Tarih kısıtlamaları
            DateTime bugun = DateTime.Now.Date;
            DateTime yarin = bugun.AddDays(1);

            dateTimePickerBaslangic.MinDate = bugun;
            dateTimePickerBaslangic.MaxDate = bugun.AddDays(2);

            dateTimePickerBitis.MinDate = yarin;
            dateTimePickerBitis.MaxDate = bugun.AddDays(3);

            dateTimePickerBaslangic.Value = bugun;
            dateTimePickerBitis.Value = yarin;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            // Önceki araç resimlerini temizle
            panelAraclar.Controls.Clear();

            using (MySqlConnection baglanti = Veritabani.BaglantiOlustur())
            {
                try
                {
                    baglanti.Open();

                    string query = "SELECT aracID, marka, model, yil, resim_yolu, gunluk_ucret FROM araclar WHERE sehir = @sehir";

                    if (chkFiyatFiltrele.Checked)
                        query += " AND gunluk_ucret <= @fiyat";
                    if (chkKmFiltrele.Checked)
                        query += " AND kilometre <= @km";

                    if (cb_otomatik.Checked)
                        query += " AND vites_tipi = 'Otomatik'";
                    else if (cb_manuel.Checked)
                        query += " AND vites_tipi = 'Manuel'";

                    if (cb_benzin.Checked)
                        query += " AND yakit_tipi = 'Benzin'";
                    if (cb_dizel.Checked)
                        query += " AND yakit_tipi = 'Dizel'";
                    if (cb_elektrikli.Checked)
                        query += " AND yakit_tipi = 'Elektrik'";
                    if (cb_hibrit.Checked)
                        query += " AND yakit_tipi = 'Hibrit'";

                    query += @" AND aracID NOT IN (
                        SELECT arac_id FROM kiralamalar 
                        WHERE (@baslangic < bitis_tarihi AND @bitis > baslangic_tarihi)
                    )";

                    MySqlCommand komut = new MySqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@sehir", comboBoxSehir.SelectedItem.ToString());
                    komut.Parameters.AddWithValue("@baslangic", dateTimePickerBaslangic.Value.Date);
                    komut.Parameters.AddWithValue("@bitis", dateTimePickerBitis.Value.Date);

                    if (chkFiyatFiltrele.Checked)
                        komut.Parameters.AddWithValue("@fiyat", nudFiyat.Value);
                    if (chkKmFiltrele.Checked)
                        komut.Parameters.AddWithValue("@km", nudKm.Value);

                    MySqlDataReader reader = komut.ExecuteReader();

                    bool aracBulundu = false;
                    while (reader.Read())
                    {
                        aracBulundu = true;
                        AracResimKartiOlustur(reader);
                    }

                    if (!aracBulundu)
                    {
                        MessageBox.Show("Uygun araç bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void AracResimKartiOlustur(MySqlDataReader reader)
        {
            // Ana panel (araç kartı)
            Panel aracKarti = new Panel();
            aracKarti.Size = new Size(200, 250);
            aracKarti.BorderStyle = BorderStyle.FixedSingle;
            aracKarti.Margin = new Padding(10);
            aracKarti.BackColor = Color.White;

            // Araç resmi
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(180, 120);
            pictureBox.Location = new Point(10, 10);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;

            // Resim yolunu al ve göster
            string resimYolu = reader["resim_yolu"].ToString();
            if (!string.IsNullOrEmpty(resimYolu) && File.Exists(resimYolu))
            {
                try
                {
                    pictureBox.Image = Image.FromFile(resimYolu);
                }
                catch
                {
                    // Varsayılan araç resmi veya boş
                    pictureBox.BackColor = Color.LightGray;
                    pictureBox.Text = "Resim Yok";
                }
            }
            else
            {
                pictureBox.BackColor = Color.LightGray;
                pictureBox.Text = "Resim Yok";
            }

            // Araç bilgileri
            string marka = reader["marka"].ToString();
            string model = reader["model"].ToString();
            string yil = reader["yil"].ToString();
            decimal gunlukUcret = Convert.ToDecimal(reader["gunluk_ucret"]);
            int aracID = Convert.ToInt32(reader["aracID"]);

            Label lblBilgi = new Label();
            lblBilgi.Text = $"{marka} {model}\n{yil} Model\n{gunlukUcret:C} / Gün";
            lblBilgi.Location = new Point(10, 140);
            lblBilgi.Size = new Size(180, 60);
            lblBilgi.TextAlign = ContentAlignment.MiddleCenter;
            lblBilgi.Font = new Font("Arial", 9, FontStyle.Bold);

            // Detay butonu
            Button btnDetay = new Button();
            btnDetay.Text = "Detayları Gör";
            btnDetay.Location = new Point(50, 210);
            btnDetay.Size = new Size(100, 30);
            btnDetay.BackColor = Color.LightBlue;
            btnDetay.Tag = aracID; // Araç ID'sini tag'e koy

            // Click event'i
            btnDetay.Click += (sender, e) =>
            {
                Button btn = sender as Button;
                int selectedAracID = (int)btn.Tag;
                AracDetayFormunuAc(selectedAracID);
            };

            // Kontrolları karta ekle
            aracKarti.Controls.Add(pictureBox);
            aracKarti.Controls.Add(lblBilgi);
            aracKarti.Controls.Add(btnDetay);

            // Kartı ana panele ekle
            panelAraclar.Controls.Add(aracKarti);
        }

        private void AracDetayFormunuAc(int aracID)
        {
            DateTime baslangic = dateTimePickerBaslangic.Value.Date;
            DateTime bitis = dateTimePickerBitis.Value.Date;

            // Yeni detay formunu aç
            AracDetayForm detayForm = new AracDetayForm(aracID, kullaniciID, uyeTipi, baslangic, bitis);
            detayForm.Show();
            this.Hide();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_geridon_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(kullaniciID, uyeTipi);
            form3.Show();
            this.Hide();
        }
    }
}