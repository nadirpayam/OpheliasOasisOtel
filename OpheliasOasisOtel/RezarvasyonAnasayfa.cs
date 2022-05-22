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
    public partial class RezarvasyonAnasayfa : Form
    {
        public RezarvasyonAnasayfa()
        {
            InitializeComponent();
            
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOnOdeme_Click(object sender, EventArgs e)
        {
            OnOdeme on = new OnOdeme();
            on.Show();
        }

        private void button60gun_Click(object sender, EventArgs e)
        {
            _60gun gun = new _60gun();
            gun.Show();
           
        }
       

        private void buttonStandart_Click(object sender, EventArgs e)
        {
            Standart standart = new Standart();
            standart.Show();

        }

        private void buttonTesvik_Click(object sender, EventArgs e)
        {
            Tesvik tes = new Tesvik();
            tes.Show();
        }

        private void RezarvasyonAnasayfa_Load(object sender, EventArgs e)
        {
            
        }
    }
}
