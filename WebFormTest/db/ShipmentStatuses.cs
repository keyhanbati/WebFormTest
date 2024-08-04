namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipping.ShipmentStatuses")]
    public partial class ShipmentStatuses
    {
        public int Id { get; set; }

        public int ShipmentId { get; set; }

        public int ShipmentStatusTypeId { get; set; }

        public bool IsLast { get; set; }

        public DateTime StatusChangeDate { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual Shipments Shipments { get; set; }
    }
}
