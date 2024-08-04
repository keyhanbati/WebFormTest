namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pay.PaymentOperationDetails")]
    public partial class PaymentOperationDetails
    {
        public int Id { get; set; }

        public int PaymentOperationId { get; set; }

        public int PaymentOperationResultTypeId { get; set; }

        public string PaymentOperationResultValue { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual PaymentOperations PaymentOperations { get; set; }
    }
}
