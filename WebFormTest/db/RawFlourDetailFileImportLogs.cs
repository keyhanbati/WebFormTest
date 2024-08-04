namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.RawFlourDetailFileImportLogs")]
    public partial class RawFlourDetailFileImportLogs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RawFlourDetailFileImportLogs()
        {
            RawFlourDetailImportLogMessages = new HashSet<RawFlourDetailImportLogMessages>();
        }

        public long Id { get; set; }

        public int PhaseId { get; set; }

        public int BuyerId { get; set; }

        public int CountryDivisionId { get; set; }

        public int AllRecordCount { get; set; }

        public int FileTransferReplacementTypeId { get; set; }

        public int ActivityStatusId { get; set; }

        [Required]
        [StringLength(20)]
        public string UserIPAddress { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? ProductTemplateId { get; set; }

        public virtual Phases Phases { get; set; }

        public virtual Buyers Buyers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RawFlourDetailImportLogMessages> RawFlourDetailImportLogMessages { get; set; }
    }
}
