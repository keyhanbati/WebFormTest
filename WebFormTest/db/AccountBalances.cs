namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("acc.AccountBalances")]
    public partial class AccountBalances
    {
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountNumber { get; set; }

        public decimal BalanceAmount { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
