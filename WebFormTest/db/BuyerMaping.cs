namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.BuyerMaping")]
    public partial class BuyerMaping
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BuyerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string BuyerCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string BuyerTitle { get; set; }

        public int? EntityId { get; set; }

        [StringLength(500)]
        public string EntityName { get; set; }

        public long? BakerId { get; set; }

        public long? BakeryId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(201)]
        public string BakerName { get; set; }
    }
}
