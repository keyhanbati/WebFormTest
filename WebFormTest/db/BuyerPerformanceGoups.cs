namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.BuyerPerformanceGoups")]
    public partial class BuyerPerformanceGoups
    {
        public int Id { get; set; }

        public double? FlourSalePercentage { get; set; }

        public double? FlourSaleWithFraudPercentage { get; set; }

        public double IncerasePercentage { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int GroupNumber { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
