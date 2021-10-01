namespace ErpSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class contact_person_info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public contact_person_info()
        {
            contact_person_mobile = new HashSet<contact_person_mobile>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sales_person_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int branch_serial { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int contact_id { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(10)]
        public string gender { get; set; }

        public int? department { get; set; }

        public bool? is_valid { get; set; }

        public DateTime? date_added { get; set; }

        public virtual company_address company_address { get; set; }

        public virtual departments_type departments_type { get; set; }

        public virtual employees_info employees_info { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contact_person_mobile> contact_person_mobile { get; set; }
    }
}
