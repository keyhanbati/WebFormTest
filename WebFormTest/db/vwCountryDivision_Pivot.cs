namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.vwCountryDivision_Pivot")]
    public partial class vwCountryDivision_Pivot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? VillageId { get; set; }

        public int? CityId { get; set; }

        public int? RuralId { get; set; }

        public int? CountyId { get; set; }

        public int? ProvinceId { get; set; }
    }
}
