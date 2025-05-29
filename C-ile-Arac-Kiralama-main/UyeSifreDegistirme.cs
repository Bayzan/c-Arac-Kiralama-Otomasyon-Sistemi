using System;
using System.Windows.Forms;
using Arac_kiralama.Arac_kiralama;
using MySql.Data.MySqlClient;

namespace Arac_kiralama
{
    public partial class UyeSifreDegistirme : Form
    {
        private int kullaniciID;
        private string uyeTipi;

        public UyeSifreDegistirme(int id, string tip)
        {
            InitializeComponent();
            kullaniciID = id;
            uyeTipi = tip;
        }

        private void btn_Degistir_Click(object sender, EventArgs e)
        {
            string eskiSifre = txtEskiSifre.Text.Trim();
            string yeniSifre = txt_YeniSifre.Text.Trim();

            if (string.IsNullOrEmpty(eskiSifre) || string.IsNullOrEmpty(yeniSifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            string tablo = (uyeTipi == "bireysel") ? "bireyseluyeler" : "ticariuyeler";

            using (MySqlConnection baglanti = Veritabani.BaglantiOlustur())
            {
                try
                {
                    baglanti.Open();

                    // Eski şifre kontrolü
                    string kontrolSorgu = $"SELECT COUNT(*) FROM {tablo} WHERE id = @id AND sifre = @sifre";
                    MySqlCommand kontrolKomut = new MySqlCommand(kontrolSorgu, baglanti);
                    kontrolKomut.Parameters.AddWithValue("@id", kullaniciID);
                    kontrolKomut.Parameters.AddWithValue("@sifre", eskiSifre);

                    int sonuc = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                    if (sonuc == 0)
                    {
                        MessageBox.Show("Eski şifre yanlış.");
                        return;
                    }

                    // Yeni şifre güncelleme
                    string guncelleSorgu = $"UPDATE {tablo} SET sifre = @yeniSifre WHERE id = @id";
                    MySqlCommand guncelleKomut = new MySqlCommand(guncelleSorgu, baglanti);
                    guncelleKomut.Parameters.AddWithValue("@yeniSifre", yeniSifre);
                    guncelleKomut.Parameters.AddWithValue("@id", kullaniciID);
                    guncelleKomut.ExecuteNonQuery();

                    MessageBox.Show("Şifre başarıyla güncellendi.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }

        private void UyeSifreDegistirme_Load(object sender, EventArgs e)
        {
            // E-posta'yı sadece görüntü amaçlı gösterebilirsin (veritabanından çekilerek)
            txtYoneticiEposta.ReadOnly = true;

            string tablo = (uyeTipi == "bireysel") ? "bireyseluyeler" : "ticariuyeler";

            using (MySqlConnection baglanti = Veritabani.BaglantiOlustur())
            {
                try
                {
                    baglanti.Open();
                    string sorgu = $"SELECT email FROM {tablo} WHERE id = @id";
                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@id", kullaniciID);

                    var eposta = komut.ExecuteScalar();
                    if (eposta != null)
                        txtYoneticiEposta.Text = eposta.ToString();
                }
                catch
                {
                    txtYoneticiEposta.Text = "E-posta bulunamadı";
                }
            }
        }

        private void btn_geriDon_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(kullaniciID, uyeTipi);
            form3.Show();
            this.Hide();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamayı kapatır
        }
    }
}
