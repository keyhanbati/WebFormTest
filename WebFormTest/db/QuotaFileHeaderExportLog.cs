namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log.QuotaFileHeaderExportLog")]
    public partial class QuotaFileHeaderExportLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuotaFileHeaderExportLog()
        {
            QuotaFileDetailsExportLog = new HashSet<QuotaFileDetailsExportLog>();
        }

        public int ID { get; set; }

        public int IntervalId { get; set; }

        public int ProvinceId { get; set; }

        [Required]
        [StringLength(500)]
        public string Comment { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuotaFileDetailsExportLog> QuotaFileDetailsExportLog { get; set; }
    }
}
