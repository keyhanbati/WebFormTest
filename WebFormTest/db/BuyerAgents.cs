namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.BuyerAgents")]
    public partial class BuyerAgents
    {
        public int Id { get; set; }

        public int BuyerId { get; set; }

        public int PersonId { get; set; }

        public int AgentTypeId { get; set; }

        [Required]
        [StringLength(13)]
        public string MainAccount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DocumentDate { get; set; }

        [StringLength(20)]
        public string DocumentNo { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual Persons Persons { get; set; }

        public virtual Buyers Buyers { get; set; }
    }
}
