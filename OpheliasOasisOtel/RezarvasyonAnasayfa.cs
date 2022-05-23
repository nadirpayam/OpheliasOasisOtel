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
    public partial class RezarvasyonAnasayfa : Form
    {
        public RezarvasyonAnasayfa()
        {
            InitializeComponent();

        }

        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOnOdeme_Click(object sender, EventArgs e)
        {
            OnOdeme on = new OnOdeme();
            on.Show();



        }

        private void button60gun_Click(object sender, EventArgs e)
        {
            _60gun gun = new _60gun();
            gun.Show();

        }


        private void buttonStandart_Click(object sender, EventArgs e)
        {
            Standart standart = new Standart();
            standart.Show();

        }

        private void buttonTesvik_Click(object sender, EventArgs e)
        {
            Tesvik tes = new Tesvik();
            tes.Show();
        }
        int b;
        private void RezarvasyonAnasayfa_Load(object sender, EventArgs e)
        {
            string taban = "Select top 1 tabanfiyat from Oda";
            SqlCommand com = new SqlCommand(taban, sql.baglan());
            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    b = Convert.ToInt32(rd["tabanfiyat"]);

                }
            }

        }


        private void comboBoxRezler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = comboBoxRezler.SelectedIndex;


            switch (a)
            {
                case 0:
                    labelGunluk.Text = (b * (0.75)).ToString();
                    break;
                case 1:
                    labelGunluk.Text = (b * (0.85)).ToString();
                    break;
                case 2:
                    labelGunluk.Text = (b).ToString();
                    break;
                case 3:
                    labelGunluk.Text = (b).ToString();
                    break;
            }






            if (comboBoxRezler.SelectedIndex == 1)
            {
                labelKredi.Visible = false;
                textBoxKredi.Visible = false;
            }
            else
            {
                labelKredi.Visible = true;
                textBoxKredi.Visible = true;
            }
        }

        double toplamGun;
        double gunler;
        private void buttonOnayla_Click(object sender, EventArgs e)
        {
            DateTime bugun = new DateTime();
            bugun = DateTime.Now;
            DateTime baslamaTarihi = new DateTime();
            baslamaTarihi = dateTimePickerGelis.Value;
            DateTime bitisTarihi = new DateTime();
            bitisTarihi = dateTimePickerAyrilis.Value;

            TimeSpan kalangun = baslamaTarihi - bugun;//Sonucu zaman olarak döndürür
            toplamGun = kalangun.TotalDays;// kalanGun den TotalDays ile sadece toplam gun değerini çekiyoruz. 

            TimeSpan tatilgunleri = bitisTarihi - baslamaTarihi;//Sonucu zaman olarak döndürür
            gunler = tatilgunleri.TotalDays;// kalanGun den TotalDays ile sadece toplam gun değerini çekiyoruz. 

            double d = Math.Ceiling(gunler);
            double c = Math.Ceiling(toplamGun);

            labelFiyat.Text = Math.Ceiling(gunler * Convert.ToInt32(labelGunluk.Text)).ToString();



        }
        string odemeTipi;

        void RezKaydet()
        {

            string sorgu = "insert into Rezarvasyonlar(rezarvasyonTipi,rezarvasyonTarihi,gelistarihi,ayrilistarihi,odemeTutari,musteriID,tabanfiyati)values(@reztip,@reztarih,@gelis,@ayrilis,@odeme,@musteriid,@tabanfiyati) ";

            SqlCommand komut = new SqlCommand(sorgu, sql.baglan());

            komut.Parameters.AddWithValue("@reztip", odemeTipi);
            komut.Parameters.AddWithValue("@reztarih", dateTimePickerRez.Value);
            komut.Parameters.AddWithValue("@gelis", dateTimePickerGelis.Value);
            komut.Parameters.AddWithValue("@ayrilis", dateTimePickerAyrilis.Value);
            komut.Parameters.AddWithValue("@odeme", Convert.ToInt32(labelFiyat.Text));
            komut.Parameters.AddWithValue("@musteriid", Classlar.KullaniciBilgileri.KullaniciID);
            komut.Parameters.AddWithValue("@tabanfiyati", Convert.ToInt32(labelGunluk.Text));

            komut.ExecuteNonQuery();
        }

        void krediKaydet()
        {
            string sorgu2 = "UPDATE Musteriler SET kredikartiNo='" + textBoxKredi.Text + "'" + "  WHERE musteriID='" + Classlar.KullaniciBilgileri.KullaniciID + "'";

            SqlCommand komut2 = new SqlCommand(sorgu2, sql.baglan());
            komut2.ExecuteNonQuery();
        }
        private void buttonRezYap_Click(object sender, EventArgs e)
        {

            int c = comboBoxRezler.SelectedIndex;
            switch (c)
            {
                case 0:
                    if (Math.Ceiling(toplamGun) < 90)
                    {
                        MessageBox.Show("Lütfen rezarvasyonunu en erken 90 gün sonrası için yapın.");
                    }
                    else
                    {
                        odemeTipi = "Ön Ödeme";
                        RezKaydet();
                        krediKaydet();
                        MessageBox.Show("Lütfen rezarvasyonunuz kaydedildi.");
                    }

                    break;
                case 1:
                    if (Math.Ceiling(toplamGun) < 60)
                    {
                        MessageBox.Show("Lütfen rezarvasyonunu en erken 60 gün sonrası için yapın.");
                    }
                    else
                    {
                        odemeTipi = "60 Gün Önceden";
                        RezKaydet();
                        MessageBox.Show("Lütfen rezarvasyonunuz kaydedildi.");

                    }

                    break;
                case 2:
                    odemeTipi = "Standart";
                    RezKaydet();
                    krediKaydet();
                    MessageBox.Show("Lütfen rezarvasyonunuz kaydedildi.");
                    break;
                case 3:
                    odemeTipi = "Teşvik";
                    RezKaydet();
                    krediKaydet();
                    MessageBox.Show("Lütfen rezarvasyonunuz kaydedildi.");
                    break;
            }

        }
    }
}