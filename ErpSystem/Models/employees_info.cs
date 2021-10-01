namespace ErpSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class employees_info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employees_info()
        {
            company_address = new HashSet<company_address>();
            company_field_of_work = new HashSet<company_field_of_work>();
            company_name = new HashSet<company_name>();
            company_telephone = new HashSet<company_telephone>();
            contact_person_info = new HashSet<contact_person_info>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int employee_id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(10)]
        public string gender { get; set; }

        public int? employee_department { get; set; }

        public int? employee_team { get; set; }

        public int? employee_position { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birth_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? join_date { get; set; }

        public bool? currently_enrolled { get; set; }

        public DateTime? date_added { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<company_address> company_address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<company_field_of_work> company_field_of_work { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<company_name> company_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<company_telephone> company_telephone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contact_person_info> contact_person_info { get; set; }

        public virtual departments_type departments_type { get; set; }

        public virtual employees_business_emails employees_business_emails { get; set; }

        public virtual teams_type teams_type { get; set; }

        public virtual positions_type positions_type { get; set; }

        public virtual employees_passwords employees_passwords { get; set; }

        public virtual employees_personal_emails employees_personal_emails { get; set; }
    }
}
