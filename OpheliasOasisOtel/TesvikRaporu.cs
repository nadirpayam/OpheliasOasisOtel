using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace OpheliasOasisOtel
{
    public partial class TesvikRaporu : Form
    {
        PrintDocument pd = new PrintDocument();
        public TesvikRaporu()
        {
            InitializeComponent();
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
        }
        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        void fiyatigetir()
        {
            string getir = "select SUM(R.tabanfiyati) * 0.8 as 'İndirimli Kazanç', SUM(R.tabanfiyati) as 'Gerçek Kazanç', " +
" (SUM(R.tabanfiyati) - SUM(R.tabanfiyati) * 0.8) as 'Kaybedilen Para' " +
" from Rezarvasyonlar R inner join Oda O on O.odaID = R.odaID  where O.doluMu = 'Evet' and " +
" DATEDIFF(day, getdate(), R.gelistarihi) < 30";

            DataTable tbl = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter(getir, sql.baglan());
            adtr.Fill(tbl);
            dataGridViewKar.DataSource = tbl;
        }
        private void TesvikRaporu_Load(object sender, EventArgs e)
        {
            fiyatigetir();
            label1.Text = dateTimePicker1.Value.ToString();
        }
        void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                decimal widthRatio = bitmap.Width / e.PageBounds.Width;
                decimal heightRatio = bitmap.Height / e.PageBounds.Height;
                decimal ratio = 1;
                if (widthRatio > 1 || heightRatio > 1)
                {
                    if (widthRatio > heightRatio)
                    {
                        ratio = widthRatio;
                    }
                    else if (heightRatio > widthRatio)
                    {
                        ratio = heightRatio;
                    }
                    else
                    {
                        ratio = heightRatio;
                    }
                }
                float width = (float)(bitmap.Width / ratio);
                float heigth = (float)(bitmap.Height / ratio);
                e.Graphics.DrawImage(bitmap, 0, 0, width, heigth);
            }
        }

        private void buttonYazdir_Click(object sender, EventArgs e)
        {
            pd.Print();
        }
    }
}
