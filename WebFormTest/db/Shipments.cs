namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipping.Shipments")]
    public partial class Shipments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shipments()
        {
            ShipmentInfos = new HashSet<ShipmentInfos>();
            ShipmentInquiries = new HashSet<ShipmentInquiries>();
            ShipmentStatuses = new HashSet<ShipmentStatuses>();
        }

        public int Id { get; set; }

        public long OrderId { get; set; }

        public int TransportTypeId { get; set; }

        [Required]
        [StringLength(250)]
        public string RecipientName { get; set; }

        [Required]
        [StringLength(500)]
        public string RecipientAddress { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public int ShipmentPlatformTypeId { get; set; }

        public int? DriverCarId { get; set; }

        public int? ConfirmationCode { get; set; }

        public virtual Orders Orders { get; set; }

        public virtual DriverCars DriverCars { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipmentInfos> ShipmentInfos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipmentInquiries> ShipmentInquiries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipmentStatuses> ShipmentStatuses { get; set; }
    }
}
