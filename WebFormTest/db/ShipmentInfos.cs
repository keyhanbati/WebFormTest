namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipping.ShipmentInfos")]
    public partial class ShipmentInfos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShipmentInfos()
        {
            ShipmentInfoDetails = new HashSet<ShipmentInfoDetails>();
            ShipmentInfoStatuses = new HashSet<ShipmentInfoStatuses>();
        }

        public int Id { get; set; }

        public int ShipmentId { get; set; }

        public int? DriverCarId { get; set; }

        public DateTime CreateDate { get; set; }

        public int CreateUserId { get; set; }

        public int? ShipmentPackageCount { get; set; }

        public int? DriverCarTransportationCompanyId { get; set; }

        public int? ShipmentPackageAmount { get; set; }

        public int? Code { get; set; }

        public Guid? UniqueId { get; set; }

        public virtual DriverCars DriverCars { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipmentInfoDetails> ShipmentInfoDetails { get; set; }

        public virtual Shipments Shipments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipmentInfoStatuses> ShipmentInfoStatuses { get; set; }
    }
}
