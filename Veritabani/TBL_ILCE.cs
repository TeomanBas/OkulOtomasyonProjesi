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
    
    public partial class TBL_ILCE
    {
        public int id { get; set; }
        public string ilce { get; set; }
        public int sehir { get; set; }
    
        public virtual TBL_IL TBL_IL { get; set; }
    }
}
