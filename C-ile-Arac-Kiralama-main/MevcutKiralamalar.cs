using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arac_kiralama;
using Arac_kiralama.Arac_kiralama;
using MySql.Data.MySqlClient;

namespace Arac_kiralama
{
    public partial class MevcutKiralamalar : Form
    {
        private int yoneticiId;
        private string yoneticiIsim; // This will now hold the admin's name

        public MevcutKiralamalar(int id)
        {
            InitializeComponent();
            yoneticiId = id;
            GetYoneticiIsim(); // Call this method to fetch the admin's name
        }

        // New method to get the administrator's name from the database
        private void GetYoneticiIsim()
        {
            try
            {
                using (MySqlConnection conn = Veritabani.BaglantiOlustur())
                {
                    conn.Open();
                    // Assuming your admin table is named 'yoneticiler' and has 'id' and 'isim' columns
                    string query = "SELECT YoneticiAd FROM yoneticiler WHERE YoneticiID = @yoneticiId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@yoneticiId", yoneticiId);
                    object result = cmd.ExecuteScalar(); // Executes the query and returns the first column of the first row

                    if (result != null)
                    {
                        yoneticiIsim = result.ToString();
                    }
                    else
                    {
                        yoneticiIsim = "Bilinmiyor"; // Default value if name is not found
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yönetici ismi alınırken hata oluştu: " + ex.Message);
                yoneticiIsim = "Hata"; // Indicate an error occurred
            }
        }

        private void Kiralamalar_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = Veritabani.BaglantiOlustur())
                {
                    conn.Open();
                    MessageBox.Show("Veritabanı bağlantısı başarılı!"); // DEBUG
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
            }

            SehirleriDoldur();
            YakitTipleriniDoldur();
            VitesTipleriniDoldur();
        }

        private void SehirleriDoldur()
        {
            try
            {
                using (MySqlConnection conn = Veritabani.BaglantiOlustur())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT sehir FROM araclar", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbSehir.Items.Clear();
                    cmbSehir.Items.Add(""); // boş seçenek

                    while (reader.Read())
                    {
                        cmbSehir.Items.Add(reader["sehir"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SehirleriDoldur() Hata: " + ex.Message);
            }
        }

        private void VitesTipleriniDoldur()
        {
            using (MySqlConnection conn = Veritabani.BaglantiOlustur())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT vites_tipi FROM araclar", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                cmbVitesTipi.Items.Clear();
                cmbVitesTipi.Items.Add("");

                while (reader.Read())
                {
                    cmbVitesTipi.Items.Add(reader["vites_tipi"].ToString());
                }

                reader.Close();
            }
        }

        private void YakitTipleriniDoldur()
        {
            using (MySqlConnection conn = Veritabani.BaglantiOlustur())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT yakit_tipi FROM araclar", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                cmbYakitTipi.Items.Clear();
                cmbYakitTipi.Items.Add("");

                while (reader.Read())
                {
                    cmbYakitTipi.Items.Add(reader["yakit_tipi"].ToString());
                }

                reader.Close();
            }
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            List<string> kosullar = new List<string>();

            if (!string.IsNullOrEmpty(cmbSehir.Text))
                kosullar.Add($"a.sehir = '{cmbSehir.Text}'");

            if (!string.IsNullOrEmpty(cmbYakitTipi.Text))
                kosullar.Add($"a.yakit_tipi = '{cmbYakitTipi.Text}'");

            if (!string.IsNullOrEmpty(cmbVitesTipi.Text))
                kosullar.Add($"a.vites_tipi = '{cmbVitesTipi.Text}'");

            // Sadece biri seçiliyse onu filtrele
            if (chkBireysel.Checked && !chkTicari.Checked)
                kosullar.Add("k.uye_turu = 'bireysel'");
            else if (!chkBireysel.Checked && chkTicari.Checked)
                kosullar.Add("k.uye_turu = 'ticari'");
            // Eğer ikisi de seçiliyse filtreleme yapma

            // Koşulları WHERE'e ekle
            string whereKosulu = kosullar.Count > 0 ? "WHERE " + string.Join(" AND ", kosullar) : "";

            string sql = $@"
            SELECT 
                k.id AS kiralama_id,
                a.marka, a.model, a.plaka, a.sehir, a.yakit_tipi, a.vites_tipi,
                k.baslangic_tarihi, k.bitis_tarihi,
                CASE 
                    WHEN k.uye_turu = 'bireysel' THEN bu.isim
                    ELSE tu.isim
                END AS isim,
                CASE 
                    WHEN k.uye_turu = 'bireysel' THEN bu.soyisim
                    ELSE tu.soyisim
                END AS soyisim,
                CASE 
                    WHEN k.uye_turu = 'bireysel' THEN bu.tel_no
                    ELSE tu.tel_no
                END AS tel,
                bu.tc_no AS bireysel_tc_no,
                tu.sirket_adi AS sirket_adi,
                CASE 
                    WHEN k.uye_turu = 'bireysel' THEN bu.e_posta
                    ELSE tu.e_posta
                END AS eposta,
                CASE 
                    WHEN k.uye_turu = 'bireysel' THEN bu.ehliyet_sicil_no
                    ELSE tu.ehliyet_sicil_no
                END AS ehliyet_sicil_no
            FROM kiralamalar k
            JOIN araclar a ON a.aracID = k.arac_id
            LEFT JOIN bireyseluyeler bu ON k.uye_turu = 'bireysel' AND k.kullanici_id = bu.id
            LEFT JOIN ticariuyeler tu ON k.uye_turu = 'ticari' AND k.kullanici_id = tu.id
            {whereKosulu};
        ";


            using (MySqlConnection conn = Veritabani.BaglantiOlustur())
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKiralamalar.DataSource = dt;
            }
        }


        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            if (dgvKiralamalar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen iptal etmek istediğiniz kiralamayı seçin.");
                return;
            }

            int kiralamaId = Convert.ToInt32(dgvKiralamalar.SelectedRows[0].Cells["kiralama_id"].Value);

            DialogResult sonuc = MessageBox.Show("Bu kiralamayı iptal etmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);

            if (sonuc == DialogResult.Yes)
            {
                using (MySqlConnection conn = Veritabani.BaglantiOlustur())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM kiralamalar WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", kiralamaId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Kiralama başarıyla iptal edildi.");
                btnFiltrele.PerformClick(); // listeyi güncelle
            }
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSehir.SelectedIndex == 0) cmbSehir.SelectedItem = null;
        }

        private void chkBireysel_CheckedChanged(object sender, EventArgs e)
        {
            // Gerekirse boş seçimleri kontrol edebilirsin
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_GeriDon_Click(object sender, EventArgs e)
        {
            YoneticiAnaMenu yoneticiAnaMenu = new YoneticiAnaMenu(yoneticiId, yoneticiIsim);
            yoneticiAnaMenu.Show();
            this.Hide();
        }

        private void btn_GeriDon_Click_1(object sender, EventArgs e)
        {
            YoneticiAnaMenu yoneticiAnaMenu = new YoneticiAnaMenu(yoneticiId, yoneticiIsim);
            yoneticiAnaMenu.Show();
            this.Hide(); // Mevcut formu gizle
        }

        private void btn_Cikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
