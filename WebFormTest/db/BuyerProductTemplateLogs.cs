namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.BuyerProductTemplateLogs")]
    public partial class BuyerProductTemplateLogs
    {
        public int Id { get; set; }

        public int BuyerId { get; set; }

        public int ProductTemplateId { get; set; }

        [StringLength(200)]
        public string Comment { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
