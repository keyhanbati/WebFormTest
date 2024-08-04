namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipping.ShipmentInfoStatuses")]
    public partial class ShipmentInfoStatuses
    {
        public int Id { get; set; }

        public int ShipmentInfoId { get; set; }

        public int ShipmentInfoStatusTypeId { get; set; }

        public bool IsLast { get; set; }

        public DateTime StatusChangeDate { get; set; }

        public DateTime CreateDate { get; set; }

        public int CreateUserId { get; set; }

        public virtual ShipmentInfos ShipmentInfos { get; set; }
    }
}
