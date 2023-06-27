using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OgretmenlerModul;

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
        {   //
            OgretmenlerSayfasi = new Ogretmenler();
            // parent olan form un içerisinde olması için tanımlama yapıldı OgretmenlerModul formunu yeni pencerede
            // değil de bu formun içerisinde açacak
            OgretmenlerSayfasi.MdiParent = this;
            OgretmenlerSayfasi.Show();
        }
    }
}
