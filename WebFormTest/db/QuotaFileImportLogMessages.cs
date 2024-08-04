namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Quota.QuotaFileImportLogMessages")]
    public partial class QuotaFileImportLogMessages
    {
        public long Id { get; set; }

        public long QuotaFileImportLogId { get; set; }

        public int LogDetailTypeId { get; set; }

        public int? RowNumber { get; set; }

        [StringLength(500)]
        public string RowData { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual QuotaFileImportLogs QuotaFileImportLogs { get; set; }
    }
}
