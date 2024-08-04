namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.Phases")]
    public partial class Phases
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phases()
        {
            PhaseProductTemplates = new HashSet<PhaseProductTemplates>();
            OrderItems = new HashSet<OrderItems>();
            RawFlourDetailFileImportLogs = new HashSet<RawFlourDetailFileImportLogs>();
        }

        public int Id { get; set; }

        public int Code { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        public int IntervalId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int CountryDivisionId { get; set; }

        public bool RemainingMustTransferred { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int PhasesStatusId { get; set; }

        public int? Sort { get; set; }

        public virtual CountryDivisions CountryDivisions { get; set; }

        public virtual Intervals Intervals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhaseProductTemplates> PhaseProductTemplates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItems> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RawFlourDetailFileImportLogs> RawFlourDetailFileImportLogs { get; set; }
    }
}
