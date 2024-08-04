namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.BuyerCookingSubTypes")]
    public partial class BuyerCookingSubTypes
    {
        public int Id { get; set; }

        public int BuyerCookingTypeId { get; set; }

        public int CookingSubTypeId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
