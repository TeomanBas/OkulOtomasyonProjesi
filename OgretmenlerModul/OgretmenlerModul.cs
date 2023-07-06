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
        Veritabani.Veritabani bgl = new Veritabani.Veritabani();
        ViewMetodlari.ViewMetod viewmetod = new ViewMetod();
        private void Ogretmenler_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = bgl.OgretmenBilgiGetir();
            bgl.IlIlceList(CmbIl, "il");
            bgl.IlIlceList(CmbIlce,"ilce");
            bgl.BransListele(CmbBrans);
        }

        private void CmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            bgl.SecimIlceListe(CmbIlce, CmbIl);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            bgl.OgretmenBilgiKaydet(TxtAd, TxtSoyad, MskTc, MskTel, TxtMail, CmbIl, CmbIlce, RichAdres, CmbBrans);
        }
        // birden çok sayfa olduğu için bellekte hepsinin yer kaplamasına karşın çarpı butonuna tıklandığında bu form ile ilgili tüm kaynaklar serbest bırakılıyor
        private void Ogretmenler_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
        
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            viewmetod.GridViewSatir(gridView1, TxtId, TxtAd, TxtSoyad, MskTc, MskTel, TxtMail, CmbIl, CmbIlce, RichAdres, CmbBrans);
        }
    }
}
