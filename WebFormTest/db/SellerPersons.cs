namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Seller.SellerPersons")]
    public partial class SellerPersons
    {
        public int Id { get; set; }

        public int SellerId { get; set; }

        public int PersonId { get; set; }

        public int SellerPersonTypeId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual Persons Persons { get; set; }

        public virtual Sellers Sellers { get; set; }
    }
}
