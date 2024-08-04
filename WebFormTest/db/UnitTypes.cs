namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UnitTypes
    {
        [Key]
        public byte UnitTypeID { get; set; }

        [Required]
        public string UnitTypeName { get; set; }

        public int? UnitTypeOrder { get; set; }
    }
}
