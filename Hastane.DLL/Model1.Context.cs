﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hastane.DLL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HastahaneDBEntities : DbContext
    {
        public HastahaneDBEntities()
            : base("name=HastahaneDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BireyselGelirler> BireyselGelirler { get; set; }
        public virtual DbSet<BireyselGiderler> BireyselGiderler { get; set; }
        public virtual DbSet<Branslar> Branslar { get; set; }
        public virtual DbSet<DoktorBilgileri> DoktorBilgileri { get; set; }
        public virtual DbSet<Doktorlar> Doktorlar { get; set; }
        public virtual DbSet<DoktorUnvanlari> DoktorUnvanlari { get; set; }
        public virtual DbSet<Gelirler> Gelirler { get; set; }
        public virtual DbSet<Giderler> Giderler { get; set; }
        public virtual DbSet<Hastalar> Hastalar { get; set; }
        public virtual DbSet<iller> iller { get; set; }
        public virtual DbSet<KanGruplari> KanGruplari { get; set; }
        public virtual DbSet<Klinikler> Klinikler { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }
        public virtual DbSet<KurumsalGelirler> KurumsalGelirler { get; set; }
        public virtual DbSet<KurumsalGiderler> KurumsalGiderler { get; set; }
        public virtual DbSet<Personeller> Personeller { get; set; }
        public virtual DbSet<Randevular> Randevular { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Yetkiler> Yetkiler { get; set; }
        public virtual DbSet<vw_BireyselGelirler> vw_BireyselGelirler { get; set; }
        public virtual DbSet<vw_BireyselGiderler> vw_BireyselGiderler { get; set; }
        public virtual DbSet<vw_Branslar> vw_Branslar { get; set; }
        public virtual DbSet<vw_Doktorlar> vw_Doktorlar { get; set; }
        public virtual DbSet<vw_DoktorUnvanlari> vw_DoktorUnvanlari { get; set; }
        public virtual DbSet<vw_Gelirler> vw_Gelirler { get; set; }
        public virtual DbSet<vw_Giderler> vw_Giderler { get; set; }
        public virtual DbSet<vw_Hastalar> vw_Hastalar { get; set; }
        public virtual DbSet<vw_KanGruplari> vw_KanGruplari { get; set; }
        public virtual DbSet<vw_klinikler> vw_klinikler { get; set; }
        public virtual DbSet<vw_Kullanicilar> vw_Kullanicilar { get; set; }
        public virtual DbSet<vw_KurumsalGelirler> vw_KurumsalGelirler { get; set; }
        public virtual DbSet<vw_KurumsalGiderler> vw_KurumsalGiderler { get; set; }
        public virtual DbSet<vw_Personeller> vw_Personeller { get; set; }
        public virtual DbSet<vw_Randevular> vw_Randevular { get; set; }
        public virtual DbSet<vw2_DoktorBilgileri> vw2_DoktorBilgileri { get; set; }
        public virtual DbSet<vw_DoktorBilgileri> vw_DoktorBilgileri { get; set; }
    }
}
