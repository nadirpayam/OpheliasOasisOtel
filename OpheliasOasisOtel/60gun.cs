using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace OpheliasOasisOtel
{
    public partial class _60gun : Form
    {
        public _60gun()
        {
            InitializeComponent();
        }

    
        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        private void buttonOnayla_Click(object sender, EventArgs e)
        {
           
            string fark = " select DATEDIFF(day,'" + dateTimePickerGelis.Value + "'" + " , '" + dateTimePickerGelis.Value + "') as 'Naber'";
            SqlCommand comm = new SqlCommand(fark, sql.baglan());
            SqlDataReader rd = comm.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    label2.Text = rd["Tarih"].ToString();
                    
                }
            }
           // labelFiyat.Text = (Convert.ToInt32(label2.Text) * 100).ToString();
        }
        
        private void buttonRezYap_Click(object sender, EventArgs e)
        {
            DateTime dt1 = new DateTime(dateTimePickerGelis.Value.Day);
            DateTime dt4 = new DateTime(dateTimePickerRez.Value.Day);
            TimeSpan dt5 = dt4 - dt1;




            string tarih = " select DATEDIFF(day, getdate(),'" + dateTimePickerGelis.Value + "'" + ") as 'Naber'";
            
            SqlCommand com = new SqlCommand(tarih, sql.baglan());
            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                  label1.Text  = rd["Naber"].ToString();

                }
            }




            if (Convert.ToInt32(label1.Text) > 60)
            {

                string sorgu = "insert into Rezarvasyonlar(rezarvasyonTipi,rezarvasyonTarihi,gelistarihi,ayrilistarihi,odemeTutari,musteriID)values(@reztip,@reztarih,@gelis,@ayrilis,@odeme,@musteriid) ";

                SqlCommand komut = new SqlCommand(sorgu, sql.baglan());

                komut.Parameters.AddWithValue("@reztip", "Ön Ödeme");
                komut.Parameters.AddWithValue("@reztarih", dateTimePickerRez.Value);
                komut.Parameters.AddWithValue("@gelis", dateTimePickerGelis.Value);
                komut.Parameters.AddWithValue("@ayrilis", dateTimePickerAyrilis.Value);
                komut.Parameters.AddWithValue("@odeme", Convert.ToInt32(labelFiyat.Text));
                komut.Parameters.AddWithValue("@musteriid", Classlar.KullaniciBilgileri.KullaniciID);

                MessageBox.Show("Rezarvasyonunuz başarılı bir şekilde sisteme kaydedildi.");

                komut.ExecuteNonQuery();
            }
            MessageBox.Show("Lütfen 60 gün sonrası için rezarvasyon yapınız.");
        }
    }
}
