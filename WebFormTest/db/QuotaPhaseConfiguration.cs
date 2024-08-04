namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.QuotaPhaseConfiguration")]
    public partial class QuotaPhaseConfiguration
    {
        public int Id { get; set; }

        public int ProvinceId { get; set; }

        public int BuyerTypeId { get; set; }

        public int QuotaPhaseConfigurationTypeId { get; set; }

        public decimal QuotaPhaseConfigurationTypeValue { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual BasicInformationDetails BasicInformationDetails { get; set; }

        public virtual CountryDivisions CountryDivisions { get; set; }
    }
}
