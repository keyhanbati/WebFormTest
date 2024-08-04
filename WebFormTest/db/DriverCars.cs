namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipping.DriverCars")]
    public partial class DriverCars
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DriverCars()
        {
            ShipmentInfos = new HashSet<ShipmentInfos>();
            Shipments = new HashSet<Shipments>();
        }

        public int Id { get; set; }

        public int DriverId { get; set; }

        public int CarTypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string CarPlateNumber { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? CarPlateNumber1 { get; set; }

        [StringLength(50)]
        public string CarPlateNumber2 { get; set; }

        public int? CarPlateNumber3 { get; set; }

        public int? CarPlateNumber4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipmentInfos> ShipmentInfos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shipments> Shipments { get; set; }
    }
}
