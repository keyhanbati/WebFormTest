namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.BuyerSubCountryDivisionIds")]
    public partial class BuyerSubCountryDivisionIds
    {
        public int Id { get; set; }

        public int BuyerId { get; set; }

        public int CountryDivisionId { get; set; }

        public byte? RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public virtual CountryDivisions CountryDivisions { get; set; }

        public virtual Buyers Buyers { get; set; }
    }
}
