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

namespace Arac_kiralama
{
    public partial class YoneticiGiris : Form
    {
        public YoneticiGiris()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string eposta = txtYoneticiEposta.Text.Trim();
            string sifre = txtYoneticiSifre.Text.Trim();

            if (string.IsNullOrWhiteSpace(eposta) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen e-posta ve şifre alanlarını doldurun.");
                return;
            }

            using (MySqlConnection baglanti = Veritabani.BaglantiOlustur())
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "SELECT YoneticiID, YoneticiAd FROM yoneticiler WHERE Email = @eposta AND sifre = @sifre";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@eposta", eposta);
                    komut.Parameters.AddWithValue("@sifre", sifre);

                    using (MySqlDataReader reader = komut.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int yoneticiID = reader.GetInt32("YoneticiID");
                            string yoneticiAd = reader.GetString("YoneticiAd");

                            MessageBox.Show("Giriş başarılı. Hoş geldiniz " + yoneticiAd);

                            // Yeni formu oluştur ve bilgileri aktar
                            YoneticiAnaMenu anaMenu = new YoneticiAnaMenu(yoneticiID, yoneticiAd);
                            anaMenu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Hatalı e-posta veya şifre.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btn_geriDon_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamayı kapatır
        }

        private void YoneticiGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
