namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Limit.DealingLimitations")]
    public partial class DealingLimitations
    {
        public int Id { get; set; }

        public int BuyerProvinceId { get; set; }

        public int? BuyerId { get; set; }

        public int SellerProvinceId { get; set; }

        public int? SellerId { get; set; }

        public int PermitStatusId { get; set; }

        public int ProductTemplateId { get; set; }

        public string Comments { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? BuyerCountyId { get; set; }

        public int? SellerCountyId { get; set; }

        public int? BuyerTypeId { get; set; }

        public int OrderTypeId { get; set; }

        public byte RowStatusId { get; set; }

        public virtual CountryDivisions CountryDivisions { get; set; }

        public virtual CountryDivisions CountryDivisions1 { get; set; }

        public virtual Buyers Buyers { get; set; }

        public virtual Sellers Sellers { get; set; }

        public virtual ProductTemplates ProductTemplates { get; set; }
    }
}
