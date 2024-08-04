namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vwBuyerInfo")]
    public partial class vwBuyerInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BuyerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string BuyerCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string BuyerTitle { get; set; }

        [StringLength(200)]
        public string BuyerTypeTitle { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BuyerTypeId { get; set; }

        public int? GeneretedCountyId { get; set; }

        [StringLength(100)]
        public string GeneretedCountyCode { get; set; }

        public string GeneretedCountyTitle { get; set; }

        public int? GeneretedProvianceId { get; set; }

        [StringLength(100)]
        public string GeneretedProvianceCode { get; set; }

        public string GeneretedProvianceTilte { get; set; }

        [StringLength(100)]
        public string GeneretedCityCode { get; set; }

        public string GeneretedCityTitle { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BuyerStatusId { get; set; }

        public int? FirstQuota { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NoInternetAccess { get; set; }

        public string BuyerCookingTypes { get; set; }
    }
}
