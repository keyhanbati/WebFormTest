namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Limit.TransportLimitations")]
    public partial class TransportLimitations
    {
        public int Id { get; set; }

        public int ProvinceBuyerId { get; set; }

        public int? CountyBuyerId { get; set; }

        public int? BuyerId { get; set; }

        public int ProvinceSellerId { get; set; }

        public int? SellerId { get; set; }

        public int? ProvinceCompanyId { get; set; }

        public int TransportationCompanyId { get; set; }

        public int PermitStatusId { get; set; }

        public string Comments { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? IntervalId { get; set; }

        public virtual Intervals Intervals { get; set; }

        public virtual Buyers Buyers { get; set; }

        public virtual Sellers Sellers { get; set; }

        public virtual TransportationCompanies TransportationCompanies { get; set; }
    }
}
