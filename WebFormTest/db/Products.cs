namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product.Products")]
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            ProductInventories = new HashSet<ProductInventories>();
            OrderItems = new HashSet<OrderItems>();
            ProductDetails = new HashSet<ProductDetails>();
            ProductRates = new HashSet<ProductRates>();
            SellerProducts = new HashSet<SellerProducts>();
        }

        public int Id { get; set; }

        public int Code { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        public int ProductTemplateId { get; set; }

        public int BranPercentageId { get; set; }

        public int PackageId { get; set; }

        public long UnitPrice { get; set; }

        [Required]
        [StringLength(500)]
        public string Comments { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? Temp { get; set; }

        public virtual BranPercentages BranPercentages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductInventories> ProductInventories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItems> OrderItems { get; set; }

        public virtual Packages Packages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductDetails> ProductDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductRates> ProductRates { get; set; }

        public virtual ProductTemplates ProductTemplates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SellerProducts> SellerProducts { get; set; }
    }
}
