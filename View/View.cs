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
using DevExpress.XtraGrid;
using Veritabani;
using System.Runtime.CompilerServices;

namespace ViewMetodlari
{
    public class ViewMetod
    {
        private static Veritabani.Veritabani db()
        {
            Veritabani.Veritabani database = new Veritabani.Veritabani();
            return database;
        }
        public static void GridViewSatir(DevExpress.XtraGrid.Views.Grid.GridView grid,TextEdit id,
            TextEdit ad, TextEdit soyad, MaskedTextBox tc,MaskedTextBox tel,TextEdit mail,
            ComboBoxEdit il,ComboBoxEdit ilce,RichTextBox adres,ComboBoxEdit brans, PictureBox resimkutusu)
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
            resimkutusu.ImageLocation = dr["OGRTFOTO"].ToString();

        }

        public static void ResimSec(PictureBox resimkutusu)
        {
            // filedialog nesnesi oluşturuldu
            OpenFileDialog dosya = new OpenFileDialog();
            // dialog penceresindeki dosya seçim filtreleri tanımlandı
            dosya.Filter = "Resim Dosyası | *.jpg;*.png | Tüm Dosyalar | *.*";
            // diaglog penceresi açıldı
            dosya.ShowDialog();
            // seçilen dosyanın dizin adresi alındı
            string dosyadizin = dosya.FileName;
            // dosyanın seçilmemesi durumu kontrol ediliyor.
            if (dosyadizin != "")
            {
            //seçilen dosyanın boyutu kontrol ediliyor.
            FileInfo dosyabilgi = new FileInfo(dosyadizin); 
            long dosyaboyutu = dosyabilgi.Length; // byte 
                if (dosyaboyutu <= 5 * 1024 * 1024)
                {
                    // burada kayit dizini release çıkıldığında değiştirilmesi gerekli bu dizin debug için geçerlidir.!!!
                    string kayitdizini = @"..\..\..\OgretmenlerModul\Resimler";
                    // dizin kontrolü
                    if (!File.Exists(kayitdizini))
                    {
                        Directory.CreateDirectory(kayitdizini);
                    }
                    // kopyalacak yeni dizin tanımlaması yapıldı.Dizin referansları exe dosyalarından yapılıyor
                    // form anamodul altında olduğu için "Anamodul\bin\debug\anamodul.exe" referans alınıyor
                    string kaydetdizin = kayitdizini + @"\" + Guid.NewGuid().ToString() + ".jpg";
                    // dosya yeni dizine kopyalandı
                    File.Copy(dosyadizin, kaydetdizin);
                    // picturebox'ın location değeri yeni resim dizini ile değiştirildi 
                    resimkutusu.ImageLocation = kaydetdizin;
                }
                else
                {
                    dosyadizin = "";
                    MessageBox.Show("Dosya Boyutu 5 MB'den büyük olamaz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            


           
            
        }

        public static void Temizle(TextEdit TxtId, TextEdit TxtAd, TextEdit TxtSoyad, TextEdit TxtMail,
            MaskedTextBox MskTc, MaskedTextBox MskTel,ComboBoxEdit CmbBrans, ComboBoxEdit CmbIl, ComboBoxEdit CmbIlce,
            PictureBox PicBoxResim,RichTextBox RichAdres)
        {
            TxtId.Clear();
            TxtAd.Clear();
            TxtSoyad.Clear();
            TxtMail.Clear();
            MskTc.Clear();
            MskTel.Clear();
            CmbBrans.Clear();
            CmbIl.Clear();
            CmbIlce.Clear();
            PicBoxResim.ImageLocation="";
            RichAdres.Clear();
        }

        public static void Listele(GridControl grid,TextEdit TxtId, TextEdit TxtAd, TextEdit TxtSoyad, TextEdit TxtMail,
            MaskedTextBox MskTc, MaskedTextBox MskTel, ComboBoxEdit CmbBrans, ComboBoxEdit CmbIl, ComboBoxEdit CmbIlce,
            PictureBox PicBoxResim, RichTextBox RichAdres)
        {
            grid.DataSource = db().OgretmenBilgiGetir();
            db().IlIlceList(CmbIl, "il");
            db().IlIlceList(CmbIlce, "ilce");
            db().BransListele(CmbBrans);
            ViewMetod.Temizle(TxtId, TxtAd, TxtSoyad, TxtMail, MskTc, MskTel, CmbBrans, CmbIl, CmbIlce, PicBoxResim, RichAdres);
        }

        public static void KayitListeYenile(GridControl grid)
        {
            grid.DataSource = db().OgretmenBilgiGetir();
        }

        public static void SecimIlceListe(ComboBoxEdit CmbIlce, ComboBoxEdit CmbIl)
        {
            db().SecimIlceListe(CmbIlce, CmbIl);
        }

        public static void OgretmenBilgiKaydet(TextEdit ad, TextEdit soyad, MaskedTextBox tc,
            MaskedTextBox tel, TextEdit mail, ComboBoxEdit il,
            ComboBoxEdit ilce, RichTextBox adres, ComboBoxEdit brans, PictureBox resimkutusu)
        {
            db().OgretmenBilgiKaydet(ad, soyad, tc, tel, mail, il, ilce, adres, brans, resimkutusu);
        }

        public static void OgretmenBilgiGuncelle(TextEdit ad, TextEdit soyad, MaskedTextBox tc,
          MaskedTextBox tel, TextEdit mail, ComboBoxEdit il, ComboBoxEdit ilce, RichTextBox adres,
          ComboBoxEdit brans, PictureBox resimkutusu, TextEdit id)
        {
            db().OgretmenBilgiKaydet(ad, soyad, tc, tel, mail, il, ilce, adres, brans, resimkutusu);
        }

        public static void OgretmenKayitSil(TextEdit id)
        {
            db().OgretmenKayitSil(id);
        }
    }

}
