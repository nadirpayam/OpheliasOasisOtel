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
using System.Data;

namespace OpheliasOasisOtel
{
    public partial class TabanFiyatiDegistir : Form
    {
        public TabanFiyatiDegistir()
        {
            InitializeComponent();
        }
        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        void odayigetir()
        {
            string getir = "select * from Oda";

            DataTable tbl = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter(getir, sql.baglan());
            adtr.Fill(tbl);
            dataGridViewoda.DataSource = tbl;
        }
       

        private void buttonGuncelle_Click_1(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Oda set tabanfiyat=@fiyati WHERE odaID=@id";
            SqlCommand komut = new SqlCommand(sorgu, sql.baglan());
            komut = new SqlCommand(sorgu, sql.baglan());
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridViewoda.CurrentRow.Cells["odaID"].Value));
            komut.Parameters.AddWithValue("@fiyati", textBoxfiyati.Text);

            komut.ExecuteNonQuery();
            MessageBox.Show("Taban fiyati güncellendi.");
            odayigetir();
        }

        private void TabanFiyatiDegistir_Load(object sender, EventArgs e)
        {
            odayigetir();
        }
    }
    
}
