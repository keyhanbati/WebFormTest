namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.BuyerPos")]
    public partial class BuyerPos
    {
        public long Id { get; set; }

        public int BuyerId { get; set; }

        public int PosNumber { get; set; }

        public int PosStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual Buyers Buyers { get; set; }
    }
}
