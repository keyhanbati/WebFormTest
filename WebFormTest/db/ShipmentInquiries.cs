namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipping.ShipmentInquiries")]
    public partial class ShipmentInquiries
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShipmentInquiries()
        {
            ShipmentInquiryDetails = new HashSet<ShipmentInquiryDetails>();
        }

        public int Id { get; set; }

        public int ShipmentId { get; set; }

        public long ShippingPriceInquireCode { get; set; }

        public int TransportationCompanyId { get; set; }

        public long ShipmentCost { get; set; }

        public bool IsSelected { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public long SupervisionCost { get; set; }

        public virtual Shipments Shipments { get; set; }

        public virtual TransportationCompanies TransportationCompanies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipmentInquiryDetails> ShipmentInquiryDetails { get; set; }
    }
}
