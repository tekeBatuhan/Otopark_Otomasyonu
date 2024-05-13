using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Otopark_Otomasyonu.Model
{
    public partial class OtoparkContext : DbContext
    {
        public OtoparkContext()
            : base("name=OtoparkContext")
        {
        }

        public virtual DbSet<AracBilgi> AracBilgi { get; set; }
        public virtual DbSet<GecmisIslem> GecmisIslem { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<SaatlikUcret> SaatlikUcret { get; set; }
        public virtual DbSet<Unvan> Unvan { get; set; }
        public virtual DbSet<Yer> Yer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AracBilgi>()
                .Property(e => e.ucret)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GecmisIslem>()
                .Property(e => e.ucret)
                .HasPrecision(19, 4);
        }
    }
}
