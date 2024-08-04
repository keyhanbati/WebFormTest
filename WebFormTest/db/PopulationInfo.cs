namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.PopulationInfo")]
    public partial class PopulationInfo
    {
        public int Id { get; set; }

        public int CountryDivisionId { get; set; }

        public long MenCounted { get; set; }

        public long WomenCounted { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public long? StatisticsCounted { get; set; }

        public long? HouseholdsNumber { get; set; }

        public short StatisticsYear { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual CountryDivisions CountryDivisions { get; set; }
    }
}
