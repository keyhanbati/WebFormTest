namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ws.OrderInquiries")]
    public partial class OrderInquiries
    {
        public long Id { get; set; }

        public int OrderId { get; set; }

        public int OrderItemId { get; set; }

        public int RequestId { get; set; }

        public byte Status { get; set; }

        public DateTime? DeliveryDate { get; set; }
    }
}
