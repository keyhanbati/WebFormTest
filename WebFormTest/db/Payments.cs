namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pay.Payments")]
    public partial class Payments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Payments()
        {
            PaymentItems = new HashSet<PaymentItems>();
            PaymentOperations = new HashSet<PaymentOperations>();
            PaymentStatuses = new HashSet<PaymentStatuses>();
            PaymentToken = new HashSet<PaymentToken>();
        }

        public int Id { get; set; }

        public long OrderId { get; set; }

        public int PaymentMethodId { get; set; }

        public int? BankUnitId { get; set; }

        public long PaymentAmount { get; set; }

        public int RowStatusId { get; set; }

        [Required]
        [StringLength(20)]
        public string CreateUserIPAddress { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        [StringLength(20)]
        public string UpdateUserIPAddress { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public long? PaymentInstallmentDetailId { get; set; }

        public virtual Units Units { get; set; }

        public virtual Orders Orders { get; set; }

        public virtual PaymentInstallmentDetails PaymentInstallmentDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentItems> PaymentItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentOperations> PaymentOperations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentStatuses> PaymentStatuses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentToken> PaymentToken { get; set; }
    }
}
