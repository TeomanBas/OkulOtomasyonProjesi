﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OkulOtomasyonEntities : DbContext
    {
        public OkulOtomasyonEntities()
            : base("name=OkulOtomasyonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBL_IL> TBL_IL { get; set; }
        public virtual DbSet<TBL_ILCE> TBL_ILCE { get; set; }
        public virtual DbSet<TBL_OGRENCILER> TBL_OGRENCILER { get; set; }
        public virtual DbSet<TBL_OGRETMENLER> TBL_OGRETMENLER { get; set; }
        public virtual DbSet<TBL_VELILER> TBL_VELILER { get; set; }
        public virtual DbSet<TBL_BRANSLAR> TBL_BRANSLAR { get; set; }
    }
}