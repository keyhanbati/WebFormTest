namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product.SalesPlans")]
    public partial class SalesPlans
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesPlans()
        {
            SalePlanInstallments = new HashSet<SalePlanInstallments>();
        }

        public int Id { get; set; }

        public int SellerProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public long UnitPrice { get; set; }

        [StringLength(500)]
        public string Comments { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalePlanInstallments> SalePlanInstallments { get; set; }

        public virtual SellerProducts SellerProducts { get; set; }
    }
}
