namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pay.PaymentToken")]
    public partial class PaymentToken
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaymentToken()
        {
            PaymentTokenStatuses = new HashSet<PaymentTokenStatuses>();
        }

        public int Id { get; set; }

        public int PaymentId { get; set; }

        [Required]
        [StringLength(100)]
        public string Token { get; set; }

        public bool IsLast { get; set; }

        [Required]
        [StringLength(20)]
        public string CreateUserIPAddress { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        [StringLength(20)]
        public string UpdateUserIPAddress { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual Payments Payments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentTokenStatuses> PaymentTokenStatuses { get; set; }
    }
}
