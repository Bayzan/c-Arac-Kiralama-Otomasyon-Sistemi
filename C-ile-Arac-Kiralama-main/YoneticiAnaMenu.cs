using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_kiralama
{
    public partial class YoneticiAnaMenu : Form
    {
        private int _yoneticiId;
        private string _yoneticiAd;

        public YoneticiAnaMenu(int id, string yoneticiAd)
        {
            InitializeComponent();

            _yoneticiId = id;
            _yoneticiAd = yoneticiAd;

            lbl_isim.Text = $"Hoş geldiniz, {_yoneticiAd}";

            // Timer başlat
            timerSaat.Start();
        }

        private void timerSaat_Tick(object sender, EventArgs e)
        {
            label_saat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }


        private void btn_Kiralamalar_Click(object sender, EventArgs e)
        {
            // Kiralama işlemleri vs.
            MevcutKiralamalar mevcutKiralamalar = new MevcutKiralamalar(_yoneticiId);
            mevcutKiralamalar.Show();
            this.Hide();
        }

        private void YoneticiAnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
