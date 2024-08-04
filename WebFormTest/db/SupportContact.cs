namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.SupportContact")]
    public partial class SupportContact
    {
        public int Id { get; set; }

        public int SupportContactTypeId { get; set; }

        public int RefrenceId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(100)]
        public string Mobile { get; set; }

        [StringLength(100)]
        public string Tel { get; set; }

        public short RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
