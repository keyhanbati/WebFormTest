namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.CountryDivisionsFlat")]
    public partial class CountryDivisionsFlat
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public int CountryDivisionTypeId { get; set; }

        [Required]
        [StringLength(100)]
        public string Code { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? GeneretedProvianceId { get; set; }

        [StringLength(100)]
        public string GeneretedProvianceCode { get; set; }

        public string GeneretedProvianceTilte { get; set; }

        public int? GeneretedCountyId { get; set; }

        [StringLength(100)]
        public string GeneretedCountyCode { get; set; }

        public string GeneretedCountyTitle { get; set; }

        public int? GeneretedRuralId { get; set; }

        [StringLength(100)]
        public string GeneretedRuralCode { get; set; }

        public string GeneretedRuralTitle { get; set; }

        public int? GeneretedCityId { get; set; }

        [StringLength(100)]
        public string GeneretedCityCode { get; set; }

        public string GeneretedCityTitle { get; set; }

        public int? GeneretedVillageId { get; set; }

        [StringLength(100)]
        public string GeneretedVillageCode { get; set; }

        public string GeneretedVillageTitle { get; set; }
    }
}
