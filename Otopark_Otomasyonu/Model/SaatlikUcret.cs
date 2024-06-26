namespace Otopark_Otomasyonu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaatlikUcret")]
    public partial class SaatlikUcret
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SaatlikUcret()
        {
            Kullanici = new HashSet<Kullanici>();
        }

        public int saatlikUcretID { get; set; }

        [StringLength(50)]
        public string birSaat { get; set; }

        [StringLength(50)]
        public string ucSaat { get; set; }

        [StringLength(50)]
        public string ucdenFazlaSaat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kullanici> Kullanici { get; set; }
    }
}
