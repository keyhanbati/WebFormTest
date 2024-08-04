namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UnitDegrees
    {
        [Key]
        [Column("UnitDegreeId ")]
        public int UnitDegreeId_ { get; set; }

        public string UnitDegreeName { get; set; }
    }
}
