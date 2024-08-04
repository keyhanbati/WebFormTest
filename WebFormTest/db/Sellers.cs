namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Seller.Sellers")]
    public partial class Sellers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sellers()
        {
            Buyers = new HashSet<Buyers>();
            ProductInventories = new HashSet<ProductInventories>();
            DealingLimitations = new HashSet<DealingLimitations>();
            TransportLimitations = new HashSet<TransportLimitations>();
            OrderItems = new HashSet<OrderItems>();
            SellerPersons = new HashSet<SellerPersons>();
            SellerProducts = new HashSet<SellerProducts>();
            SellerProductTemplates = new HashSet<SellerProductTemplates>();
            SellerRates = new HashSet<SellerRates>();
            SellerStatuses = new HashSet<SellerStatuses>();
            SellerSuspensions = new HashSet<SellerSuspensions>();
            SellerTransportTypes = new HashSet<SellerTransportTypes>();
            ShipmentCosts = new HashSet<ShipmentCosts>();
        }

        public int Id { get; set; }

        public int Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public int CountryDivisionId { get; set; }

        [Required]
        [StringLength(14)]
        public string NationalId { get; set; }

        [Required]
        [StringLength(14)]
        public string EconomicCode { get; set; }

        [Required]
        [StringLength(13)]
        public string IntermediateAccount { get; set; }

        [Required]
        [StringLength(13)]
        public string MainAccount { get; set; }

        public long NominalMonthlyCapacity { get; set; }

        [StringLength(11)]
        public string Tel { get; set; }

        [StringLength(11)]
        public string Fax { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        [StringLength(500)]
        public string Comments { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? OfficeCode { get; set; }

        public bool IsCentralOffice { get; set; }

        public long? SellerTypeId { get; set; }

        public int? ParentSellerId { get; set; }

        public virtual CountryDivisions CountryDivisions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buyers> Buyers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductInventories> ProductInventories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DealingLimitations> DealingLimitations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportLimitations> TransportLimitations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItems> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SellerPersons> SellerPersons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SellerProducts> SellerProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SellerProductTemplates> SellerProductTemplates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SellerRates> SellerRates { get; set; }

        public virtual Sellers Sellers1 { get; set; }

        public virtual Sellers Sellers2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SellerStatuses> SellerStatuses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SellerSuspensions> SellerSuspensions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SellerTransportTypes> SellerTransportTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipmentCosts> ShipmentCosts { get; set; }
    }
}
