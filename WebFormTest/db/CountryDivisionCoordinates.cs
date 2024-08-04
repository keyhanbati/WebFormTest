namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.CountryDivisionCoordinates")]
    public partial class CountryDivisionCoordinates
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CountryDivisionId { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        [StringLength(50)]
        public string HCKey { get; set; }

        [StringLength(150)]
        public string Name { get; set; }
    }
}
