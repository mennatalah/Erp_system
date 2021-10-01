namespace ErpSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class company_name
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public company_name()
        {
            company_address = new HashSet<company_address>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int company_serial { get; set; }

        [Column("company_name")]
        [StringLength(50)]
        
        public string company_name1 { get; set; }

        public int? added_by { get; set; }

        public DateTime? date_added { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<company_address> company_address { get; set; }

        public virtual company_field_of_work company_field_of_work { get; set; }

        public virtual employees_info employees_info { get; set; }
    }
}
