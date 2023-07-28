using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Veritabani;
using ViewMetodlari;

namespace OgretmenlerModul
{
    public partial class Ogretmenler : DevExpress.XtraEditors.XtraForm
    {
        public Ogretmenler()
        {
            InitializeComponent();
            // hangi formun ebeyni olacağını seçiyoruz
            this.MdiParent = Application.OpenForms["AnaModul"];
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void labelControl15_Click(object sender, EventArgs e)
        {

        }

        private void labelControl16_Click(object sender, EventArgs e)
        {

        }

        private void Ogretmenler_Load(object sender, EventArgs e)
        {
            ViewMetod.Listele(gridControl1,TxtId, TxtAd, TxtSoyad, TxtMail, MskTc, MskTel, CmbBrans, CmbIl, CmbIlce, PicBoxResim, RichAdres);
        }

        private void CmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewMetod.SecimIlceListe(CmbIlce, CmbIl);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            ViewMetod.KayitEkle(TxtId,TxtAd, TxtSoyad, MskTc, MskTel, TxtMail, CmbIl, CmbIlce, RichAdres, CmbBrans, PicBoxResim);
            ViewMetod.KayitListeYenile(gridControl1);
        }

        private void Ogretmenler_FormClosing(object sender, FormClosingEventArgs e)
        {
            // birden çok sayfa olduğu için bellekte hepsinin yer kaplamasına karşın çarpı butonuna tıklandığında bu form ile ilgili tüm kaynaklar serbest bırakılıyor
            this.Dispose();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            ViewMetod.GridViewSatir(gridView1, TxtId, TxtAd, TxtSoyad, MskTc, MskTel, TxtMail, CmbIl, CmbIlce, RichAdres, CmbBrans, PicBoxResim);
        }
        private void BtnResimSec_Click(object sender, EventArgs e)
        {
            ViewMetod.ResimSec(PicBoxResim);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ViewMetod.KayitGuncelle(TxtAd, TxtSoyad, MskTc, MskTel, TxtMail, CmbIl, CmbIlce, RichAdres, CmbBrans, PicBoxResim,TxtId);
            ViewMetod.KayitListeYenile(gridControl1);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            ViewMetod.OgretmenKayitSil(TxtId);
            ViewMetod.KayitListeYenile(gridControl1);
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            ViewMetod.Temizle(TxtId,TxtAd,TxtSoyad,TxtMail,MskTc,MskTel,CmbBrans,CmbIl,CmbIlce,PicBoxResim,RichAdres);
        }

    }
}
