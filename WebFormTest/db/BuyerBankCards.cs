namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.BuyerBankCards")]
    public partial class BuyerBankCards
    {
        public int Id { get; set; }

        public int BuyerId { get; set; }

        public int BankId { get; set; }

        [Required]
        [StringLength(16)]
        public string BankCardNumber { get; set; }

        [StringLength(2)]
        public string Year { get; set; }

        [StringLength(2)]
        public string Month { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual Banks Banks { get; set; }

        public virtual Buyers Buyers { get; set; }
    }
}
