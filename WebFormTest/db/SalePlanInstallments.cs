namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product.SalePlanInstallments")]
    public partial class SalePlanInstallments
    {
        public int Id { get; set; }

        public int SalePlanId { get; set; }

        public int InstallmentPercentage { get; set; }

        public int InstallmentDeadlineDays { get; set; }

        [StringLength(500)]
        public string Comments { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual SalesPlans SalesPlans { get; set; }
    }
}
