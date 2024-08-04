namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.RawFlourDetails")]
    public partial class RawFlourDetails
    {
        public long Id { get; set; }

        public long RawFlourDetailFileImportLogId { get; set; }

        [Required]
        [StringLength(100)]
        public string DivisionTitle { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(11)]
        public string NationalCode { get; set; }

        [Required]
        [StringLength(11)]
        public string Mobile { get; set; }

        public int FamilyMemberCount { get; set; }

        public long ReceivedAmount { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
