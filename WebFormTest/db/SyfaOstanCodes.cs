namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Wheat.SyfaOstanCodes")]
    public partial class SyfaOstanCodes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OstanCode { get; set; }

        public string OstanName { get; set; }

        public int? ProvinceId { get; set; }
    }
}
