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


namespace OpheliasOasisOtel
{
    public partial class BeklenenDolulukRaporu : Form
    {

        public BeklenenDolulukRaporu()
        {
            InitializeComponent();
        }
        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
             
        void kayitlarigetir()
        {
            string getir = "select R.rezarvasyonID, R.musteriID, R.odaID, R.rezarvasyonTipi, R.gelistarihi, O.doluMu" +
 " from Rezarvasyonlar R inner join Oda O on O.odaID = R.odaID where O.odaID = R.odaID and DATEDIFF(day, getdate(), R.gelistarihi) <= 30";
            DataTable tbl = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter(getir, sql.baglan());
            adtr.Fill(tbl);
            dataGridViewdoluluk.DataSource = tbl;
        }

        int y;
        void dolulukorani()
        {

            string dolu = "select (count(odaId)/0.3) as 'Dolu Odalar' from Oda where doluMu= 'Evet'";
            SqlCommand com = new SqlCommand(dolu, sql.baglan());
            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    textBoxoran.Text= (rd["Dolu Odalar"]).ToString();

                }
            }
        }
        private void BeklenenDolulukRaporu_Load(object sender, EventArgs e)
        {
            kayitlarigetir();
            textBoxKayit.Text = (dataGridViewdoluluk.RowCount - 1).ToString();
            dolulukorani();
        }
    }
}
