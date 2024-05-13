namespace Otopark_Otomasyonu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yer")]
    public partial class Yer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Yer()
        {
            AracBilgi = new HashSet<AracBilgi>();
        }

        public int yerID { get; set; }

        [StringLength(50)]
        public string adı { get; set; }

        public bool? doluMu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracBilgi> AracBilgi { get; set; }
    }
}
