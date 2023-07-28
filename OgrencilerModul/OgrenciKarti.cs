using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace OgrencilerModul
{
    public partial class OgrenciKarti : Form
    {

        public string ogrno
        {
            set
            {
                lblOgrNo.Text = value;
            }
        }

        public string tc
        {
            set
            {
                lblTc.Text = value;
            }
        }
        public string adsoyad
        {
            set
            {
                lblAdSoyad.Text = value;
            }
        }
        public string dogum
        {
            set
            {
                lblDtar.Text = value;
            }
        }
        public string cinsiyet
        {
            set
            {
                lblCinsiyet.Text = value;
            }
        }
        public string foto
        {
            set
            {
                pictureBox1.ImageLocation = value;
            }
        }

        public OgrenciKarti()
        {
            InitializeComponent();
        }

        private void OgrenciKarti_Load(object sender, EventArgs e)
        {

        }
    }
}
