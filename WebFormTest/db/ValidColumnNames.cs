namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.ValidColumnNames")]
    public partial class ValidColumnNames
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string ColumnName { get; set; }
    }
}
