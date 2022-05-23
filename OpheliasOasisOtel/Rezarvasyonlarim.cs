using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpheliasOasisOtel
{
    public partial class Rezarvasyonlarim : Form
    {
        public Rezarvasyonlarim()
        {
            InitializeComponent();
        }

        void RezarvasyonlariGetir()
        {
            string soru =// alt satırda daha önce hiç doğru bilinmemiş  yani sigması 0 olan 10 tane random şeklinde soru geliyor
               " select* from(Select top 10 S.SoruID as 'SoruID' from Sorular S, OgrenciCevap OC where S.SoruID != OC.SoruID order by NEWID()) as b union all " +
           // aşağıda ise sigma sayısına bağlı olarak süresi gelmiş sorular geliyor
           "select * from(Select C.SoruID as 'SoruID' from OgrenciCevap C  where C.KullaniciID ='" + Classlar.KullaniciBilgileri.KullaniciID + "'" +
       " AND C.Sigma = 1 AND DATEDIFF(day, SoruTarihi, getdate()) = (select D.Aralik from SureDegistirme D where D.SigmaSayisi = 1) " + // sigması 1 olan sorunun gelmesi için kullanıcının belirlediği süre tarihi gelmiş mi? geldiyse sigması 1 olan sorularda gelsin sınava
      "  OR(C.Sigma = 2 AND DATEDIFF(day, SoruTarihi, getdate()) = (select D.Aralik from SureDegistirme D where D.SigmaSayisi = 2)) " +
        " OR(C.Sigma = 3 AND DATEDIFF(day, SoruTarihi, getdate()) = (select D.Aralik from SureDegistirme D where D.SigmaSayisi = 3)) " +
    "	OR(C.Sigma = 4 AND DATEDIFF(day, SoruTarihi, getdate()) = (select D.Aralik from SureDegistirme D where D.SigmaSayisi = 4)) " +
   "    OR(C.Sigma = 5 AND DATEDIFF(day, SoruTarihi, getdate()) = (select D.Aralik from SureDegistirme D where D.SigmaSayisi = 5))) as a"; // en son 5 sigmalı soru geliyor çünkü sigması 6 olan soru demek  6 kez üst
                                                                                                                                           // üste doğru cevaplanmış demek yani bir daha sorulmasına gerek yok

            DataTable tbl = new DataTable();
           // SqlDataAdapter adtr = new SqlDataAdapter(sorgulamak, sql.baglan());
        //    adtr.Fill(tbl);
           // dataGridViewSorular.DataSource = tbl;
        }
    }
}
