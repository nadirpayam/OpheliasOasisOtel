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
    public partial class CalisanAnasayfa : Form
    {
        public CalisanAnasayfa()
        {
            InitializeComponent();
        }
        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            GunlukGelenlerRaporu gelen = new GunlukGelenlerRaporu();
            gelen.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BeklenenDolulukRaporu dolu = new BeklenenDolulukRaporu();
            dolu.Show();
            this.Hide();
        }
        Classlar.MailGonder mailat = new Classlar.MailGonder();
        private void button3_Click(object sender, EventArgs e)
        {
            int b;
            string sorgu = "select musteriID from Rezarvasyonlar where odenmeDurumu = 'Odenmedi' and rezarvasyonTipi ='60 Gün Önceden' "+
                "DATEDIFF(day,GETDATE(),gelistarihi) <45 ";
            SqlCommand comut = new SqlCommand(sorgu, sql.baglan());
             SqlDataReader rd = comut.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    b = Convert.ToInt32(rd["musteriID"]);

                }
            }
            mailat.MailAt();
        }
    }
}
