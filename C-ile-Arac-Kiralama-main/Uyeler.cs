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
using Arac_kiralama.Arac_kiralama;

namespace Arac_kiralama
{
    public partial class Uyeler : Form
    {
        private int _yoneticiId;
        private string _yoneticiAd;

        public Uyeler(int yoneticiId, string yoneticiAd)
        {
            InitializeComponent();
            _yoneticiId = yoneticiId;
            _yoneticiAd = yoneticiAd;
            FormBaslangicAyarlari();
        }

        private void FormBaslangicAyarlari()
        {
            // ComboBox'ları doldur
            cmb_uyeTip.Items.Add("Tümü");
            cmb_uyeTip.Items.Add("Bireysel");
            cmb_uyeTip.Items.Add("Ticari");
            cmb_uyeTip.SelectedIndex = 0; // Tümü seçili

            cmb_aramaKriter.Items.Add("ID");
            cmb_aramaKriter.Items.Add("Tel No");
            cmb_aramaKriter.Items.Add("TC No");
            cmb_aramaKriter.Items.Add("Ehliyet Sicil No");
            cmb_aramaKriter.Items.Add("İsim + Soyisim");
            cmb_aramaKriter.SelectedIndex = 0; // ID seçili

            // DataGridView ayarları
            dgv_uyeler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_uyeler.MultiSelect = false;
            dgv_uyeler.ReadOnly = true;
            dgv_uyeler.AllowUserToAddRows = false;

            // Başlangıçta verileri yükle
            UyeIstatistikleriniGuncelle();
            UyeleriListele();
        }

