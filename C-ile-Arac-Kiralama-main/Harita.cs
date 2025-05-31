using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Arac_kiralama
{
    public partial class Harita : Form
    {
        private Thread listenerThread;
        private int _yoneticiId;
        private string _yoneticiAd;

        public Harita(int yoneticiId, string yoneticiAd)
        {
            InitializeComponent();
            InitializeAsync();

            // Listener başlat
            listenerThread = new Thread(StartHttpListener);
            listenerThread.IsBackground = true;
            listenerThread.Start();
            _yoneticiId = yoneticiId;
            _yoneticiAd = yoneticiAd;

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

                            //Form yeniForm = new KiralamaForm(message); // KiralamaForm senin oluşturacağın yeni form
                            //yeniForm.Show();
                            //this.Hide();
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
            YoneticiAnaMenu yoneticiAnaMenu = new YoneticiAnaMenu(_yoneticiId, _yoneticiAd); // 0 ve "Yönetici" değerlerini uygun şekilde değiştir 
            yoneticiAnaMenu.Show();
            this.Hide();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}