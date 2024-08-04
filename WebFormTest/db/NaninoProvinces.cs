namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nanino.NaninoProvinces")]
    public partial class NaninoProvinces
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ProvinceCode { get; set; }

        [StringLength(50)]
        public string ProvinceName { get; set; }

        public int? ProvinceId { get; set; }

        public int RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
