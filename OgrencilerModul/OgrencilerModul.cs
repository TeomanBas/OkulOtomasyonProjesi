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
            ViewMetod.GridViewSatir(gridView1 , TxtId,TxtAd,TxtSoyad,MskTc,MskOgrenciNo,rdbtnerkek,rdbtnkadin,dateEdit1,gridLookUpEdit1,CmbIL,CmbIlce,RtbAdres,PicBoxResim);
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            ViewMetod.GridViewSatir(gridView2, TxtId, TxtAd, TxtSoyad, MskTc, MskOgrenciNo, rdbtnerkek, rdbtnkadin, dateEdit1, gridLookUpEdit1, CmbIL, CmbIlce, RtbAdres, PicBoxResim);
        }

        private void gridView3_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            ViewMetod.GridViewSatir(gridView3, TxtId, TxtAd, TxtSoyad, MskTc, MskOgrenciNo, rdbtnerkek, rdbtnkadin, dateEdit1, gridLookUpEdit1, CmbIL, CmbIlce, RtbAdres, PicBoxResim);
        }

        private void gridView4_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            ViewMetod.GridViewSatir(gridView4, TxtId, TxtAd, TxtSoyad, MskTc, MskOgrenciNo, rdbtnerkek, rdbtnkadin, dateEdit1, gridLookUpEdit1, CmbIL, CmbIlce, RtbAdres, PicBoxResim);
        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            ViewMetod.KayitEkle(TxtId, TxtAd, TxtSoyad, MskTc, MskOgrenciNo, CmbSinif, dateEdit1,rdbtnerkek, CmbIL,  CmbIlce, RtbAdres, PicBoxResim);
            ViewMetod.Listele(grd5, grd6, grd7, grd8, CmbIL, CmbIlce);
        }
    }
}
