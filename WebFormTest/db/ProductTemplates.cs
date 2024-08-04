namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product.ProductTemplates")]
    public partial class ProductTemplates
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductTemplates()
        {
            PhaseProductTemplates = new HashSet<PhaseProductTemplates>();
            BuyerProductTemplates = new HashSet<BuyerProductTemplates>();
            BranPercentageLimitations = new HashSet<BranPercentageLimitations>();
            DealingLimitations = new HashSet<DealingLimitations>();
            Products = new HashSet<Products>();
            ProductTemplateBranPercentages = new HashSet<ProductTemplateBranPercentages>();
            SellerProductTemplates = new HashSet<SellerProductTemplates>();
            ShipmentCosts = new HashSet<ShipmentCosts>();
        }

        public int Id { get; set; }

        public int Code { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        public int ProductCategoryId { get; set; }

        public int SubsidyStatusId { get; set; }

        public int ProductTypeId { get; set; }

        public int UseTypeId { get; set; }

        public int PricingScopeTypeId { get; set; }

        public long MinPrice { get; set; }

        public long MaxPrice { get; set; }

        public int RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public bool UseBranPercentages { get; set; }

        public bool QuotaAllotment { get; set; }

        public long? InstallmentMinPrice { get; set; }

        public long? InstallmentMaxPrice { get; set; }

        public int CalcQuotaFromProductCategoryId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhaseProductTemplates> PhaseProductTemplates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerProductTemplates> BuyerProductTemplates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BranPercentageLimitations> BranPercentageLimitations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DealingLimitations> DealingLimitations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products> Products { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductTemplateBranPercentages> ProductTemplateBranPercentages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SellerProductTemplates> SellerProductTemplates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipmentCosts> ShipmentCosts { get; set; }
    }
}
