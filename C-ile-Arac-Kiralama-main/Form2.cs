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
    public partial class Form2 : Form
    {
        private int kullaniciID;
        private string uyeTipi; // "bireysel" veya "ticari"

        public Form2(int kullaniciID, string uyeTipi)
        {
            InitializeComponent();
            this.kullaniciID = kullaniciID;
            this.uyeTipi = uyeTipi;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxSehir.Items.Add("İstanbul");
            comboBoxSehir.Items.Add("Ankara");
            comboBoxSehir.Items.Add("İzmir");
            comboBoxSehir.Items.Add("Antalya");
            comboBoxSehir.Items.Add("Bursa");
            comboBoxSehir.SelectedIndex = 0;

            // Tarih kısıtlamaları
            DateTime bugun = DateTime.Now.Date;
            DateTime yarin = bugun.AddDays(1);

            dateTimePickerBaslangic.MinDate = bugun;
            dateTimePickerBaslangic.MaxDate = bugun.AddDays(2); // En fazla 3 günlük kiralama için başlangıç tarihi

            dateTimePickerBitis.MinDate = yarin;
            dateTimePickerBitis.MaxDate = bugun.AddDays(3); // 3 gün sınırı

            dateTimePickerBaslangic.Value = bugun;
            dateTimePickerBitis.Value = yarin;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            using (MySqlConnection baglanti = Veritabani.BaglantiOlustur())
            {
                try
                {
                    baglanti.Open();

                    string query = "SELECT * FROM araclar WHERE sehir = @sehir";

                    if (chkFiyatFiltrele.Checked)
                        query += " AND gunluk_ucret <= @fiyat";
                    if (chkKmFiltrele.Checked)
                        query += " AND kilometre <= @km";

                    if (cb_otomatik.Checked)
                        query += " AND vites_tipi = 'Otomatik'";
                    else if (cb_manuel.Checked)
                        query += " AND vites_tipi = 'Manuel'";

                    if (cb_benzin.Checked)
                        query += " AND yakit_tipi = 'Benzin'";
                    if (cb_dizel.Checked)
                        query += " AND yakit_tipi = 'Dizel'";
                    if (cb_elektrikli.Checked)
                        query += " AND yakit_tipi = 'Elektrik'";
                    if (cb_hibrit.Checked)
                        query += " AND yakit_tipi = 'Hibrit'";

                    query += @" AND aracID NOT IN (
                        SELECT arac_id FROM kiralamalar 
                        WHERE (@baslangic < bitis_tarihi AND @bitis > baslangic_tarihi)
                    )";

                    MySqlCommand komut = new MySqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@sehir", comboBoxSehir.SelectedItem.ToString());
                    komut.Parameters.AddWithValue("@baslangic", dateTimePickerBaslangic.Value.Date);
                    komut.Parameters.AddWithValue("@bitis", dateTimePickerBitis.Value.Date);

                    if (chkFiyatFiltrele.Checked)
                        komut.Parameters.AddWithValue("@fiyat", nudFiyat.Value);
                    if (chkKmFiltrele.Checked)
                        komut.Parameters.AddWithValue("@km", nudKm.Value);

                    MySqlDataAdapter da = new MySqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Uygun araç bulunamadı.");
                    }

                    dgvSonuclar.AutoGenerateColumns = true;
                    dgvSonuclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgvSonuclar.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btn_kirala_Click(object sender, EventArgs e)
        {
            if (dgvSonuclar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen kiralamak istediğiniz aracı seçiniz.");
                return;
            }

            DateTime baslangic = dateTimePickerBaslangic.Value.Date;
            DateTime bitis = dateTimePickerBitis.Value.Date;

            if (bitis <= baslangic)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden sonra olmalıdır.");
                return;
            }

            if ((bitis - baslangic).TotalDays > 3)
            {
                MessageBox.Show("Araç en fazla 3 gün kiralanabilir.");
                return;
            }

            try
            {
                int secilenAracID = Convert.ToInt32(dgvSonuclar.SelectedRows[0].Cells["aracID"].Value);

                using (MySqlConnection baglanti = Veritabani.BaglantiOlustur())
                {
                    baglanti.Open();

                    string kontrolQuery = @"
                        SELECT COUNT(*) FROM kiralamalar 
                        WHERE arac_id = @aracID AND (@baslangic < bitis_tarihi AND @bitis > baslangic_tarihi)";

                    MySqlCommand kontrolCmd = new MySqlCommand(kontrolQuery, baglanti);
                    kontrolCmd.Parameters.AddWithValue("@aracID", secilenAracID);
                    kontrolCmd.Parameters.AddWithValue("@baslangic", baslangic);
                    kontrolCmd.Parameters.AddWithValue("@bitis", bitis);

                    int mevcutKiralama = Convert.ToInt32(kontrolCmd.ExecuteScalar());

                    if (mevcutKiralama > 0)
                    {
                        MessageBox.Show("Seçtiğiniz tarihlerde bu araç zaten kiralanmış.");
                        return;
                    }

                    string insertQuery = @"
                        INSERT INTO kiralamalar (arac_id, kullanici_id, baslangic_tarihi, bitis_tarihi)
                        VALUES (@aracID, @kullaniciID, @baslangic, @bitis)";

                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, baglanti);
                    insertCmd.Parameters.AddWithValue("@aracID", secilenAracID);
                    insertCmd.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                    insertCmd.Parameters.AddWithValue("@baslangic", baslangic);
                    insertCmd.Parameters.AddWithValue("@bitis", bitis);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Araç başarıyla kiralandı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_geridon_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(kullaniciID,uyeTipi);
            form3.Show();
            this.Hide();
        }
    }
}
