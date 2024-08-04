namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Limit.TaxLimitations")]
    public partial class TaxLimitations
    {
        public int Id { get; set; }

        public int BuyerTypeId { get; set; }

        public int? BuyerSubTypeId { get; set; }

        public int TaxPermitId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? UpdateUserId { get; set; }
    }
}
