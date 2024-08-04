namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pay.PaymentTokenStatuses")]
    public partial class PaymentTokenStatuses
    {
        public long Id { get; set; }

        public int PaymentTokenId { get; set; }

        public int? TransferResultCode { get; set; }

        public bool IsLast { get; set; }

        [Required]
        [StringLength(20)]
        public string UserIPAddress { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual PaymentToken PaymentToken { get; set; }
    }
}
