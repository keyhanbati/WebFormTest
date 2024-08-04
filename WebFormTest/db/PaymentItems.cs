namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pay.PaymentItems")]
    public partial class PaymentItems
    {
        public int Id { get; set; }

        public int PaymentId { get; set; }

        public int PaymentItemTypeId { get; set; }

        [Required]
        [StringLength(13)]
        public string SourceAccountNumber { get; set; }

        [Required]
        [StringLength(500)]
        public string SourceComment { get; set; }

        public long Amount { get; set; }

        [Required]
        [StringLength(13)]
        public string DestinationAccountNumber { get; set; }

        [Required]
        [StringLength(500)]
        public string DestinationComment { get; set; }

        [Required]
        [StringLength(20)]
        public string UserIPAddress { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual Payments Payments { get; set; }
    }
}
