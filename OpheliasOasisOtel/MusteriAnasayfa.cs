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
    public partial class MusteriAnasayfa : Form
    {
        public MusteriAnasayfa()
        {
            InitializeComponent();
        }

        private void buttonRezYap_Click(object sender, EventArgs e)
        {
            RezarvasyonAnasayfa rez = new RezarvasyonAnasayfa();
            rez.Show();
            this.Hide();
        }

        private void buttonRezlerim_Click(object sender, EventArgs e)
        {
            Rezarvasyonlarim rezlerim = new Rezarvasyonlarim();
            rezlerim.Show();
            this.Hide();
        }
    }
}
