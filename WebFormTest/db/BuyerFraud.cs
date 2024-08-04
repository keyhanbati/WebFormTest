namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nanino.BuyerFraud")]
    public partial class BuyerFraud
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BuyerCode { get; set; }

        [StringLength(50)]
        public string PROVINCENAME { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string ProvinveCode { get; set; }

        [StringLength(100)]
        public string FraudTitle { get; set; }
    }
}
