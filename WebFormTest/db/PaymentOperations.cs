namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pay.PaymentOperations")]
    public partial class PaymentOperations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaymentOperations()
        {
            PaymentOperationDetails = new HashSet<PaymentOperationDetails>();
        }

        public int Id { get; set; }

        public int PaymentId { get; set; }

        [StringLength(1)]
        public string Token { get; set; }

        public int PaymentStepId { get; set; }

        public int PaymentOperationTypeId { get; set; }

        [StringLength(1)]
        public string ServiceUrl { get; set; }

        public bool IsSuccess { get; set; }

        [StringLength(1)]
        public string Message { get; set; }

        public int RsCode { get; set; }

        public int? TransferResultCode { get; set; }

        [StringLength(1)]
        public string RequestBody { get; set; }

        [StringLength(1)]
        public string ResponseBody { get; set; }

        [Required]
        [StringLength(20)]
        public string UserIPAddress { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentOperationDetails> PaymentOperationDetails { get; set; }

        public virtual Payments Payments { get; set; }
    }
}
