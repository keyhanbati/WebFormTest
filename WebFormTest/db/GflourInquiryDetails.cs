namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inv.GflourInquiryDetails")]
    public partial class GflourInquiryDetails
    {
        public int Id { get; set; }

        public int RequestId { get; set; }

        public long OrderId { get; set; }

        public long OrderItemId { get; set; }

        public int SellerId { get; set; }

        public int IntervalNumber { get; set; }

        public long ProductAmount { get; set; }

        public decimal SepratingRate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public int ProductType { get; set; }

        public int UsageTypeId { get; set; }

        public bool IsSynchronized { get; set; }
    }
}
