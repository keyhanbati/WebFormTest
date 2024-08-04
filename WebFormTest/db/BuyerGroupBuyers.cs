namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.BuyerGroupBuyers")]
    public partial class BuyerGroupBuyers
    {
        public int Id { get; set; }

        public int BuyerGroupId { get; set; }

        public int BuyerId { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual BuyerGroups BuyerGroups { get; set; }

        public virtual Buyers Buyers { get; set; }
    }
}
