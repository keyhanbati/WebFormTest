namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.HolidayCalendars")]
    public partial class HolidayCalendars
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HolidayCalendars()
        {
            HolidayCalendarCountryDivisions = new HashSet<HolidayCalendarCountryDivisions>();
        }

        public int Id { get; set; }

        public int CalenderTypeId { get; set; }

        public int HolidayTypeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime HolidayDate { get; set; }

        public short SolarYear { get; set; }

        [Required]
        [StringLength(500)]
        public string Comments { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HolidayCalendarCountryDivisions> HolidayCalendarCountryDivisions { get; set; }
    }
}
