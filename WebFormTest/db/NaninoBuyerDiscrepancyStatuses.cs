namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nanino.NaninoBuyerDiscrepancyStatuses")]
    public partial class NaninoBuyerDiscrepancyStatuses
    {
        public int Id { get; set; }

        public int NaninoBuyerDiscrepancyId { get; set; }

        public int DiscrepancyStatusId { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public bool IsLast { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual NaninoBuyerDiscrepancies NaninoBuyerDiscrepancies { get; set; }
    }
}
