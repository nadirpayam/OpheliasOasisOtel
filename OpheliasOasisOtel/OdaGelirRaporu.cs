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
    public partial class OdaGelirRaporu : Form
    {
        PrintDocument pd = new PrintDocument();
        public OdaGelirRaporu()
        {
            InitializeComponent();
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
        }
        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();

        int c;
        void gelir()
        {

            string dolu = "Select SUM(odemeTutari) as 'Toplam Gelir' from Rezarvasyonlar where  DATEDIFF(day, getdate(), gelistarihi) <= 30";
            SqlCommand com = new SqlCommand(dolu, sql.baglan());
            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    textBoxgelir.Text = (rd["Toplam Gelir"]).ToString();
                    
                }
            }
        }

        private void OdaGelirRaporu_Load(object sender, EventArgs e)
        {
            gelir();
            textBoxortgelir.Text = (Convert.ToDouble(textBoxgelir.Text) / 30).ToString();
        
        }

        private void textBoxortgelir_TextChanged(object sender, EventArgs e)
        {

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
