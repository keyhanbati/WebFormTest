namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.BuyerInfoCorrections")]
    public partial class BuyerInfoCorrections
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BuyerInfoCorrections()
        {
            BuyerInfoCorrectionStatuses = new HashSet<BuyerInfoCorrectionStatuses>();
        }

        public int Id { get; set; }

        public int BuyerId { get; set; }

        public int BuyerCode { get; set; }

        public int? Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }

        [StringLength(13)]
        public string NationalCode { get; set; }

        [StringLength(14)]
        public string MobileNo { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(50)]
        public string ISICCoding { get; set; }

        [StringLength(11)]
        public string BakeryProducerCode { get; set; }

        [StringLength(30)]
        public string BusinessLicense { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        [StringLength(500)]
        public string AdminComment { get; set; }

        public DateTime CreateDate { get; set; }

        public int CreateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public virtual Buyers Buyers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerInfoCorrectionStatuses> BuyerInfoCorrectionStatuses { get; set; }
    }
}
