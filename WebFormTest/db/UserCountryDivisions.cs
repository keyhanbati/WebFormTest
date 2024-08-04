namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Security.UserCountryDivisions")]
    public partial class UserCountryDivisions
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int CountryDivisionId { get; set; }

        public bool IsDeleted { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual CountryDivisions CountryDivisions { get; set; }
    }
}
