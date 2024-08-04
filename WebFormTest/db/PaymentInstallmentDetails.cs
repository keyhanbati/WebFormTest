namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pay.PaymentInstallmentDetails")]
    public partial class PaymentInstallmentDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaymentInstallmentDetails()
        {
            Payments = new HashSet<Payments>();
        }

        public long Id { get; set; }

        public int BuyerId { get; set; }

        public long OrderId { get; set; }

        public int SalePlanInstallmentId { get; set; }

        [StringLength(500)]
        public string SalePlanInstallmentComment { get; set; }

        [Required]
        [StringLength(100)]
        public string SalePlanTitle { get; set; }

        public DateTime InstallmentDueDate { get; set; }

        public long InstallmentAmount { get; set; }

        public DateTime? PaidDate { get; set; }

        public DateTime? LastTryToPaid { get; set; }

        public int Sort { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? UpdateUserId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payments> Payments { get; set; }
    }
}