        private void UyeIstatistikleriniGuncelle()
        {
            try
            {
                using (MySqlConnection baglanti = Veritabani.BaglantiOlustur())
                {
                    baglanti.Open();

                    // Bireysel üye sayısı
                    string bireyselSorgu = "SELECT COUNT(*) FROM bireyseluyeler";
                    using (MySqlCommand komut = new MySqlCommand(bireyselSorgu, baglanti))
                    {
                        int bireyselSayisi = Convert.ToInt32(komut.ExecuteScalar());
                        lbl_bireyselUye.Text = bireyselSayisi.ToString();
                    }

                    // Ticari üye sayısı
                    string ticariSorgu = "SELECT COUNT(*) FROM ticariuyeler";
                    using (MySqlCommand komut = new MySqlCommand(ticariSorgu, baglanti))
                    {
                        int ticariSayisi = Convert.ToInt32(komut.ExecuteScalar());
                        lbl_ticariUye.Text = ticariSayisi.ToString();
                    }

                    // Toplam üye sayısı
                    int toplamSayisi = Convert.ToInt32(lbl_bireyselUye.Text) + Convert.ToInt32(lbl_ticariUye.Text);
                    lbl_toplamUye.Text = toplamSayisi.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İstatistik yüklenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UyeleriListele(string aramaKriteri = "", string aramaMetni = "")
        {
            try
            {
                using (MySqlConnection baglanti = Veritabani.BaglantiOlustur())
                {
                    baglanti.Open();
                    DataTable dt = new DataTable();

                    string sorgu = "";
                    string seciliTip = cmb_uyeTip.SelectedItem.ToString();

                    if (seciliTip == "Tümü" || seciliTip == "Bireysel")
                    {
                        string bireyselSorgu = @"SELECT id, isim, soyisim, tel_no, tc_no, e_posta, ehliyet_sicil_no, 
                                               dogum_tarihi, 'Bireysel' as uye_tipi, '' as sirket_adi
                                               FROM bireyseluyeler";

                        if (!string.IsNullOrEmpty(aramaMetni))
                        {
                            bireyselSorgu += OlusturAramaKoşulu(aramaKriteri, aramaMetni);
                        }

                        if (seciliTip == "Tümü")
                        {
                            string ticariSorgu = @"SELECT id, isim, soyisim, tel_no, tc_no, e_posta, ehliyet_sicil_no, 
                                                 dogum_tarihi, 'Ticari' as uye_tipi, sirket_adi
                                                 FROM ticariuyeler";

                            if (!string.IsNullOrEmpty(aramaMetni))
                            {
                                ticariSorgu += OlusturAramaKoşulu(aramaKriteri, aramaMetni);
                            }

                            sorgu = $"({bireyselSorgu}) UNION ALL ({ticariSorgu}) ORDER BY uye_tipi, isim";
                        }
                        else
                        {
                            sorgu = bireyselSorgu + " ORDER BY isim";
                        }
                    }
                    else if (seciliTip == "Ticari")
                    {
                        sorgu = @"SELECT id, isim, soyisim, tel_no, tc_no, e_posta, ehliyet_sicil_no, 
                                dogum_tarihi, 'Ticari' as uye_tipi, sirket_adi
                                FROM ticariuyeler";

                        if (!string.IsNullOrEmpty(aramaMetni))
                        {
                            sorgu += OlusturAramaKoşulu(aramaKriteri, aramaMetni);
                        }

                        sorgu += " ORDER BY isim";
                    }

                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        if (!string.IsNullOrEmpty(aramaMetni))
                        {
                            EkleAramaParametreleri(komut, aramaKriteri, aramaMetni);
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(komut))
                        {
                            adapter.Fill(dt);
                        }
                    }

                    dgv_uyeler.DataSource = dt;
                    DataGridViewAyarla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Üyeler listelenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string OlusturAramaKoşulu(string kriter, string metin)
        {
            switch (kriter)
            {
                case "ID":
                    return " WHERE id = @aramaMetni";
                case "Tel No":
                    return " WHERE tel_no LIKE @aramaMetni";
                case "TC No":
                    return " WHERE tc_no LIKE @aramaMetni";
                case "Ehliyet Sicil No":
                    return " WHERE ehliyet_sicil_no LIKE @aramaMetni";
                case "İsim + Soyisim":
                    return " WHERE CONCAT(isim, ' ', soyisim) LIKE @aramaMetni";
                default:
                    return "";
            }
        }

        private void EkleAramaParametreleri(MySqlCommand komut, string kriter, string metin)
        {
            if (kriter == "ID")
            {
                if (int.TryParse(metin, out int id))
                {
                    komut.Parameters.AddWithValue("@aramaMetni", id);
                }
                else
                {
                    komut.Parameters.AddWithValue("@aramaMetni", -1); // Geçersiz ID
                }
            }
            else
            {
                komut.Parameters.AddWithValue("@aramaMetni", "%" + metin + "%");
            }
        }

        private void DataGridViewAyarla()
        {
            if (dgv_uyeler.Columns.Count > 0)
            {
                dgv_uyeler.Columns["id"].HeaderText = "ID";
                dgv_uyeler.Columns["isim"].HeaderText = "İsim";
                dgv_uyeler.Columns["soyisim"].HeaderText = "Soyisim";
                dgv_uyeler.Columns["tel_no"].HeaderText = "Telefon";
                dgv_uyeler.Columns["tc_no"].HeaderText = "TC No";
                dgv_uyeler.Columns["e_posta"].HeaderText = "E-Posta";
                dgv_uyeler.Columns["ehliyet_sicil_no"].HeaderText = "Ehliyet Sicil";
                dgv_uyeler.Columns["dogum_tarihi"].HeaderText = "Doğum Tarihi";
                dgv_uyeler.Columns["uye_tipi"].HeaderText = "Üye Tipi";

                if (dgv_uyeler.Columns.Contains("sirket_adi"))
                {
                    dgv_uyeler.Columns["sirket_adi"].HeaderText = "Şirket Adı";
                }

                // Kolon genişliklerini ayarla
                dgv_uyeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_aramaMetni.Text))
            {
                MessageBox.Show("Arama metni giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kriter = cmb_aramaKriter.SelectedItem.ToString();
            string metin = txt_aramaMetni.Text.Trim();

            UyeleriListele(kriter, metin);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_aramaMetni.Clear();
            cmb_uyeTip.SelectedIndex = 0;
            cmb_aramaKriter.SelectedIndex = 0;
            UyeleriListele();
        }

        private void cmb_uyeTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            UyeleriListele();
        }

        private void btn_uyelikKaldir_Click(object sender, EventArgs e)
        {
            if (dgv_uyeler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen üyeliğini kaldırmak istediğiniz üyeyi seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow secilenSatir = dgv_uyeler.SelectedRows[0];
            string uyeId = secilenSatir.Cells["id"].Value.ToString();
            string uyeAdi = secilenSatir.Cells["isim"].Value.ToString();
            string uyeSoyadi = secilenSatir.Cells["soyisim"].Value.ToString();
            string uyeTipi = secilenSatir.Cells["uye_tipi"].Value.ToString();

            DialogResult sonuc = MessageBox.Show(
                $"{uyeAdi} {uyeSoyadi} adlı {uyeTipi.ToLower()} üyenin üyeliğini kaldırmak istediğinizden emin misiniz?\n\nBu işlem geri alınamaz!",
                "Üyelik Kaldırma Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (sonuc == DialogResult.Yes)
            {
                UyeligiKaldir(uyeId, uyeTipi);
            }
        }

        private void UyeligiKaldir(string uyeId, string uyeTipi)
        {
            try
            {
                using (MySqlConnection baglanti = Veritabani.BaglantiOlustur())
                {
                    baglanti.Open();

                    string tabloAdi = uyeTipi == "Bireysel" ? "bireyseluyeler" : "ticariuyeler";
                    string sorgu = $"DELETE FROM {tabloAdi} WHERE id = @uyeId";

                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@uyeId", int.Parse(uyeId));

                        int etkilenenSatir = komut.ExecuteNonQuery();

                        if (etkilenenSatir > 0)
                        {
                            MessageBox.Show("Üyelik başarıyla kaldırıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Listeleri güncelle
                            UyeIstatistikleriniGuncelle();
                            UyeleriListele();
                        }
                        else
                        {
                            MessageBox.Show("Üyelik kaldırılırken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_geriDon_Click(object sender, EventArgs e)
        {
            YoneticiAnaMenu yoneticiAnaMenu = new YoneticiAnaMenu(_yoneticiId, _yoneticiAd);
            yoneticiAnaMenu.Show();
            this.Hide();
        }

        private void dgv_uyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}