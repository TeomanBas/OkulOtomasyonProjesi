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
using DevExpress.XtraGrid.Views.Grid;

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
        public static void GridViewSatir(GridView grid, TextEdit TxtId, TextEdit TxtAd, TextEdit TxtSoyad, MaskedTextBox MskTc,MaskedTextBox MskOgrenciNo, 
            RadioButton rdbtnerkek, RadioButton rdbtnkadin,DateEdit dogum, GridLookUpEdit veli,
            ComboBoxEdit CmbIL, ComboBoxEdit CmbIlce,RichTextBox RchAdres,PictureBox ogrresim)
        {
            DataRow dr = grid.GetDataRow(grid.FocusedRowHandle);
            TxtId.Text = dr["OGRID"].ToString();
            TxtAd.Text = dr["OGRAD"].ToString();
            TxtSoyad.Text = dr["OGRSOYAD"].ToString();
            MskTc.Text = dr["OGRTC"].ToString();
            MskOgrenciNo.Text = dr["OGRNO"].ToString();
            if (dr["OGRCINSIYET"].ToString() == "e")
            {
                rdbtnerkek.Checked = true;
            }
            else
            {
                rdbtnkadin.Checked = true;
            }
            CmbIL.Text = dr["OGRIL"].ToString();
            CmbIlce.Text = dr["OGRIlce"].ToString();
            dogum.Text = dr["OGRDOGUM"].ToString();
            RchAdres.Text = dr["OGRADRES"].ToString();
            ogrresim.ImageLocation = dr["OGRFOTO"].ToString();
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
                    // picturebox'ın location değeri yeni resim dizini ile değiştirildi 
                    resimkutusu.ImageLocation = dosyadizin;
                }
                else
                {
                    dosyadizin = "";
                    MessageBox.Show("Dosya Boyutu 5 MB'den büyük olamaz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static string ResimKopyala(string kaynak)
        {
            // burada kayit dizini release çıkıldığında değiştirilmesi gerekli bu dizin debug için geçerlidir.!!!
            string hedef = @"..\..\..\OgretmenlerModul\Resimler";
            // dizin kontrolü
            if (!File.Exists(hedef))
            {
                Directory.CreateDirectory(hedef);
            }
            // kopyalacak yeni dizin tanımlaması yapıldı.Dizin referansları exe dosyalarından yapılıyor
            // form anamodul altında olduğu için "Anamodul\bin\debug\anamodul.exe" referans alınıyor
            string hedefdosya = hedef + @"\" + Guid.NewGuid().ToString() + ".jpg";

            // dosya yeni dizine kopyalandı
            File.Copy(kaynak, hedefdosya);
            return hedefdosya;
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
            grid.DataSource = db().TabloBilgiGetir("ogretmen");
            db().IlIlceList(CmbIl, "il");
            db().IlIlceList(CmbIlce, "ilce");
            db().BransListele(CmbBrans);
            ViewMetod.Temizle(TxtId, TxtAd, TxtSoyad, TxtMail, MskTc, MskTel, CmbBrans, CmbIl, CmbIlce, PicBoxResim, RichAdres);
        }
        public static void Listele(GridControl gr1, GridControl gr2, GridControl gr3, GridControl gr4, ComboBoxEdit CmbIl, ComboBoxEdit CmbIlce)
        {
            gr1.DataSource = db().TabloBilgiGetir("ogrenci", "5.SINIF");
            gr2.DataSource = db().TabloBilgiGetir("ogrenci", "6.SINIF");
            gr3.DataSource = db().TabloBilgiGetir("ogrenci", "7.SINIF");
            gr4.DataSource = db().TabloBilgiGetir("ogrenci", "8.SINIF");
            db().IlIlceList(CmbIl, "il");
            db().IlIlceList(CmbIlce, "ilce");
        }

        public static void KayitListeYenile(GridControl grid)
        {
            grid.DataSource = db().TabloBilgiGetir("ogretmen");
        }

        public static void SecimIlceListe(ComboBoxEdit CmbIlce, ComboBoxEdit CmbIl)
        {
            db().SecimIlceListe(CmbIlce, CmbIl);
        }

        public static void OgretmenBilgiKaydet(TextEdit id,TextEdit ad, TextEdit soyad, MaskedTextBox tc,
            MaskedTextBox tel, TextEdit mail, ComboBoxEdit il,
            ComboBoxEdit ilce, RichTextBox adres, ComboBoxEdit brans, PictureBox resimkutusu)
        {
            if (id.Text != "")
            {
                MessageBox.Show("Personel eklemek için önce personel bilgilerini temizleyin",
                    "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                db().OgretmenBilgiKaydet(ad, soyad, tc, tel, mail, il, ilce, adres, brans, ResimKopyala(resimkutusu.ImageLocation));

            }
        }

        public static void OgretmenBilgiGuncelle(TextEdit ad, TextEdit soyad, MaskedTextBox tc,
          MaskedTextBox tel, TextEdit mail, ComboBoxEdit il, ComboBoxEdit ilce, RichTextBox adres,
          ComboBoxEdit brans, PictureBox resimkutusu, TextEdit id)
        {
            db().OgretmenBilgiGuncelle(ad, soyad, tc, tel, mail, il, ilce, adres, brans, ResimKopyala(resimkutusu.ImageLocation), id);
        }

        public static void OgretmenKayitSil(TextEdit id)
        {
            db().OgretmenKayitSil(id);
        }
    }

}
