namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.BuyerStatuses")]
    public partial class BuyerStatuses
    {
        public int Id { get; set; }

        public int BuyerId { get; set; }

        public int BuyerStatusId { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public bool IsLast { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual Buyers Buyers { get; set; }
    }
}
