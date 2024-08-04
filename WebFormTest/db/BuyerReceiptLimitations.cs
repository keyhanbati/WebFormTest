namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Limit.BuyerReceiptLimitations")]
    public partial class BuyerReceiptLimitations
    {
        public int Id { get; set; }

        public int BuyerProvinceId { get; set; }

        public int? BuyerId { get; set; }

        public int ReceiptTypeId { get; set; }

        public int PermitStatusId { get; set; }

        public string Comments { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? BuyerCountyId { get; set; }

        public virtual CountryDivisions CountryDivisions { get; set; }

        public virtual Buyers Buyers { get; set; }
    }
}
