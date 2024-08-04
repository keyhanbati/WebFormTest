namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.OrderStatuses")]
    public partial class OrderStatuses
    {
        public int Id { get; set; }

        public long OrderId { get; set; }

        public int OrderStatusId { get; set; }

        public bool IsLast { get; set; }

        [Required]
        [StringLength(20)]
        public string UserIPAddress { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual Orders Orders { get; set; }
    }
}
