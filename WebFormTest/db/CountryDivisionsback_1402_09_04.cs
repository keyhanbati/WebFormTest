namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.CountryDivisionsback_1402_09_04")]
    public partial class CountryDivisionsback_1402_09_04
    {
        [Key]
        [Column(Order = 0)]
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
    }
}
