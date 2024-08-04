namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipping.ShipmentInfoDetails")]
    public partial class ShipmentInfoDetails
    {
        public int Id { get; set; }

        public int ShipmentInfoId { get; set; }

        public int OrderItemId { get; set; }

        public int ShipmentPackageItemCount { get; set; }

        public int ShipmentPackageItemAmount { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        [StringLength(20)]
        public string BatchNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ProductCreateDate { get; set; }

        public virtual OrderItems OrderItems { get; set; }

        public virtual ShipmentInfos ShipmentInfos { get; set; }
    }
}
