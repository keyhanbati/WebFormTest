namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("acc.NationalCodes")]
    public partial class NationalCodes
    {
        [Key]
        [StringLength(11)]
        public string NationalCode { get; set; }

        public int ReferenceType { get; set; }

        public int ReferenceId { get; set; }

        public int? PersonId { get; set; }

        public int Category { get; set; }

        public bool IsValid { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
