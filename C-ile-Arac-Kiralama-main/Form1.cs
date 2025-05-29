using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arac_kiralama.Arac_kiralama;
using MySql.Data.MySqlClient;

namespace Arac_kiralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string eposta = txtEposta.Text;
            string sifre = txtSifre.Text;

            using (MySqlConnection baglanti = Veritabani.BaglantiOlustur())
            {
                try
                {
                    baglanti.Open();

                    // Bireysel üyeler tablosunda ara
                    string bireyselSorgu = "SELECT id FROM bireyseluyeler WHERE e_posta = @eposta AND sifre = @sifre";
                    MySqlCommand bireyselKomut = new MySqlCommand(bireyselSorgu, baglanti);
                    bireyselKomut.Parameters.AddWithValue("@eposta", eposta);
                    bireyselKomut.Parameters.AddWithValue("@sifre", sifre);

                    object bireyselSonuc = bireyselKomut.ExecuteScalar();

                    if (bireyselSonuc != null)
                    {
                        int kullaniciID = Convert.ToInt32(bireyselSonuc);
                        // Giriş başarılı – bireysel üye
                        Form3 form3 = new Form3(kullaniciID);  // veya başka form
                        form3.Show();
                        this.Hide();
                        return;
                    }

                    // Ticari üyeler tablosunda ara
                    string ticariSorgu = "SELECT id FROM ticariuyeler WHERE e_posta = @eposta AND sifre = @sifre";
                    MySqlCommand ticariKomut = new MySqlCommand(ticariSorgu, baglanti);
                    ticariKomut.Parameters.AddWithValue("@eposta", eposta);
                    ticariKomut.Parameters.AddWithValue("@sifre", sifre);

                    object ticariSonuc = ticariKomut.ExecuteScalar();

                    if (ticariSonuc != null)
                    {
                        int kullaniciID = Convert.ToInt32(ticariSonuc);
                        // Giriş başarılı – ticari üye
                        Form3 form3 = new Form3(kullaniciID);  // istersen farklı bir form yap ticari için
                        form3.Show();
                        this.Hide();
                        return;
                    }

                    // Hiçbir eşleşme yoksa
                    MessageBox.Show("Hatalı e-posta veya şifre.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı hatası: " + ex.Message);
                }
            }
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_uye_Click(object sender, EventArgs e)
        {
            UyeOlEkranıcs uyeOlEkranıcs = new UyeOlEkranıcs();
            uyeOlEkranıcs.Show();
            this.Hide();
        }

        private void btn_yonetici_Click(object sender, EventArgs e)
        {
            YoneticiGiris yoneticiGirisEkranı = new YoneticiGiris();
            yoneticiGirisEkranı.Show();
            this.Hide();
        }
    }
}
