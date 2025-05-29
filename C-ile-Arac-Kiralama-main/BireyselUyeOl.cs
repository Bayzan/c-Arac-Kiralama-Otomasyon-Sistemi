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
    public partial class BireyselUyeOl : Form
    {
        public BireyselUyeOl()
        {
            InitializeComponent();
        }

        private void btn_GeriDon_Click(object sender, EventArgs e)
        {

        }

        private void btn_ÇikisYap_Click(object sender, EventArgs e)
        {

        }

        private void btn_uyeol_Click(object sender, EventArgs e)
        {
            // TextBox'lardan verileri al
            string isim = txt_isim.Text.Trim();
            string soyisim = txt_Soyisim.Text.Trim();
            string eposta = txt_eposta.Text.Trim();
            string telno = txt_Telno.Text.Trim();
            string dogum = txt_dogum.Text.Trim();
            string sicilno = txt_sicilno.Text.Trim();
            string tcno = txt_tcno.Text.Trim();
            string sifre = txt_Sifre.Text.Trim();

            // 1. Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(isim) || string.IsNullOrWhiteSpace(soyisim) ||
                string.IsNullOrWhiteSpace(eposta) || string.IsNullOrWhiteSpace(telno) ||
                string.IsNullOrWhiteSpace(dogum) || string.IsNullOrWhiteSpace(sicilno) ||
                string.IsNullOrWhiteSpace(tcno) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            using (MySqlConnection baglanti = Veritabani.BaglantiOlustur())
            {
                try
                {
                    baglanti.Open();

                    // Aynı tc_no, ehliyet_sicil_no, tel_no, e_posta kontrolü
                    string kontrolSorgu = @"
                SELECT tel_no, tc_no, e_posta, ehliyet_sicil_no 
                FROM bireyseluyeler 
                WHERE tel_no = @telno OR tc_no = @tcno OR e_posta = @eposta OR ehliyet_sicil_no = @sicilno";

                    MySqlCommand kontrolKomut = new MySqlCommand(kontrolSorgu, baglanti);
                    kontrolKomut.Parameters.AddWithValue("@telno", telno);
                    kontrolKomut.Parameters.AddWithValue("@tcno", tcno);
                    kontrolKomut.Parameters.AddWithValue("@eposta", eposta);
                    kontrolKomut.Parameters.AddWithValue("@sicilno", sicilno);

                    using (MySqlDataReader reader = kontrolKomut.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["tel_no"].ToString() == telno)
                            {
                                MessageBox.Show("Bu telefon numarası zaten kayıtlı.");
                                return;
                            }
                            else if (reader["tc_no"].ToString() == tcno)
                            {
                                MessageBox.Show("Bu TC kimlik numarası zaten kayıtlı.");
                                return;
                            }
                            else if (reader["e_posta"].ToString() == eposta)
                            {
                                MessageBox.Show("Bu e-posta adresi zaten kayıtlı.");
                                return;
                            }
                            else if (reader["ehliyet_sicil_no"].ToString() == sicilno)
                            {
                                MessageBox.Show("Bu ehliyet sicil numarası zaten kayıtlı.");
                                return;
                            }
                        }
                    }

                    // Eğer kontrol aşamasında kayıt bulunmazsa kayıt işlemi:
                    string kayitSorgu = @"
                INSERT INTO bireyseluyeler 
                (isim, soyisim, tel_no, tc_no, e_posta, ehliyet_sicil_no, dogum_tarihi, sifre)
                VALUES (@isim, @soyisim, @telno, @tcno, @eposta, @sicilno, @dogum, @sifre)";

                    MySqlCommand kayitKomut = new MySqlCommand(kayitSorgu, baglanti);
                    kayitKomut.Parameters.AddWithValue("@isim", isim);
                    kayitKomut.Parameters.AddWithValue("@soyisim", soyisim);
                    kayitKomut.Parameters.AddWithValue("@telno", telno);
                    kayitKomut.Parameters.AddWithValue("@tcno", tcno);
                    kayitKomut.Parameters.AddWithValue("@eposta", eposta);
                    kayitKomut.Parameters.AddWithValue("@sicilno", sicilno);
                    kayitKomut.Parameters.AddWithValue("@dogum", dogum);
                    kayitKomut.Parameters.AddWithValue("@sifre", sifre);

                    int sonuc = kayitKomut.ExecuteNonQuery();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla oluşturuldu.");
                        //this.Close(); // Formu kapatmak istersen
                    }
                    else
                    {
                        MessageBox.Show("Kayıt oluşturulamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

    }
}
