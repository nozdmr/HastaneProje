using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace HastaneProje
{
    internal class SqlBaglantisi
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=NIYAZI\\SQL;Initial Catalog=HastaneProje;Integrated Security=True;");
            baglan.Open();
            return baglan;
        }
    }
}
