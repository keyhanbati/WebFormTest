namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Seller.SellerRates")]
    public partial class SellerRates
    {
        public int Id { get; set; }

        public int OrderItemId { get; set; }

        public int SellerId { get; set; }

        public byte Rate { get; set; }

        [StringLength(500)]
        public string Comments { get; set; }

        [Required]
        [StringLength(20)]
        public string UserIPAddress { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual OrderItems OrderItems { get; set; }

        public virtual Sellers Sellers { get; set; }
    }
}
