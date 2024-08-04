namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inv.WheatInventories")]
    public partial class WheatInventories
    {
        public int Id { get; set; }

        public int IntervalId { get; set; }

        public int? ProductInventoryId { get; set; }

        public int SellerId { get; set; }

        public int UseTypeId { get; set; }

        public int ProductTypeId { get; set; }

        public int WheatInvTransactionTypeId { get; set; }

        public long Amount { get; set; }

        public long TotalRemain { get; set; }

        public int? WheatImportInfoId { get; set; }

        public bool IsLast { get; set; }

        public DateTime? LicenseDate { get; set; }

        [StringLength(50)]
        public string LicenseCode { get; set; }

        public string Description { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
