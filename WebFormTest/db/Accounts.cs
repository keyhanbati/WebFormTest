namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("acc.Accounts")]
    public partial class Accounts
    {
        public int Id { get; set; }

        public int ReferenceId { get; set; }

        public int ReferenceType { get; set; }

        public int? PersonId { get; set; }

        [Required]
        [StringLength(11)]
        public string NationalCode { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountNumber { get; set; }

        public int AccountTypeId { get; set; }

        [Required]
        [StringLength(500)]
        public string AccountTypeTitle { get; set; }

        [Required]
        [StringLength(50)]
        public string BranchCode { get; set; }

        [Required]
        [StringLength(2000)]
        public string FullName { get; set; }

        public bool IsShared { get; set; }

        public decimal OwnerPercent { get; set; }

        public int InquirySource { get; set; }

        public int OwnerCount { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
