using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
// OpenFileDialog sınıfına erişim için System.IO sınıfı referans olarak eklendi.
using System.IO;

namespace ViewMetodlari
{
    public class ViewMetod
    {
        public void GridViewSatir(DevExpress.XtraGrid.Views.Grid.GridView grid,TextEdit id,TextEdit ad, TextEdit soyad, MaskedTextBox tc,MaskedTextBox tel,TextEdit mail,ComboBoxEdit il,ComboBoxEdit ilce,RichTextBox adres,ComboBoxEdit brans)
        {
            DataRow dr = grid.GetDataRow(grid.FocusedRowHandle);
            id.Text = dr["OGRTID"].ToString();
            ad.Text = dr["OGRTAD"].ToString();
            soyad.Text = dr["OGRTSOYAD"].ToString();
            tc.Text = dr["OGRTTC"].ToString();
            tel.Text = dr["OGRTTEL"].ToString();
            mail.Text = dr["OGRTMAIL"].ToString();
            il.Text = dr["OGRTIL"].ToString();
            ilce.Text = dr["OGRTILCE"].ToString();
            adres.Text = dr["OGRTADRES"].ToString();
            brans.Text = dr["OGRTBRANS"].ToString();
        }
        public void ResimSec(PictureBox resimkutusu)
        {
            // filedialog nesnesi oluşturuldu
            OpenFileDialog dosya = new OpenFileDialog();
            // dialog penceresindeki dosya seçim filtreleri tanımlandı
            dosya.Filter = "Resim Dosyası | *.jpg;*.png | Tüm Dosyalar | *.*";
            // diaglog penceresi açıldı
            dosya.ShowDialog();
            // seçilen dosyanın dizin adresi alındı
            string dosyadizin= dosya.FileName;
            // kopyalacak yeni dizin tanımlaması yapıldı.Dizin referansları exe dosyalarından yapılıyor form anamodul altında olduğu için "Anamodul\bin\debug\anamodul.exe" referans alınıyor
            string kaydetdizin = "..\\..\\..\\OgretmenlerModul\\Resimler\\" + Guid.NewGuid().ToString() + ".jpg";
            // dosya yeni dizine kopyalandı
            File.Copy(dosyadizin, kaydetdizin);
            // picturebox'ın location değeri yeni resim dizini ile değiştirildi 
            resimkutusu.ImageLocation = kaydetdizin;
        }
    }
}
