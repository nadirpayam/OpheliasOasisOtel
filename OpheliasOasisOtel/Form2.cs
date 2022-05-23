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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string a;
        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime baslamaTarihi = new DateTime();
            //baslamaTarihi = dateTimePickerGelis.Value;
            //DateTime bitisTarihi = new DateTime();
            //bitisTarihi = dateTimePickerAyrilis.Value;

            //TimeSpan kalangun = bitisTarihi - baslamaTarihi;//Sonucu zaman olarak döndürür
            //double toplamGun = kalangun.TotalDays;// kalanGun den TotalDays ile sadece toplam gun değerini çekiyoruz. 


            //label1.Text = Math.Ceiling(toplamGun).ToString();

            //if(Convert.ToInt32(label1.Text) < 60)
            //{
            //    MessageBox.Show("Ne oluyor lan");
            //} 


            string sorgu = "select  gelistarihi from Rezarvasyonlar  where musteriID = 2";

              
            SqlCommand com = new SqlCommand(sorgu, sql.baglan());
            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    label1.Text= (rd["gelistarihi"]).ToString();

                } // dateTimePickerGelis.Value.ToShortDateString()
            }

            
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
                string a = "23-05-2022";
 
                MessageBox.Show(DateTime.Now.ToShortDateString() + " " + Convert.ToDateTime(a).ToShortDateString());
            
           
        }
    }
}
