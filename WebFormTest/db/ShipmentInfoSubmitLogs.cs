namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShipmentPlatform.ShipmentInfoSubmitLogs")]
    public partial class ShipmentInfoSubmitLogs
    {
        public int Id { get; set; }

        public int? ShipmentInfoId { get; set; }

        public int StatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
