namespace Otopark_Otomasyonu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AracBilgi")]
    public partial class AracBilgi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AracBilgi()
        {
            GecmisIslem = new HashSet<GecmisIslem>();
        }

        public int aracBilgiID { get; set; }

        public int? kullaniciID { get; set; }

        public int? musteriID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? girisTarihi { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? cikisTarihi { get; set; }

        [StringLength(50)]
        public string plaka { get; set; }

        [StringLength(50)]
        public string marka { get; set; }

        [Column(TypeName = "money")]
        public decimal? ucret { get; set; }

        [StringLength(50)]
        public string renk { get; set; }

        public int? yerID { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual Musteri Musteri { get; set; }

        public virtual Yer Yer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GecmisIslem> GecmisIslem { get; set; }
    }
}
