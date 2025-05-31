using System;
using System.Windows.Forms;
using Arac_kiralama.Arac_kiralama;
using MySql.Data.MySqlClient;

namespace Arac_kiralama
{
    public partial class KiralamaForm : Form
    {
        private int aracID;
        private int kullaniciID;
        private string uyeTipi;
        private DateTime baslangicTarihi;
        private DateTime bitisTarihi;

        public KiralamaForm(int aracID, int kullaniciID, string uyeTipi, DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            InitializeComponent();

            this.aracID = aracID;
            this.kullaniciID = kullaniciID;
            this.uyeTipi = uyeTipi;
            this.baslangicTarihi = baslangicTarihi;
            this.bitisTarihi = bitisTarihi;
        }

        private void btn_Ode_Click(object sender, EventArgs e)
        {
            string kartNo = txt_kartNo.Text.Trim();
            string guvenlikKodu = txt_kod.Text.Trim();

            string kartSorgu = "SELECT COUNT(*) FROM kartbilgileri WHERE kart_numarasi = @kartNo AND guvenlik_kodu = @guvenlikKodu";

            using (MySqlConnection conn = Veritabani.BaglantiOlustur())
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(kartSorgu, conn);
                    cmd.Parameters.AddWithValue("@kartNo", kartNo);
                    cmd.Parameters.AddWithValue("@guvenlikKodu", guvenlikKodu);

                    int kartVarMi = Convert.ToInt32(cmd.ExecuteScalar());

                    if (kartVarMi > 0)
                    {
                        // Kiralama işlemi yapılabilir
                        string kiralaSorgu = "INSERT INTO kiralamalar (arac_id, kullanici_id, baslangic_tarihi, bitis_tarihi, uye_turu) " +
                                             "VALUES (@aracID, @kullaniciID, @baslangic, @bitis, @uyeTipi)";

                        MySqlCommand kiralaCmd = new MySqlCommand(kiralaSorgu, conn);
                        kiralaCmd.Parameters.AddWithValue("@aracID", aracID);
                        kiralaCmd.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                        kiralaCmd.Parameters.AddWithValue("@baslangic", baslangicTarihi);
                        kiralaCmd.Parameters.AddWithValue("@bitis", bitisTarihi);
                        kiralaCmd.Parameters.AddWithValue("@uyeTipi", uyeTipi);

                        kiralaCmd.ExecuteNonQuery();

                        MessageBox.Show("Araç başarıyla kiralandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kart bilgileri hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_geriDon_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(kullaniciID, uyeTipi);
            form3.Show();
            this.Hide();
        }
    }
}
