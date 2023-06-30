using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Veritabani
{
    public class Veritabani
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-6NBRLG6;Initial Catalog=OkulOtomasyon;User ID=OkulAppUser;Password=OkulAppUser123");
            baglan.Open();
            return baglan;
        }
        public DataTable OgretmenBilgiGetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_OGRETMENLER", Baglanti());
            da.Fill(dt);
            return dt;
        }
    }
}
