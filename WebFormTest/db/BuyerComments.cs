namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.BuyerComments")]
    public partial class BuyerComments
    {
        public long Id { get; set; }

        public int BuyerId { get; set; }

        [Required]
        [StringLength(500)]
        public string Comment { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual Buyers Buyers { get; set; }
    }
}
