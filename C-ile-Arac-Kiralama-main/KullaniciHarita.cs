using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_kiralama
{
    public partial class KullaniciHarita : Form
    {
        private Thread listenerThread;
        // aracID, kullaniciID, uyeTipi, baslangicTarihi, bitisTarihi
        private int aracID;
        private int kullaniciID;
        private string uyeTipi;
        private DateTime baslangicTarihi;
        private DateTime bitisTarihi;
        public KullaniciHarita(int aracID, int kullaniciID, string uyeTipi, DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            InitializeComponent();
            InitializeAsync();

            // Listener başlat
            listenerThread = new Thread(StartHttpListener);
            listenerThread.IsBackground = true;
            listenerThread.Start();
            this.aracID = aracID;
            this.kullaniciID = kullaniciID;
            this.uyeTipi = uyeTipi;
            this.baslangicTarihi = baslangicTarihi;
            this.bitisTarihi = bitisTarihi;
        }

        private async void InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.Source = new Uri("http://localhost:8050");
        }

        private void StartHttpListener()
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8085/");
            listener.Start();

            while (true)
            {
                try
                {
                    HttpListenerContext context = listener.GetContext();
                    using (var reader = new System.IO.StreamReader(context.Request.InputStream, context.Request.ContentEncoding))
                    {
                        string message = reader.ReadToEnd();
                        Invoke(new Action(() =>
                        {
                            // Burada form değiştirme işlemi yapılır
                            MessageBox.Show($"Araç Kiralama Talebi Geldi: {message}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Form yeniForm = new KiralamaForm(aracID, kullaniciID, uyeTipi, baslangicTarihi, bitisTarihi);
                            yeniForm.Show();
                            this.Hide();
                        }));
                    }

                    context.Response.StatusCode = 200;
                    context.Response.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dinleyicide hata: " + ex.Message);
                }
            }
        }

        private void btn_geriDon_Click(object sender, EventArgs e)
        {
            AracDetayForm aracDetayForm = new AracDetayForm(aracID, kullaniciID, uyeTipi, baslangicTarihi, bitisTarihi);
            aracDetayForm.Show();
            this.Hide();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
