//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Veritabani
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_OGRENCILER
    {
        public int OGRID { get; set; }
        public string OGRNO { get; set; }
        public Nullable<int> OGRVELIID { get; set; }
        public string OGRAD { get; set; }
        public string OGRSOYAD { get; set; }
        public Nullable<System.DateTime> OGRDOGUM { get; set; }
        public string OGRCINSIYET { get; set; }
        public string OGRTC { get; set; }
        public string OGRIL { get; set; }
        public string OGRILCE { get; set; }
        public string OGRADRES { get; set; }
        public string OGRSINIF { get; set; }
        public string OGRFOTO { get; set; }
    
        public virtual TBL_VELILER TBL_VELILER { get; set; }
    }
}
