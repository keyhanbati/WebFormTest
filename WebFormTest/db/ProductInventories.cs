namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inv.ProductInventories")]
    public partial class ProductInventories
    {
        public int Id { get; set; }

        public int IntervalId { get; set; }

        public int SellerId { get; set; }

        public int ProductId { get; set; }

        public int ProductsInvTransactionTypeId { get; set; }

        public long Amount { get; set; }

        public long TotalRemain { get; set; }

        public bool IsLast { get; set; }

        public long? OrderId { get; set; }

        public string Description { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual Intervals Intervals { get; set; }

        public virtual Orders Orders { get; set; }

        public virtual Products Products { get; set; }

        public virtual Sellers Sellers { get; set; }
    }
}
