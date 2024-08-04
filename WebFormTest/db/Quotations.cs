namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Quota.Quotations")]
    public partial class Quotations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Quotations()
        {
            QutaBatchLogDetails = new HashSet<QutaBatchLogDetails>();
            QutaBatchLogDetails1 = new HashSet<QutaBatchLogDetails>();
        }

        public long Id { get; set; }

        public int QuotaType { get; set; }

        public int IntervalId { get; set; }

        public int? ProductTemplateId { get; set; }

        public int? PhaseId { get; set; }

        public int? BranPercentageId { get; set; }

        public int? ProvinceId { get; set; }

        public int? CountyId { get; set; }

        public int? SellerId { get; set; }

        public int? BuyerId { get; set; }

        public byte RowStatusId { get; set; }

        public DateTime CreateDate { get; set; }

        public int CreateUserId { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public long? FlourSaleAmount { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public long? CalculatedQuotaBySale { get; set; }

        public long? QuotaPercentage { get; set; }

        public long? UpgradeQuota { get; set; }

        public long? CalculatedUpgradeQuota { get; set; }

        public long? AddedQuota { get; set; }

        public int? BuyerPerformanceGroupId { get; set; }

        public decimal? InspectionScore { get; set; }

        public decimal? PeoplesScore { get; set; }

        public decimal? FunctionalScore { get; set; }

        [StringLength(50)]
        public string MessageIds { get; set; }

        public long? NonBakeryQuotaAmount { get; set; }

        public long? SpecialQuotaAmount { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public long? QuotaAmount { get; set; }

        public long IntervalCalculatedUpgradeQuota { get; set; }

        public DateTime? SpecialQuotaAmountCreateDate { get; set; }

        public DateTime? SpecialQuotaAmountUpdateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QutaBatchLogDetails> QutaBatchLogDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QutaBatchLogDetails> QutaBatchLogDetails1 { get; set; }
    }
}
