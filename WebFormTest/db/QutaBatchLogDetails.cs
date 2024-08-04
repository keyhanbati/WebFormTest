namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Quota.QutaBatchLogDetails")]
    public partial class QutaBatchLogDetails
    {
        public long Id { get; set; }

        public long QutaBatchLogId { get; set; }

        public long SourceQuotaId { get; set; }

        public long DestinationQuotaId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual Quotations Quotations { get; set; }

        public virtual Quotations Quotations1 { get; set; }

        public virtual QutaBatchLogs QutaBatchLogs { get; set; }
    }
}
