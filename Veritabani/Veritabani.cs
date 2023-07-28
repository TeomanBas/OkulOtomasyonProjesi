using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraPrinting;

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
        public DataTable TabloBilgiGetir(string tablo)
        {
            if(tablo == "ogretmen")
            {
                tablo = "TBL_OGRETMENLER";
            }
            string query="SELECT * FROM "+tablo;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, Baglanti());
            da.Fill(dt);
            Baglanti().Close();
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
        public void SecimIlceListe(ComboBoxEdit nesne,ComboBoxEdit secimil)
        {
            nesne.Properties.Items.Clear();
            int secim;
            secim = secimil.SelectedIndex +1;
            string query = "SELECT * FROM TBL_ILCE WHERE sehir="+Convert.ToString(secim);
            SqlCommand cmd = new SqlCommand(query, Baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nesne.Properties.Items.Add(dr[1]);
            }
            Baglanti().Close();
        }
        public void KayitEkle(TextEdit ad, TextEdit soyad,MaskedTextBox tc,
            MaskedTextBox tel,TextEdit mail,ComboBoxEdit il,
            ComboBoxEdit ilce,RichTextBox adres,ComboBoxEdit brans,string hedefresimkaynak)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_OGRETMENLER" +
                " (OGRTAD,OGRTSOYAD,OGRTTC,OGRTTEL,OGRTMAIL,OGRTIL,OGRTILCE,OGRTADRES,OGRTBRANS,OGRTFOTO)" +
                " VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)",Baglanti());
            cmd.Parameters.AddWithValue("@p1", ad.Text);
            cmd.Parameters.AddWithValue("@p2", soyad.Text);
            cmd.Parameters.AddWithValue("@p3", tc.Text);
            cmd.Parameters.AddWithValue("@p4", tel.Text);
            cmd.Parameters.AddWithValue("@p5", mail.Text);
            cmd.Parameters.AddWithValue("@p6", il.Text);
            cmd.Parameters.AddWithValue("@p7", ilce.Text);
            cmd.Parameters.AddWithValue("@p8", adres.Text);
            cmd.Parameters.AddWithValue("@p9", brans.Text);
            cmd.Parameters.AddWithValue("@p10", hedefresimkaynak);
            cmd.ExecuteNonQuery();
            Baglanti().Close();
            MessageBox.Show("Personel Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void KayitEkle(TextEdit ad, TextEdit soyad, MaskedTextBox tc,
            MaskedTextBox ogrno, ComboBoxEdit sinif, DateEdit dogum,string cinsiyet, ComboBoxEdit il,
            ComboBoxEdit ilce, RichTextBox adres, string hedefresimkaynak)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_OGRENCILER" +
                " (OGRNO,OGRAD,OGRSOYAD,OGRTC,OGRDOGUM,OGRCINSIYET,OGRIL,OGRILCE,OGRADRES,OGRSINIF,OGRFOTO)" +
                " VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", Baglanti());
            cmd.Parameters.AddWithValue("@p1", ogrno.Text);
            cmd.Parameters.AddWithValue("@p2", ad.Text);
            cmd.Parameters.AddWithValue("@p3", soyad.Text);
            cmd.Parameters.AddWithValue("@p4", tc.Text);
            cmd.Parameters.AddWithValue("@p5", dogum.Text);
            cmd.Parameters.AddWithValue("@p6", cinsiyet);
            cmd.Parameters.AddWithValue("@p7", il.Text);
            cmd.Parameters.AddWithValue("@p8", ilce.Text);
            cmd.Parameters.AddWithValue("@p9", adres.Text);
            cmd.Parameters.AddWithValue("@p10", sinif.Text);
            cmd.Parameters.AddWithValue("@p11", hedefresimkaynak);
            cmd.ExecuteNonQuery();
            Baglanti().Close();
            MessageBox.Show("Öğrenci Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void KayitGuncelle(TextEdit id,TextEdit ad, TextEdit soyad, MaskedTextBox tc,
            MaskedTextBox ogrno, ComboBoxEdit sinif, DateEdit dogum, string cinsiyet, ComboBoxEdit il,
            ComboBoxEdit ilce, RichTextBox adres, string hedefresimkaynak)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TBL_OGRENCILER SET" +
                " OGRNO=@p1,OGRAD=@p2,OGRSOYAD=@p3,OGRTC=@p4,OGRDOGUM=@p5,OGRCINSIYET=@p6,OGRIL=@p7,OGRILCE=@p8,OGRADRES=@p9,OGRSINIF=@p10,OGRFOTO=@p11 WHERE OGRID=@p12", Baglanti());
            cmd.Parameters.AddWithValue("@p1", ogrno.Text);
            cmd.Parameters.AddWithValue("@p2", ad.Text);
            cmd.Parameters.AddWithValue("@p3", soyad.Text);
            cmd.Parameters.AddWithValue("@p4", tc.Text);
            cmd.Parameters.AddWithValue("@p5", dogum.Text);
            cmd.Parameters.AddWithValue("@p6", cinsiyet);
            cmd.Parameters.AddWithValue("@p7", il.Text);
            cmd.Parameters.AddWithValue("@p8", ilce.Text);
            cmd.Parameters.AddWithValue("@p9", adres.Text);
            cmd.Parameters.AddWithValue("@p10", sinif.Text);
            cmd.Parameters.AddWithValue("@p11", hedefresimkaynak);
            cmd.Parameters.AddWithValue("@p12", id.Text);

            cmd.ExecuteNonQuery();
            Baglanti().Close();
            MessageBox.Show("Öğrenci Bilgileri Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void BransListele(ComboBoxEdit branslar)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_BRANSLAR", Baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                branslar.Properties.Items.Add(dr[1]);
            }
            Baglanti().Close();
        }
        public void KayitGuncelle(TextEdit ad, TextEdit soyad, MaskedTextBox tc,
           MaskedTextBox tel, TextEdit mail, ComboBoxEdit il, ComboBoxEdit ilce, RichTextBox adres, 
           ComboBoxEdit brans, string resimkutusu, TextEdit id)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TBL_OGRETMENLER SET" +
                " OGRTAD=@p1,OGRTSOYAD=@p2,OGRTTC=@p3,OGRTTEL=@p4,OGRTMAIL=@p5,OGRTIL=@p6,OGRTILCE=@p7,OGRTADRES=@p8,OGRTBRANS=@p9,OGRTFOTO=@p10 " +
                "WHERE OGRTID=@p11", Baglanti());
            cmd.Parameters.AddWithValue("@p1", ad.Text);
            cmd.Parameters.AddWithValue("@p2", soyad.Text);
            cmd.Parameters.AddWithValue("@p3", tc.Text);
            cmd.Parameters.AddWithValue("@p4", tel.Text);
            cmd.Parameters.AddWithValue("@p5", mail.Text);
            cmd.Parameters.AddWithValue("@p6", il.Text);
            cmd.Parameters.AddWithValue("@p7", ilce.Text);
            cmd.Parameters.AddWithValue("@p8", adres.Text);
            cmd.Parameters.AddWithValue("@p9", brans.Text);
            cmd.Parameters.AddWithValue("@p10", resimkutusu);
            cmd.Parameters.AddWithValue("@p11", id.Text);

            cmd.ExecuteNonQuery();
            Baglanti().Close();
            MessageBox.Show("Personel Bilgileri Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void OgretmenKayitSil(TextEdit id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM TBL_OGRETMENLER WHERE OGRTID=@p1",Baglanti());
            cmd.Parameters.AddWithValue("@p1",id.Text);
            cmd.ExecuteNonQuery();
            Baglanti() .Close();
            MessageBox.Show("Personel Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public DataTable TabloBilgiGetir(string tablo,string sinif)
        {
            if (tablo == "ogrenci")
            {
                tablo = "TBL_OGRENCILER";
            }
            DataTable dt = new DataTable();
            string query="SELECT * FROM "+tablo+" WHERE OGRSINIF='"+sinif+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, Baglanti());
            Baglanti().Close();
            da.Fill(dt);
            return dt;
            
        }
    }
}
