namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.BuyerCookingTypes")]
    public partial class BuyerCookingTypes
    {
        public int Id { get; set; }

        public int BuyerId { get; set; }

        public int CookingTypeId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual Buyers Buyers { get; set; }
    }
}
