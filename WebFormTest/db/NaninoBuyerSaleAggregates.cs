namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nanino.NaninoBuyerSaleAggregates")]
    public partial class NaninoBuyerSaleAggregates
    {
        public long Id { get; set; }

        public int BuyerId { get; set; }

        public int IntervalId { get; set; }

        public int PhaseId { get; set; }

        [Column(TypeName = "date")]
        public DateTime SaleStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime SaleEndDate { get; set; }

        public int CookingTypeId { get; set; }

        public decimal? FlourSaleAmount { get; set; }

        public int SaleCount { get; set; }

        public long SalePrice { get; set; }

        public decimal FlourSaleAmountWithFraud { get; set; }

        public int SaleCountWithFraud { get; set; }

        public long SalePriceWithFraud { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
