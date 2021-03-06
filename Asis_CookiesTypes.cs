namespace CookiesParadise
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Asis_CookiesTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Asis_CookiesTypes()
        {
            Asis_Cookies = new HashSet<Asis_Cookies>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string CookiesType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asis_Cookies> Asis_Cookies { get; set; }
    }
}
