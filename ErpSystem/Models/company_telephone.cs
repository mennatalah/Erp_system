namespace ErpSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class company_telephone
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int branch_serial { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string telephone_number { get; set; }

        public int? added_by { get; set; }

        public DateTime? date_added { get; set; }

        public virtual company_address company_address { get; set; }

        public virtual employees_info employees_info { get; set; }
    }
}
