namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.BuyerFacilities")]
    public partial class BuyerFacilities
    {
        public long Id { get; set; }

        public int BuyerId { get; set; }

        public int FacilityId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual Buyers Buyers { get; set; }
    }
}
