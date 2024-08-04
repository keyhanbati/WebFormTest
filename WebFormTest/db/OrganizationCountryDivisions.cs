namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.OrganizationCountryDivisions")]
    public partial class OrganizationCountryDivisions
    {
        public long Id { get; set; }

        public int OrganizationId { get; set; }

        public int CountryDivisionId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual CountryDivisions CountryDivisions { get; set; }

        public virtual Organizations Organizations { get; set; }
    }
}
