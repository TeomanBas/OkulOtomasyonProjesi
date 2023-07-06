using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ViewMetodlari
{
    public class ViewMetod
    {
        public void GridViewSatir(DevExpress.XtraGrid.Views.Grid.GridView grid,TextEdit id,TextEdit ad, TextEdit soyad, MaskedTextBox tc,MaskedTextBox tel,TextEdit mail,ComboBoxEdit il,ComboBoxEdit ilce,RichTextBox adres,ComboBoxEdit brans)
        {
            DataRow dr = grid.GetDataRow(grid.FocusedRowHandle);
            id.Text = dr["OGRTID"].ToString();
            ad.Text = dr["OGRTAD"].ToString();
            soyad.Text = dr["OGRTSOYAD"].ToString();
            tc.Text = dr["OGRTTC"].ToString();
            tel.Text = dr["OGRTMAIL"].ToString();
            mail.Text = dr["OGRTMAIL"].ToString();
            il.Text = dr["OGRTIL"].ToString();
            ilce.Text = dr["OGRTILCE"].ToString();
            adres.Text = dr["OGRTADRES"].ToString();
            brans.Text = dr["OGRTBRANS"].ToString();
        }
    }
}
