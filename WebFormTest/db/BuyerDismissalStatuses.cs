namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.BuyerDismissalStatuses")]
    public partial class BuyerDismissalStatuses
    {
        public int Id { get; set; }

        public long BuyerDismissalId { get; set; }

        public int BuyerDismissalStatusId { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public bool IsLast { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual BuyerDismissals BuyerDismissals { get; set; }
    }
}
