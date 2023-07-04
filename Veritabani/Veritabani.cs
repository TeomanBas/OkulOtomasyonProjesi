using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraEditors;

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
        public void IlIlceList(ComboBoxEdit nesne,string t)
        {
            string tablo;
            if (t == "il")
            {
                tablo = "TBL_IL";
            }
            else
            {
                tablo = "TBL_ILCE";
            }
            DataTable dt = new DataTable();
            string query = "SELECT * FROM " + tablo;
            SqlCommand cmd = new SqlCommand(query,Baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nesne.Properties.Items.Add(dr[1]);
            }
            Baglanti().Close();
            

        }
    }
}
