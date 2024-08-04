namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.BuyerScores")]
    public partial class BuyerScores
    {
        public long Id { get; set; }

        public int BuyerId { get; set; }

        public decimal? InspectionScore { get; set; }

        public decimal? PeoplesScore { get; set; }

        public decimal? FunctionalScore { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual Buyers Buyers { get; set; }
    }
}
