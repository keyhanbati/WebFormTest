namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CallCount")]
    public partial class CallCount
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string SPNAME { get; set; }

        public DateTime? date { get; set; }
    }
}
