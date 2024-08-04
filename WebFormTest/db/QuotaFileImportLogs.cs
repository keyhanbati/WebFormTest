namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Quota.QuotaFileImportLogs")]
    public partial class QuotaFileImportLogs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuotaFileImportLogs()
        {
            QuotaFileImportLogMessages = new HashSet<QuotaFileImportLogMessages>();
        }

        public long Id { get; set; }

        public int IntervalId { get; set; }

        public int ProvinceId { get; set; }

        public int AllRecordCount { get; set; }

        public int QuotaTransferReplacementTypeId { get; set; }

        public int QuotaFileTypeId { get; set; }

        public int ActivityStatusId { get; set; }

        [Required]
        [StringLength(20)]
        public string UserIPAddress { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? ApplyTypeId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuotaFileImportLogMessages> QuotaFileImportLogMessages { get; set; }
    }
}
