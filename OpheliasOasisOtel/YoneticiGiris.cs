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
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace OpheliasOasisOtel
{
    public partial class YoneticiGiris : Form
    {
        public YoneticiGiris()
        {
            InitializeComponent();
        }

        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            if (textBoxKulAd.Text == "" || textBoxSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş geçilmez.");
            }
            else
            {
                DataSet ds = new DataSet();
                string sql2 = "select * from Yonetici where musteriKulAd = '" + textBoxKulAd.Text + "'and musteriSifre = '" + textBoxSifre.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql2, sql.baglan());
                ds = new DataSet();
                da.Fill(ds, "KULLANICIDENEME");
                //con.Close();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    YoneticiAnasayfa anasayfa = new YoneticiAnasayfa();
                    anasayfa.Show();
                    this.Hide();
                }

                else
                {
                    //burada kullanıcı eğer yanlış bir bir kayıt girdiyse uyarı veriyoruz
                    MessageBox.Show("Kullanıcı  adı veya şifresi yanlış");
                    textBoxKulAd.Clear();
                    textBoxSifre.Clear();

                }
            }
        }
    }
}
