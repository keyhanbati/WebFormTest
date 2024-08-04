namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.BuyerInfoCorrectionStatuses")]
    public partial class BuyerInfoCorrectionStatuses
    {
        public int Id { get; set; }

        public int BuyerInfoCorrectionId { get; set; }

        public int StatusId { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public bool IsLast { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual BuyerInfoCorrections BuyerInfoCorrections { get; set; }
    }
}
