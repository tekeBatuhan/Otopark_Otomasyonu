namespace Otopark_Otomasyonu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GecmisIslem")]
    public partial class GecmisIslem
    {
        public int gecmisIslemID { get; set; }

        public int? musteriID { get; set; }

        public int? aracBilgiID { get; set; }

        [Column(TypeName = "money")]
        public decimal? ucret { get; set; }

        [StringLength(50)]
        public string plaka { get; set; }

        [StringLength(50)]
        public string marka { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? girisTarihi { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? cikisTarihi { get; set; }

        [StringLength(50)]
        public string renk { get; set; }

        public virtual AracBilgi AracBilgi { get; set; }

        public virtual Musteri Musteri { get; set; }
    }
}
