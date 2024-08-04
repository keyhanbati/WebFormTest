namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pay.PaymentStatuses")]
    public partial class PaymentStatuses
    {
        public int Id { get; set; }

        public int PaymentId { get; set; }

        public int PaymentStatusId { get; set; }

        public int? PaymentTransferResultId { get; set; }

        public bool IsLast { get; set; }

        [Required]
        [StringLength(1000)]
        public string Comments { get; set; }

        [Required]
        [StringLength(20)]
        public string UserIPAddress { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual Payments Payments { get; set; }
    }
}
