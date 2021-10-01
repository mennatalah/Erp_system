namespace ErpSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class company_field_of_work
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int company_serial { get; set; }

        public int? work_field { get; set; }

        public int? added_by { get; set; }

        public DateTime? date_added { get; set; }

        public virtual employees_info employees_info { get; set; }

        public virtual company_name company_name { get; set; }

        public virtual specific_work_fields specific_work_fields { get; set; }
    }
}
