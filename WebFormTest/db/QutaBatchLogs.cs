namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Quota.QutaBatchLogs")]
    public partial class QutaBatchLogs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QutaBatchLogs()
        {
            QutaBatchLogDetails = new HashSet<QutaBatchLogDetails>();
        }

        public long Id { get; set; }

        public int SourceIntervalId { get; set; }

        public int? SourceProvinceId { get; set; }

        public int? SourceCountyId { get; set; }

        public int? SourcePhaseId { get; set; }

        public int DestinationIntervalId { get; set; }

        public int? DestinationPhaseId { get; set; }

        public bool TransferSellersQuota { get; set; }

        public bool TransferBuyersQuota { get; set; }

        public int QuotaTransferReplacementTypeId { get; set; }

        public int ActivityStatusId { get; set; }

        [Required]
        [StringLength(20)]
        public string UserIPAddress { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QutaBatchLogDetails> QutaBatchLogDetails { get; set; }
    }
}
