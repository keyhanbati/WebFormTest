namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Seller.SellerStatuses")]
    public partial class SellerStatuses
    {
        public int Id { get; set; }

        public int SellerId { get; set; }

        public byte SellerStatusId { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public bool IsLast { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual Sellers Sellers { get; set; }
    }
}
