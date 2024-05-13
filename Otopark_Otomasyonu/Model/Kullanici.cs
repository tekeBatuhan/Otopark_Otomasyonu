namespace Otopark_Otomasyonu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            AracBilgi = new HashSet<AracBilgi>();
            Musteri = new HashSet<Musteri>();
        }

        public int kullaniciID { get; set; }

        public int? unvanID { get; set; }

        public int? saatlikUcretID { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [StringLength(50)]
        public string soyad { get; set; }

        [StringLength(50)]
        public string eposta { get; set; }

        [StringLength(50)]
        public string sifre { get; set; }

        [StringLength(500)]
        public string adres { get; set; }

        [StringLength(11)]
        public string telefon { get; set; }

        [StringLength(11)]
        public string kimlikNo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dogumTarihi { get; set; }

        [StringLength(50)]
        public string cinsiyet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracBilgi> AracBilgi { get; set; }

        public virtual SaatlikUcret SaatlikUcret { get; set; }

        public virtual Unvan Unvan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Musteri> Musteri { get; set; }
    }
}
