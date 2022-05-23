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
    public partial class GunlukGelenlerRaporu : Form
    {
        PrintDocument pd = new PrintDocument();
        public GunlukGelenlerRaporu()
        {
            InitializeComponent();
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
        }

        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        void kayitlarigetir()
        {
            string getir = "select M.musteriAd, R.rezarvasyonTipi, R.odaID,R.ayrilistarihi from Rezarvasyonlar R inner  join Musteriler M on M.musteriID = R.musteriID where R.gelistarihi = '2022-05-23'" +
" order by M.musteriAd asc ";
            DataTable tbl = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter(getir, sql.baglan());
            adtr.Fill(tbl);
            dataGridViewdoluluk.DataSource = tbl;
        }
        private void GunlukGelenlerRaporu_Load(object sender, EventArgs e)
        {
            kayitlarigetir();
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
