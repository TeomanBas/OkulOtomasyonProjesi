﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
            ViewMetod.OgrenciListele(grd5,grd6,grd7,grd8);
        }
    }
}