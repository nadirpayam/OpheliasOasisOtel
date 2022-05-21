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
    public partial class Kaydol : Form
    {
        public Kaydol()
        {
            InitializeComponent();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        private void buttonKaydol_Click(object sender, EventArgs e)
        {
            // burada kullanıcının verilen bilgileri eksik girip girmediği kontrol ediliyor
            if (textBoxAd.Text == "" || textBoxSoyad.Text == "" || textBoxKulAd.Text == "" || textBoxePosta.Text == "" || textBoxSifre.Text == "" || textBoxNo.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
            }
            else
            {
                // eğer tüm bilgileri girmişse bu bilgiler veritabanına kaydediliyor
                string sorgu = "insert into Musteriler(musteriAd,musteriSoyad,musteriKulAd,musteriePosta,musteriSifre,musteriTelefon)values(@ad,@soyad,@kulad,@mail,@sifre,@telefon)";
                SqlCommand komut = new SqlCommand(sorgu, sql.baglan());

                komut.Parameters.AddWithValue("@ad", textBoxAd.Text);
                komut.Parameters.AddWithValue("@soyad", textBoxSoyad.Text);
                komut.Parameters.AddWithValue("@kulad", textBoxKulAd.Text);
                komut.Parameters.AddWithValue("@mail", textBoxePosta.Text);
                komut.Parameters.AddWithValue("@sifre", textBoxSifre.Text);
                komut.Parameters.AddWithValue("@telefon", textBoxNo.Text);
      
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız başarıyla oluşturulmuştur.");
            }
        }

        private void checkBoxGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGoster.CheckState == CheckState.Checked)
            {
                textBoxSifre.UseSystemPasswordChar = true;
                checkBoxGoster.Text = "Gizle";
            }
            else if (checkBoxGoster.CheckState == CheckState.Unchecked)
            {
                textBoxSifre.UseSystemPasswordChar = false;
                checkBoxGoster.Text = "Göster";

            }
        }

        private void textBoxMail_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(textBoxePosta.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.textBoxePosta, "Lutfen calisan mail adresi girin");
                return;
            }
        }

        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
