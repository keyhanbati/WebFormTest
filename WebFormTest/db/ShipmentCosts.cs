namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipping.ShipmentCosts")]
    public partial class ShipmentCosts
    {
        public int Id { get; set; }

        public int ProductTemplateId { get; set; }

        public int? BuyerTypeId { get; set; }

        public int BuyerProvinceId { get; set; }

        public int? BuyerCountyId { get; set; }

        public int SellerProvinceId { get; set; }

        public int? SellerId { get; set; }

        public int TransportationCompanyId { get; set; }

        public int MeasurementUnitTypeId { get; set; }

        public long ShippingUnitPrice { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public int? BuyerCityId { get; set; }

        public int? BuyerRuralId { get; set; }

        public int? BuyerVillageId { get; set; }

        [StringLength(1000)]
        public string Comments { get; set; }

        public virtual CountryDivisions CountryDivisions { get; set; }

        public virtual CountryDivisions CountryDivisions1 { get; set; }

        public virtual CountryDivisions CountryDivisions2 { get; set; }

        public virtual ProductTemplates ProductTemplates { get; set; }

        public virtual Sellers Sellers { get; set; }

        public virtual TransportationCompanies TransportationCompanies { get; set; }
    }
}
