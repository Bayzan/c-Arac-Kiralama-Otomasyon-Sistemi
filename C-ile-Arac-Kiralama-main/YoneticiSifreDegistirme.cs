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
using System.Text.RegularExpressions;

namespace Arac_kiralama
{
    public partial class YoneticiSifreDegistirme : Form
    {
        private int _yoneticiId;
        private string _yoneticiAd;
        public YoneticiSifreDegistirme(int yoneticiId, string yoneticiAd)
        {
            InitializeComponent();
            _yoneticiId = yoneticiId;
            _yoneticiAd = yoneticiAd;
        }

        private void btn_Degistir_Click(object sender, EventArgs e)
        {
            // Boş alanları kontrol et
            if (string.IsNullOrEmpty(txtYoneticiEposta.Text))
            {
                MessageBox.Show("E-posta alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYoneticiEposta.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtEskiSifre.Text))
            {
                MessageBox.Show("Eski şifre alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEskiSifre.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txt_YeniSifre.Text))
            {
                MessageBox.Show("Yeni şifre alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_YeniSifre.Focus();
                return;
            }

            // E-posta ve eski şifre doğrulaması
            if (!EpostaVeEskiSifreKontrol(txtYoneticiEposta.Text, txtEskiSifre.Text))
            {
                MessageBox.Show("E-posta veya eski şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Yeni şifre ile eski şifrenin aynı olup olmadığını kontrol et
            if (txtEskiSifre.Text == txt_YeniSifre.Text)
            {
                MessageBox.Show("Yeni şifre eski şifre ile aynı olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_YeniSifre.Focus();
                return;
            }

            // Yeni şifre geçerlilik kontrolü
            string sifreDogrulamaHatasi = YeniSifreKontrol(txt_YeniSifre.Text);
            if (!string.IsNullOrEmpty(sifreDogrulamaHatasi))
            {
                MessageBox.Show(sifreDogrulamaHatasi, "Şifre Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_YeniSifre.Focus();
                return;
            }

            // Şifre güncelleme işlemi
            if (SifreGuncelle(txtYoneticiEposta.Text, txt_YeniSifre.Text))
            {
                MessageBox.Show("Şifreniz başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
            }
            else
            {
                MessageBox.Show("Şifre güncellenirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EpostaVeEskiSifreKontrol(string eposta, string eskiSifre)
        {
            bool dogruMu = false;

            try
            {
                using (MySqlConnection baglanti = Arac_kiralama.Veritabani.BaglantiOlustur())
                {
                    baglanti.Open();

                    string sorgu = "SELECT COUNT(*) FROM yoneticiler WHERE Email = @eposta AND sifre = @eskiSifre";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@eposta", eposta);
                        komut.Parameters.AddWithValue("@eskiSifre", eskiSifre);

                        int sonuc = Convert.ToInt32(komut.ExecuteScalar());
                        dogruMu = sonuc > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dogruMu;
        }

        private string YeniSifreKontrol(string yeniSifre)
        {
            // Şifre uzunluğu kontrolü (8 karakterden fazla)
            if (yeniSifre.Length <= 8)
            {
                return "Şifre 8 karakterden fazla olmalıdır!";
            }

            // En az bir sayı kontrolü
            if (!Regex.IsMatch(yeniSifre, @"\d"))
            {
                return "Şifre en az bir sayı içermelidir!";
            }

            // En az bir özel karakter kontrolü
            if (!Regex.IsMatch(yeniSifre, @"[!@#$%^&*(),.?""':;{}|<>]"))
            {
                return "Şifre en az bir özel karakter içermelidir! (!@#$%^&*(),.?\":;{}|<>)";
            }

            return ""; // Hata yoksa boş string döndür
        }

        private bool SifreGuncelle(string eposta, string yeniSifre)
        {
            bool basarili = false;

            try
            {
                using (MySqlConnection baglanti = Arac_kiralama.Veritabani.BaglantiOlustur())
                {
                    baglanti.Open();

                    string sorgu = "UPDATE yoneticiler SET sifre = @yeniSifre WHERE Email = @eposta";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@yeniSifre", yeniSifre);
                        komut.Parameters.AddWithValue("@eposta", eposta);

                        int etkilenenSatir = komut.ExecuteNonQuery();
                        basarili = etkilenenSatir > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Şifre güncellenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return basarili;
        }

        private void btn_geriDon_Click(object sender, EventArgs e)
        {
            YoneticiAnaMenu yoneticiAnaMenu = new YoneticiAnaMenu(_yoneticiId, _yoneticiAd);    
            yoneticiAnaMenu.Show();
            this.Hide();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}