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
    public partial class Rezarvasyonlarim : Form
    {
        public Rezarvasyonlarim()
        {
            InitializeComponent();
        }
        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        void RezarvasyonlariGetir()
        {
                                                            
          string getir = "Select * from Rezarvasyonlar where musteriID= '" + Classlar.KullaniciBilgileri.KullaniciID + "'";
             DataTable tbl = new DataTable();
                    SqlDataAdapter adtr = new SqlDataAdapter(getir, sql.baglan());
                    adtr.Fill(tbl);
                     dataGridViewRezler.DataSource = tbl;
                      
        }

        private void Rezarvasyonlarim_Load(object sender, EventArgs e)
        {
              string odavermek = "update Rezarvasyonlar set odaID = (Select top 1 odaID from Oda where doluMu = 'Hayır') " +
            " where gelistarihi= '" + dataGridViewRezler.CurrentRow.Cells["gelistarihi"].Value + "'" + " and musteriID = '" + Classlar.KullaniciBilgileri.KullaniciID + "'";

       

            SqlCommand komut = new SqlCommand(odavermek, sql.baglan());
       
            string odadoldu = "	UPDATE Oda set doluMu='Evet' FROM Oda O INNER JOIN Rezarvasyonlar R ON O.odaID = R.odaID WHERE O.odaID = R.odaID";
            SqlCommand komut2 = new SqlCommand(odadoldu, sql.baglan());
            komut.ExecuteNonQuery();
            komut2.ExecuteNonQuery();

            MessageBox.Show("okey");
            RezarvasyonlariGetir();
        }

        void RezarvasyonuSil()
        {

            string sorgu = "delete from Rezarvasyonlar where rezarvasyonID =@id";
            SqlCommand komut = new SqlCommand(sorgu, sql.baglan());
            komut.Parameters.AddWithValue("@id", dataGridViewRezler.CurrentRow.Cells["rezarvasyonID"].Value);
            komut.ExecuteNonQuery();

            MessageBox.Show("Rezarvasyon silindi.");
            RezarvasyonlariGetir();
        }
        private void buttoniptalet_Click(object sender, EventArgs e)
        {

            string odemetipi = dataGridViewRezler.CurrentRow.Cells["rezarvasyonTipi"].Value.ToString();

            switch(odemetipi)
            {
                case "Ön Ödeme":
                    RezarvasyonuSil();
                    break;

                case "60 Gün Önceden":
                     RezarvasyonuSil();
                    break;

                case "Standart":
                    if (dateTimePickertoday.Value.ToString() == dataGridViewRezler.CurrentRow.Cells["gelistarihi"].Value)
                    {
                        MessageBox.Show("Kartınızdan ceza fiyatı çekildi çünkü 3 gün kala rezarvasyonunuzu iptal ettiniz.");
                    }
                    RezarvasyonuSil();
                    break;

                case "Teşvik":
                    if (dateTimePickertoday.Value.ToString() == dataGridViewRezler.CurrentRow.Cells["gelistarihi"].Value)
                    {
                        MessageBox.Show("Kartınızdan ceza fiyatı çekildi çünkü 3 gün kala rezarvasyonunuzu iptal ettiniz.");
                    }
                    RezarvasyonuSil();
                    break;

            }

           
            
        }


        void RezarvasyonGuncelle()
        {
            string guncedlle = "update Rezarvasyonlar set gelistarihi = '" + dataGridViewRezler.CurrentRow.Cells["gelistarihi"].Value + "'" +
                "where rezarvasyonID = 84 and gelistarihi = '" + dataGridViewRezler.CurrentRow.Cells["gelistarihi"] + "'";



            string guncelle = "UPDATE Rezarvasyonlar set gelistarihi=@gelis WHERE rezarvasyonID=@id"; // sql sorgusuyla OnayDurumu'nu değiştiriyoruz
            SqlCommand komut = new SqlCommand(guncelle, sql.baglan());
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridViewRezler.CurrentRow.Cells[0].Value));
            komut.Parameters.AddWithValue("@gelis", dateTimePickerdegisik.Value.ToShortDateString());

            komut.ExecuteNonQuery();
        }
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {

            string odemetipi = dataGridViewRezler.CurrentRow.Cells["rezarvasyonTipi"].Value.ToString();

            switch (odemetipi)
            {
                case "Ön Ödeme":
                    int z = Convert.ToInt32(dataGridViewRezler.CurrentRow.Cells["tabanfiyati"].Value);
                    double ekucret = z * 1.10;
                    MessageBox.Show(ekucret + " tutarını ödedikten sonra gün değişikliğiniz yapılacaktır.");
                    RezarvasyonGuncelle();
                    RezarvasyonlariGetir();
                    break;

                case "60 Gün Önceden":
                    int n = Convert.ToInt32(dataGridViewRezler.CurrentRow.Cells["tabanfiyati"].Value);
                    double u = n * 1.10;
                    MessageBox.Show(u + " tutarını ödedikten sonra gün değişikliğiniz yapılacaktır.");
                    RezarvasyonGuncelle();
                    RezarvasyonlariGetir();
                    break;

                case "Standart":
                    RezarvasyonGuncelle();
                    RezarvasyonlariGetir();
                    break;

                case "Teşvik":
                    RezarvasyonGuncelle();
                    RezarvasyonlariGetir();
                    break;

            }

        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
