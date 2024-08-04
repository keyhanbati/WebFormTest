namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ws.OrdersInquiryRequests")]
    public partial class OrdersInquiryRequests
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string TrackingCode { get; set; }

        public int ClientId { get; set; }

        public DateTime RequestDate { get; set; }
    }
}
