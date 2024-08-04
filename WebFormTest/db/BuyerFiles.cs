namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.BuyerFiles")]
    public partial class BuyerFiles
    {
        public int Id { get; set; }

        public byte Code { get; set; }

        public int BuyerId { get; set; }

        public int DocumentTypeId { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
