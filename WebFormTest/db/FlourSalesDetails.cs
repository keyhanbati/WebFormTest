namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Quota.FlourSalesDetails")]
    public partial class FlourSalesDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public int BuyerId { get; set; }

        [Column(TypeName = "date")]
        public DateTime SaleDate { get; set; }

        public long FlourSaleAmount { get; set; }

        public int SaleCount { get; set; }

        public long SalePrice { get; set; }

        public int CookingTypeId { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual Buyers Buyers { get; set; }
    }
}
