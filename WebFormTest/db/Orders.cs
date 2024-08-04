namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.Orders")]
    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            ProductInventories = new HashSet<ProductInventories>();
            OrderItems = new HashSet<OrderItems>();
            Shipments = new HashSet<Shipments>();
            OrderStatuses = new HashSet<OrderStatuses>();
            Payments = new HashSet<Payments>();
        }

        public long Id { get; set; }

        public int IntervalId { get; set; }

        public int BuyerId { get; set; }

        public long OrderCode { get; set; }

        public DateTime? OrderPreparationDate { get; set; }

        public long OrderPrice { get; set; }

        public long TaxPrice { get; set; }

        public long ShipmentCost { get; set; }

        public DateTime LockExpirationDate { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public long SupervisionCost { get; set; }

        public DateTime? LockPaymentDate { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? OrderTypeId { get; set; }

        public int? SalePlanId { get; set; }

        public virtual Intervals Intervals { get; set; }

        public virtual Buyers Buyers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductInventories> ProductInventories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItems> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shipments> Shipments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderStatuses> OrderStatuses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payments> Payments { get; set; }
    }
}
