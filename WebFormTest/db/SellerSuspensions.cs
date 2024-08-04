namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Seller.SellerSuspensions")]
    public partial class SellerSuspensions
    {
        public int Id { get; set; }

        public int SellerId { get; set; }

        public int SuspensionCauseTypeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime FromDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ToDate { get; set; }

        [Required]
        [StringLength(500)]
        public string Comments { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public virtual Sellers Sellers { get; set; }
    }
}
