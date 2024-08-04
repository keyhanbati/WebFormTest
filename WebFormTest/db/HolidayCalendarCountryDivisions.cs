namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.HolidayCalendarCountryDivisions")]
    public partial class HolidayCalendarCountryDivisions
    {
        public int Id { get; set; }

        public int HolidayCalendarId { get; set; }

        public int CountryDivisionId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual CountryDivisions CountryDivisions { get; set; }

        public virtual HolidayCalendars HolidayCalendars { get; set; }
    }
}
