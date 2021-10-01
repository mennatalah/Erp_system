namespace ErpSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class company_address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public company_address()
        {
            company_telephone = new HashSet<company_telephone>();
            contact_person_info = new HashSet<contact_person_info>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int address_serial { get; set; }

        public int? company_serial { get; set; }

        public int? address { get; set; }

        public int? added_by { get; set; }

        public DateTime? date_added { get; set; }

        public virtual employees_info employees_info { get; set; }

        public virtual district district { get; set; }

        public virtual company_name company_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<company_telephone> company_telephone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contact_person_info> contact_person_info { get; set; }
    }
}
