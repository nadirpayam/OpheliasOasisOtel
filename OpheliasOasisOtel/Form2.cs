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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = new DateTime(dateTimePicker1.Value.Day);
            DateTime dt2 = new DateTime(dateTimePicker2.Value.Day);
            dt1 = dateTimePicker1.Value;
            dt2 = dateTimePicker2.Value.AddDays(1);
            TimeSpan dt3 = dt2 - dt1;
            label4.Text = (Convert.ToInt32(dt3.Days) * Convert.ToInt32(label3.Text)).ToString();
        }
    }
}
