namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vwCountryDivisions
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? ParentId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CountryDivisionTypeId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string Code { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(150)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte RowStatusId { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreateUserId { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? GeneretedProvianceId { get; set; }

        public int? GeneretedProvianceCode { get; set; }

        public string GeneretedProvianceTilte { get; set; }

        public int? GeneretedCountyId { get; set; }

        public int? GeneretedCountyCode { get; set; }

        public string GeneretedCountyTitle { get; set; }

        public int? GeneretedRuralId { get; set; }

        public long? GeneretedRuralCode { get; set; }

        public string GeneretedRuralTitle { get; set; }

        public int? GeneretedCityId { get; set; }

        public long? GeneretedCityCode { get; set; }

        public string GeneretedCityTitle { get; set; }

        public int? GeneretedVillageId { get; set; }

        public long? GeneretedVillageCode { get; set; }

        public string GeneretedVillageTitle { get; set; }
    }
}
