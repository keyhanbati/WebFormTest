namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.BuyerAsnafStatuses")]
    public partial class BuyerAsnafStatuses
    {
        public int Id { get; set; }

        public int BuyerId { get; set; }

        public int BuyerAsnafStatusId { get; set; }

        public bool IsLast { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
