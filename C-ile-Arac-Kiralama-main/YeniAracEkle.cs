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
    public partial class YeniAracEkle : Form
    {
        private int _yoneticiId;
        private string _yoneticiAd;
        public YeniAracEkle(int yoneticiId, string yoneticiAd)
        {
            InitializeComponent();
            ComboBoxlariDoldur();
            _yoneticiId = yoneticiId;
            _yoneticiAd = yoneticiAd;
        }

        private void ComboBoxlariDoldur()
        {
            // Vites tipi combobox'ını doldur
            cmbVites.Items.Clear();
            cmbVites.Items.Add("Otomatik");
            cmbVites.Items.Add("Manuel");
            cmbVites.DropDownStyle = ComboBoxStyle.DropDownList;

            // Yakıt tipi combobox'ını doldur
            cmbYakit.Items.Clear();
            cmbYakit.Items.Add("Benzin");
            cmbYakit.Items.Add("Dizel");
            cmbYakit.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private bool ValidasyonKontrol()
        {
            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(txt_marka.Text))
            {
                MessageBox.Show("Marka alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_marka.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_model.Text))
            {
                MessageBox.Show("Model alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_model.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_yil.Text))
            {
                MessageBox.Show("Yıl alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_yil.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_kilometre.Text))
            {
                MessageBox.Show("Kilometre alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_kilometre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_plaka.Text))
            {
                MessageBox.Show("Plaka alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_plaka.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_sehir.Text))
            {
                MessageBox.Show("Şehir alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sehir.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_ucret.Text))
            {
                MessageBox.Show("Günlük ücret alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ucret.Focus();
                return false;
            }

            if (cmbVites.SelectedIndex == -1)
            {
                MessageBox.Show("Vites tipi seçilmelidir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbVites.Focus();
                return false;
            }

            if (cmbYakit.SelectedIndex == -1)
            {
                MessageBox.Show("Yakıt tipi seçilmelidir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbYakit.Focus();
                return false;
            }

            // Yıl kontrolü (2000-2025 arası, 4 haneli)
            if (!int.TryParse(txt_yil.Text, out int yil))
            {
                MessageBox.Show("Yıl alanına sadece sayı girilmelidir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_yil.Focus();
                return false;
            }

            if (txt_yil.Text.Length != 4)
            {
                MessageBox.Show("Yıl 4 haneli olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_yil.Focus();
                return false;
            }

            if (yil < 2000 || yil > 2025)
            {
                MessageBox.Show("Yıl 2000 ile 2025 arasında olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_yil.Focus();
                return false;
            }

            // Kilometre kontrolü (pozitif sayı)
            if (!double.TryParse(txt_kilometre.Text, out double kilometre))
            {
                MessageBox.Show("Kilometre alanına sadece sayı girilmelidir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_kilometre.Focus();
                return false;
            }

            if (kilometre < 0)
            {
                MessageBox.Show("Kilometre pozitif bir değer olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_kilometre.Focus();
                return false;
            }

            // Günlük ücret kontrolü (pozitif sayı)
            if (!decimal.TryParse(txt_ucret.Text, out decimal ucret))
            {
                MessageBox.Show("Günlük ücret alanına sadece sayı girilmelidir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ucret.Focus();
                return false;
            }

            if (ucret <= 0)
            {
                MessageBox.Show("Günlük ücret pozitif bir değer olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ucret.Focus();
                return false;
            }

            return true;
        }

        private void AracEkle()
        {
            try
            {
                using (MySqlConnection baglanti = Veritabani.BaglantiOlustur())
                {
                    baglanti.Open();

                    string sorgu = @"INSERT INTO araclar (marka, model, yil, sehir, vites_tipi, yakit_tipi, gunluk_ucret, kilometre, plaka) 
                                   VALUES (@marka, @model, @yil, @sehir, @vites_tipi, @yakit_tipi, @gunluk_ucret, @kilometre, @plaka)";

                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@marka", txt_marka.Text.Trim());
                        komut.Parameters.AddWithValue("@model", txt_model.Text.Trim());
                        komut.Parameters.AddWithValue("@yil", int.Parse(txt_yil.Text));
                        komut.Parameters.AddWithValue("@sehir", txt_sehir.Text.Trim());
                        komut.Parameters.AddWithValue("@vites_tipi", cmbVites.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("@yakit_tipi", cmbYakit.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("@gunluk_ucret", decimal.Parse(txt_ucret.Text));
                        komut.Parameters.AddWithValue("@kilometre", double.Parse(txt_kilometre.Text));
                        komut.Parameters.AddWithValue("@plaka", txt_plaka.Text.Trim().ToUpper());

                        int etkilenenSatir = komut.ExecuteNonQuery();

                        if (etkilenenSatir > 0)
                        {
                            MessageBox.Show("Araç başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormuTemizle();
                        }
                        else
                        {
                            MessageBox.Show("Araç eklenirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormuTemizle()
        {
            txt_marka.Clear();
            txt_model.Clear();
            txt_yil.Clear();
            txt_kilometre.Clear();
            txt_plaka.Clear();
            txt_sehir.Clear();
            txt_ucret.Clear();
            cmbVites.SelectedIndex = -1;
            cmbYakit.SelectedIndex = -1;
            txt_marka.Focus();
        }


        private void btn_geriDon_Click(object sender, EventArgs e)
        {
            YoneticiAnaMenu yoneticiAnaMenu = new YoneticiAnaMenu(_yoneticiId, _yoneticiAd); 
            yoneticiAnaMenu.Show();
            this.Hide();
        }

        // TextBox'larda sadece sayı girişi için event handler'lar
        private void txt_yil_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakam ve backspace kabul et
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_kilometre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakam, nokta, virgül ve backspace kabul et
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txt_ucret_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakam, nokta, virgül ve backspace kabul et
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamayı kapatır
        }

        private void btn_AracEkle_Click(object sender, EventArgs e)
        {
            if (ValidasyonKontrol())
            {
                AracEkle();
            }
        }
    }
}