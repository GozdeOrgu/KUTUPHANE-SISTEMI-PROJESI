using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Kutuphane
{
    public class SQLBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-HCB46VG\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}