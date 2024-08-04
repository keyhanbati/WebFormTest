namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Population_Amar
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Code { get; set; }

        [StringLength(255)]
        public string Province_Code { get; set; }

        [StringLength(255)]
        public string Province_Name { get; set; }

        [StringLength(255)]
        public string County_Code { get; set; }

        [StringLength(255)]
        public string County_Name { get; set; }

        [StringLength(255)]
        public string District_Code { get; set; }

        [StringLength(255)]
        public string District_Name { get; set; }

        [StringLength(255)]
        public string RuralDistrict_City_Code { get; set; }

        [StringLength(255)]
        public string RuralDistrict_City_Name { get; set; }

        [StringLength(255)]
        public string Area_Number { get; set; }

        [StringLength(255)]
        public string Village_Code { get; set; }

        [StringLength(255)]
        public string Village_Name { get; set; }

        [StringLength(255)]
        public string RecordType_Code { get; set; }

        [StringLength(255)]
        public string ShahrTop { get; set; }

        [StringLength(255)]
        public string SwDiv { get; set; }

        [StringLength(255)]
        public string NumberOfHouseholds { get; set; }

        [StringLength(255)]
        public string Population { get; set; }

        [StringLength(255)]
        public string Population_Men { get; set; }

        [StringLength(255)]
        public string Population_Women { get; set; }
    }
}
