namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.vmGenerateCountryDivisionFlat")]
    public partial class vmGenerateCountryDivisionFlat
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

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GeneretedProvianceId { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(100)]
        public string GeneretedProvianceCode { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(150)]
        public string GeneretedProvianceTilte { get; set; }

        public int? GeneretedCountyId { get; set; }

        [StringLength(100)]
        public string GeneretedCountyCode { get; set; }

        [StringLength(150)]
        public string GeneretedCountyTitle { get; set; }

        public int? GeneretedCityId { get; set; }

        [StringLength(100)]
        public string GeneretedCityCode { get; set; }

        [StringLength(150)]
        public string GeneretedCityTitle { get; set; }

        public int? GeneretedRuralId { get; set; }

        [StringLength(100)]
        public string GeneretedRuralCode { get; set; }

        [StringLength(150)]
        public string GeneretedRuralTitle { get; set; }

        public int? GeneretedVillageId { get; set; }

        [StringLength(100)]
        public string GeneretedVillageCode { get; set; }

        [StringLength(150)]
        public string GeneretedVillageTitle { get; set; }
    }
}
