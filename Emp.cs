namespace Lab3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Emp")]
    public partial class Emp
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Fname { get; set; }

        [StringLength(50)]
        public string Lname { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public int? Salary { get; set; }

        public int? Dept_id { get; set; }

        public virtual Department Department { get; set; }
    }
}
