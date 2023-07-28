using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using OgretmenlerModul;
using OgrencilerModul;

namespace AnaModul
{
    
    public partial class AnaModul : DevExpress.XtraEditors.XtraForm
    {
        public AnaModul() 
        {
            InitializeComponent();
            // ana form içerisinde diğer formların gösterilmesi için yapılan ayarlama
            this.IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        // OgretmenlerModul name space indeki OgretmenlerModul class ına erişim sağladık
        Ogretmenler OgretmenlerSayfasi;
        private void BtnOgretmenler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // bir nesne üretip onun üzerinden kontrol edildiğinde sorun oluyor form üzerinden kontrol ederek problem çözüldü
            if (Application.OpenForms["Ogretmenler"] == null)
            {
                OgretmenlerSayfasi = new Ogretmenler();
                OgretmenlerSayfasi.MdiParent = this;
                OgretmenlerSayfasi.Show();
            }
            else 
            {
                Application.OpenForms["Ogretmenler"].Activate();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ogrenciler ogrenciler = new Ogrenciler();
            if (Application.OpenForms["Ogrenciler"] == null)
            {
                ogrenciler.MdiParent = this;
                ogrenciler.Show();
            }
            else
            {
                Application.OpenForms["Ogrenciler"].Activate();
            }
        }
    }
}
