using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpheliasOasisOtel
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void buttonUyeOl_Click(object sender, EventArgs e)
        {
            Kaydol kaydol = new Kaydol();
            kaydol.Show();
            this.Hide();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMusteriGiris_Click(object sender, EventArgs e)
        {
            MusteriGiris musteri = new MusteriGiris();
            musteri.Show();
            this.Hide();
        }

        private void buttonCalisan_Click(object sender, EventArgs e)
        {
            CalisanAnasayfa anasayfa = new CalisanAnasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void buttonYonetici_Click(object sender, EventArgs e)
        {
            YoneticiAnasayfa anasayfa = new YoneticiAnasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
