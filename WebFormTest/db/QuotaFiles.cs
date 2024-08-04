namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Temp.QuotaFiles")]
    public partial class QuotaFiles
    {
        public int Id { get; set; }

        public long? LogFileId { get; set; }

        public int? RowNumber { get; set; }

        public int? Interval { get; set; }

        public int? Phase { get; set; }

        public int? ProductTemplate { get; set; }

        public int? Bran { get; set; }

        public int? Province { get; set; }

        public int? County { get; set; }

        public int? SellerCode { get; set; }

        public int? BuyerCode { get; set; }

        public long? QuotaAmount { get; set; }
    }
}
