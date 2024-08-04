namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.BasicInformationDetails")]
    public partial class BasicInformationDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BasicInformationDetails()
        {
            BasicInformationDetails1 = new HashSet<BasicInformationDetails>();
            QuotaPhaseConfiguration = new HashSet<QuotaPhaseConfiguration>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int BaseInfoId { get; set; }

        public int? ParentId { get; set; }

        public int Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Coding { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BasicInformationDetails> BasicInformationDetails1 { get; set; }

        public virtual BasicInformationDetails BasicInformationDetails2 { get; set; }

        public virtual BasicInformations BasicInformations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuotaPhaseConfiguration> QuotaPhaseConfiguration { get; set; }
    }
}
