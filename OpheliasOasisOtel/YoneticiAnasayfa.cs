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
    public partial class YoneticiAnasayfa : Form
    {
        public YoneticiAnasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TesvikRaporu tesvik = new TesvikRaporu();
            tesvik.Show();
            this.Hide();

        }

        private void buttonyedekle_Click(object sender, EventArgs e)
        {
            Yedekleme yedek = new Yedekleme();
            yedek.Show();
            this.Hide();
        }
    }
}
