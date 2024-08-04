namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.OrderItems")]
    public partial class OrderItems
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderItems()
        {
            ProductRates = new HashSet<ProductRates>();
            SellerRates = new HashSet<SellerRates>();
            ShipmentInfoDetails = new HashSet<ShipmentInfoDetails>();
            ShipmentInquiryDetails = new HashSet<ShipmentInquiryDetails>();
        }

        public int Id { get; set; }

        public long OrderId { get; set; }

        public int PhaseId { get; set; }

        public int SellerId { get; set; }

        public int ProductId { get; set; }

        public int PackageCount { get; set; }

        public long OrderPrice { get; set; }

        public byte RowStatusId { get; set; }

        [Required]
        [StringLength(20)]
        public string UserIPAddress { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public int UnitPrice { get; set; }

        public int PackageSize { get; set; }

        public int? TaxPrice { get; set; }

        public int? ShipmentCost { get; set; }

        public int? SupervisionCost { get; set; }

        public virtual Phases Phases { get; set; }

        public virtual Orders Orders { get; set; }

        public virtual Products Products { get; set; }

        public virtual Sellers Sellers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductRates> ProductRates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SellerRates> SellerRates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipmentInfoDetails> ShipmentInfoDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipmentInquiryDetails> ShipmentInquiryDetails { get; set; }
    }
}
