namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nanino.NaninoBuyerCookingTypes")]
    public partial class NaninoBuyerCookingTypes
    {
        public int Id { get; set; }

        public int? NaninoBuyerId { get; set; }

        public int? NaninoCookingTypeId { get; set; }

        public DateTime? LastModifyDate { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? PatWeight { get; set; }

        public decimal? ConvertRatio { get; set; }

        public virtual NaninoBuyers NaninoBuyers { get; set; }

        public virtual NaninoCookingTypes NaninoCookingTypes { get; set; }
    }
}
