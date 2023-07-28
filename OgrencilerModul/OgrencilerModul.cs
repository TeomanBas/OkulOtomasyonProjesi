using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using ViewMetodlari;

namespace OgrencilerModul
{
    public partial class Ogrenciler : DevExpress.XtraEditors.XtraForm
    {
        public Ogrenciler()
        {
            InitializeComponent();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void BtnResimSec_Click(object sender, EventArgs e)
        {

        }

        private void labelControl15_Click(object sender, EventArgs e)
        {

        }

        private void labelControl16_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Ogrenciler_Load(object sender, EventArgs e)
        {
            ViewMetod.Listele(grd5, grd6, grd7, grd8, CmbIL, CmbIlce);
        }

        private void CmbIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewMetod.SecimIlceListe(CmbIlce,CmbIL);
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            ViewMetod.GridViewSatir(gridView1 , TxtId,TxtAd,TxtSoyad,MskTc,MskOgrenciNo,rdbtnerkek,rdbtnkadin,dateEdit1,gridLookUpEdit1, CmbSinif, CmbIL,CmbIlce,RtbAdres,PicBoxResim);
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            ViewMetod.GridViewSatir(gridView2, TxtId, TxtAd, TxtSoyad, MskTc, MskOgrenciNo, rdbtnerkek, rdbtnkadin, dateEdit1, gridLookUpEdit1, CmbSinif, CmbIL, CmbIlce, RtbAdres, PicBoxResim);
        }

        private void gridView3_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            ViewMetod.GridViewSatir(gridView3, TxtId, TxtAd, TxtSoyad, MskTc, MskOgrenciNo, rdbtnerkek, rdbtnkadin, dateEdit1, gridLookUpEdit1, CmbSinif, CmbIL, CmbIlce, RtbAdres, PicBoxResim);
        }

        private void gridView4_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            ViewMetod.GridViewSatir(gridView4, TxtId, TxtAd, TxtSoyad, MskTc, MskOgrenciNo, rdbtnerkek, rdbtnkadin, dateEdit1, gridLookUpEdit1,CmbSinif, CmbIL, CmbIlce, RtbAdres, PicBoxResim);
        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            ViewMetod.KayitEkle(TxtId, TxtAd, TxtSoyad, MskTc, MskOgrenciNo, CmbSinif, dateEdit1,rdbtnerkek, CmbIL,  CmbIlce, RtbAdres, PicBoxResim);
            ViewMetod.Listele(grd5, grd6, grd7, grd8, CmbIL, CmbIlce);
        }

        private void BtnResimSec_Click_1(object sender, EventArgs e)
        {
            ViewMetod.ResimSec(PicBoxResim);
        }

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {
            ViewMetod.KayitGuncelle(TxtId, TxtAd, TxtSoyad, MskTc, MskOgrenciNo, CmbSinif, dateEdit1, rdbtnerkek, CmbIL, CmbIlce, RtbAdres, PicBoxResim);
            ViewMetod.Listele(grd5, grd6, grd7, grd8, CmbIL, CmbIlce);
        }

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            ViewMetod.KayitSil(TxtId, "ogrenci");
            ViewMetod.Listele(grd5, grd6, grd7, grd8, CmbIL, CmbIlce);
        }

        private void BtnTemizle_Click_1(object sender, EventArgs e)
        {
            ViewMetod.Temizle(TxtId, TxtAd, TxtSoyad, MskTc, MskOgrenciNo, CmbSinif, dateEdit1, rdbtnerkek,rdbtnkadin, CmbIL, CmbIlce, RtbAdres, PicBoxResim);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            OgrenciKarti(gridView1);
        }
        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            OgrenciKarti(gridView2);
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            OgrenciKarti(gridView3);
        }

        private void gridView4_DoubleClick(object sender, EventArgs e)
        {
            OgrenciKarti(gridView4);

        }

        public void OgrenciKarti(GridView gr)
        {
            // ViewMetod.OgrenciKartBilgileri(gridView2);
            OgrenciKarti ogrkart = new OgrenciKarti();
            string[] satir = ViewMetod.OgrenciKartBilgileri(gr);
            ogrkart.tc = satir[0];
            ogrkart.ogrno = satir[1];
            ogrkart.adsoyad = satir[2] + " " + satir[3];
            ogrkart.dogum = satir[4];
            ogrkart.cinsiyet = satir[5] == "e" ? "erkek" : "kadın";
            ogrkart.foto = satir[6];
            ViewMetod.KartGoster(ogrkart);
        }
    }
}
