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
            if (panelOnOdeme.Visible == false)
                _ = panelOnOdeme.Visible == true;
            else if (panel60gun.Visible == true)
                _ = panel60gun.Visible == false;
            else if (panelStandart.Visible == true)
                _ = panelOnOdeme.Visible == false;
            else if (panelTesvik.Visible == true)
                _ = panelOnOdeme.Visible == false;

        }

        private void button60gun_Click(object sender, EventArgs e)
        {
            if (panel60gun.Visible == false)
                _ = panelOnOdeme.Visible == true;
            else if (panelOnOdeme.Visible == true)
                _ = panelOnOdeme.Visible == false;
           else  if (panelStandart.Visible == true)
                _ = panelOnOdeme.Visible == false;
            else if (panelTesvik.Visible == true)
                    _ = panelOnOdeme.Visible == false;

        }

        private void buttonStandart_Click(object sender, EventArgs e)
        {
            if (panelStandart.Visible == false)
                _ = panelStandart.Visible == true;
            else if (panelOnOdeme.Visible == true)
                _ = panelOnOdeme.Visible == false;
            else if (panelStandart.Visible == true)
                _ = panelOnOdeme.Visible == false;
            else if (panel60gun.Visible == true)
                _ = panelOnOdeme.Visible == false;

        }

        private void buttonTesvik_Click(object sender, EventArgs e)
        {
            if (panelTesvik.Visible == false)
                _ = panelTesvik.Visible == true;
            else if (panelOnOdeme.Visible == true)
                _ = panelOnOdeme.Visible == false;
            else if (panelStandart.Visible == true)
                _ = panelOnOdeme.Visible == false;
            else if (panel60gun.Visible == true)
                _ = panelOnOdeme.Visible == false;

        }
    }
}
