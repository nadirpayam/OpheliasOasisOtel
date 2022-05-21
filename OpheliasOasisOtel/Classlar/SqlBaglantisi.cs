using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace OpheliasOasisOtel.Classlar
{
    public class SqlBaglantisi
    {
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-LNMPQIK9;Initial Catalog=OpheliasOasisOtel;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
