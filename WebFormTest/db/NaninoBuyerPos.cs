namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nanino.NaninoBuyerPos")]
    public partial class NaninoBuyerPos
    {
        public int Id { get; set; }

        public int? NaninoBuyerId { get; set; }

        [Required]
        [StringLength(50)]
        public string TerminalNo { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountNumber { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? MainInstallDate { get; set; }

        public byte? TerminalStatusId { get; set; }

        public virtual NaninoBuyers NaninoBuyers { get; set; }
    }
}
