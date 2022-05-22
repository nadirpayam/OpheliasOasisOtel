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
    public partial class OnOdeme : Form
    {
        public OnOdeme()
        {
            InitializeComponent();
        }

        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        private void OnOdeme_Load(object sender, EventArgs e)
        {
             string sorgu = "Select top 1 tabanfiyat from Oda";
            SqlCommand com = new SqlCommand(sorgu, sql.baglan());
            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    labelGunluk.Text = rd["tabanfiyat"].ToString();
                    
                }
            }
        }

        
        private void labelFiyat_Click(object sender, EventArgs e)
        {
            

   
        }

        public int GunFarkikBul(DateTime dt1, DateTime dt2)

        {

            TimeSpan zaman = new TimeSpan(); // zaman farkını bulmak adına kullanılacak olan nesne

            zaman = dt1 - dt2;//metoda gelen 2 tarih arasındaki fark

            return Math.Abs(zaman.Days); // 2 tarih arasındaki farkın kaç gün olduğu döndürülüyor.

        }
       // int a;
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = new DateTime(dateTimePickerGelis.Value.Day);
            DateTime dt2 = new DateTime(dateTimePickerAyrilis.Value.Day);
            dt1 = dateTimePickerGelis.Value;
            dt2 = dateTimePickerAyrilis.Value.AddDays(1);
            TimeSpan dt3 = dt2 - dt1;
            labelFiyat.Text = (Convert.ToInt32(dt3.Days) * 100).ToString();


        }
       
        private void buttonRezYap_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Rezarvasyonlar(rezarvasyonTipi,rezarvasyonTarihi,gelistarihi,ayrilistarihi,odemeTutari,musteriID)values(@reztip,@reztarih,@gelis,@ayrilis,@odeme,@musteriid)";
            textBox1.Text = (Classlar.KullaniciBilgileri.KullaniciID).ToString();
            string sorgu2 = "insert into  Musteriler(krediKartiNo)values(@kredi)";
            SqlCommand komut2 = new SqlCommand(sorgu2, sql.baglan());
            komut2.Parameters.AddWithValue("@kredi", textBoxKredi.Text);
          SqlCommand komut = new SqlCommand(sorgu, sql.baglan());
         komut.Parameters.AddWithValue("@reztip", "Ön Ödeme");
            komut.Parameters.AddWithValue("@reztarih", dateTimePickerRez.Value);
            komut.Parameters.AddWithValue("@gelis", dateTimePickerGelis.Value);
            komut.Parameters.AddWithValue("@ayrilis", dateTimePickerAyrilis.Value);
            komut.Parameters.AddWithValue("@odeme", Convert.ToInt32(labelFiyat.Text));
            komut.Parameters.AddWithValue("@musteriid", Classlar.KullaniciBilgileri.KullaniciID);
          
            komut.ExecuteNonQuery();
            MessageBox.Show("Cevabınız başarılı bir şekilde sisteme kaydedildi.");
        }
    }
}
