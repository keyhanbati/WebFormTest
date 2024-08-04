namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Wheat.SyfaUseTypes")]
    public partial class SyfaUseTypes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int UsageTypeId { get; set; }

        public int SubsidyStatusId { get; set; }

        public int ProductTypeId { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
