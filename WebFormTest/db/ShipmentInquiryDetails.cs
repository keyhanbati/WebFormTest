namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipping.ShipmentInquiryDetails")]
    public partial class ShipmentInquiryDetails
    {
        public int Id { get; set; }

        public int ShipmentInquiryId { get; set; }

        public int OrderItemId { get; set; }

        public int TransportationPricingUnitTypeId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public long ShippingUnitPrice { get; set; }

        public long SuperviseUnitPrice { get; set; }

        public virtual OrderItems OrderItems { get; set; }

        public virtual ShipmentInquiries ShipmentInquiries { get; set; }
    }
}
