using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Uygulaması
{
    internal class Bağlantı_Sınıfı
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-HMITB4AP;Initial Catalog=Banka_Uygulaması;Integrated Security=True;");
            baglan.Open();
            return baglan;
        }
    }
}
