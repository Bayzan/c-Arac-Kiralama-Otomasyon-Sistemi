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
    public partial class UyeOlEkranıcs : Form
    {
        public UyeOlEkranıcs()
        {
            InitializeComponent();
        }

        private void btn_geriDon_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); // Mevcut formu gizle
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btn_ticariuyelik_Click(object sender, EventArgs e)
        {
            TicariUyeOl ticariUyeOl = new TicariUyeOl();
            ticariUyeOl.Show();
            this.Hide(); // Mevcut formu gizle
        }

        private void btn_BireyselUyelik_Click(object sender, EventArgs e)
        {
            BireyselUyeOl bireyselUyeOl = new BireyselUyeOl();
            bireyselUyeOl.Show();
            this.Hide(); // Mevcut formu gizle
        }
    }
}
