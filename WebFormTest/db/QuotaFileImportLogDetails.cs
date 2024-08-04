namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Quota.QuotaFileImportLogDetails")]
    public partial class QuotaFileImportLogDetails
    {
        public long Id { get; set; }

        public long QuotaFileImportLogId { get; set; }

        public long QuotaId { get; set; }
    }
}
