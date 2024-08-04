namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CdcExceptTable")]
    public partial class CdcExceptTable
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string TableSchema { get; set; }

        [Required]
        [StringLength(100)]
        public string TableName { get; set; }

        public byte RowStatusId { get; set; }
    }
}
