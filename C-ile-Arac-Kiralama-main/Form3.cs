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
    public partial class Form3 : Form
    {
        int kullaniciID;
        string uyeTipi; // "bireysel" veya "ticari"

        public Form3(int id, string tip)
        {
            InitializeComponent();
            kullaniciID = id;
            uyeTipi = tip;
        }
        private void btn_sifredegistir_Click(object sender, EventArgs e)
        {
            UyeSifreDegistirme sifreDegistir = new UyeSifreDegistirme(kullaniciID, uyeTipi);
            sifreDegistir.Show();
            this.Hide();
        }

        private void btn_arackirala_Click(object sender, EventArgs e)
        {
            Form2 kirala = new Form2(kullaniciID,uyeTipi);
            kirala.Show();
            this.Hide();
        }

        private void btn_kiralamalarım_Click(object sender, EventArgs e)
        {
            gb_mevcut_araclarım.Controls.Clear(); // Önceki içerikleri temizle
            gb_mevcut_araclarım.Text = "Mevcut Araçlarım";

            using (MySqlConnection baglanti = Veritabani.BaglantiOlustur())
            {
                try
                {
                    baglanti.Open();

                    string query = @"
                SELECT 
                    a.marka, a.model, a.yil, a.sehir,
                    k.baslangic_tarihi, k.bitis_tarihi
                FROM kiralamalar k
                INNER JOIN araclar a ON k.arac_id = a.aracID
                WHERE k.kullanici_id = @kullaniciID";

                    MySqlCommand komut = new MySqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@kullaniciID", kullaniciID);

                    using (MySqlDataReader reader = komut.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            int y = 20; // Yatay konumlama için başlangıç
                            while (reader.Read())
                            {
                                string marka = reader["marka"].ToString();
                                string model = reader["model"].ToString();
                                string yil = reader["yil"].ToString();
                                string sehir = reader["sehir"].ToString();
                                string baslangic = Convert.ToDateTime(reader["baslangic_tarihi"]).ToShortDateString();
                                string bitis = Convert.ToDateTime(reader["bitis_tarihi"]).ToShortDateString();

                                Label lbl = new Label();
                                lbl.Text = $"Araç: {marka} {model} ({yil}) - {sehir} | Kiralama: {baslangic} → {bitis}";
                                lbl.Location = new Point(10, y);
                                lbl.AutoSize = true;

                                gb_mevcut_araclarım.Controls.Add(lbl);
                                y += 25;
                            }
                        }
                        else
                        {
                            Label lbl = new Label();
                            lbl.Text = "Bir araç kiralamadınız.";
                            lbl.Location = new Point(10, 20);
                            lbl.AutoSize = true;

                            gb_mevcut_araclarım.Controls.Add(lbl);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri alınırken hata oluştu: " + ex.Message);
                }
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Tüm uygulamayı sonlandırır
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {

        }
    }
}
