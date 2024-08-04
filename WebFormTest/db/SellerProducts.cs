namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Seller.SellerProducts")]
    public partial class SellerProducts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SellerProducts()
        {
            SalesPlans = new HashSet<SalesPlans>();
        }

        public int Id { get; set; }

        public int? CountryDivisionId { get; set; }

        public int ProductTemplateId { get; set; }

        public int? SellerId { get; set; }

        public int ProductId { get; set; }

        public int RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual Products Products { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesPlans> SalesPlans { get; set; }

        public virtual Sellers Sellers { get; set; }
    }
}
