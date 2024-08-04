namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Limit.Yeast")]
    public partial class Yeast
    {
        public int Id { get; set; }

        public int BuyerProvinceId { get; set; }

        public int? BuyerCountyId { get; set; }

        public int ProductTemplateId { get; set; }

        public int SubCookingTypeId { get; set; }

        public decimal Amount { get; set; }

        public int PermitStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual CountryDivisions CountryDivisions { get; set; }

        public virtual CountryDivisions CountryDivisions1 { get; set; }
    }
}
