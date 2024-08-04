namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipping.Cars")]
    public partial class Cars
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cars()
        {
            DriverCarTransportationCompanies = new HashSet<DriverCarTransportationCompanies>();
        }

        public int Id { get; set; }

        public int? Code { get; set; }

        public int? ShipmentPlatformTypeId { get; set; }

        public int? CarTypeId { get; set; }

        public byte? CarPlateNumber1 { get; set; }

        [StringLength(10)]
        public string CarPlateNumber2 { get; set; }

        public int? CarPlateNumber3 { get; set; }

        public byte? CarPlateNumber4 { get; set; }

        [StringLength(50)]
        public string CarPlateNumber { get; set; }

        public byte RowStatusId { get; set; }

        public DateTime? ModifyDate { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DriverCarTransportationCompanies> DriverCarTransportationCompanies { get; set; }
    }
}
