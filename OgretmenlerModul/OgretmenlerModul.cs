using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Veritabani;

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
    }
}
