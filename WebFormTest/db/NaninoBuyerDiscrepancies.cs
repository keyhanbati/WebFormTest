namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nanino.NaninoBuyerDiscrepancies")]
    public partial class NaninoBuyerDiscrepancies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NaninoBuyerDiscrepancies()
        {
            NaninoBuyerDiscrepancyStatuses = new HashSet<NaninoBuyerDiscrepancyStatuses>();
        }

        public int Id { get; set; }

        public int BuyerId { get; set; }

        public int DiscrepancyStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public int? CookingTypeId { get; set; }

        public int? PatWeight { get; set; }

        public int? ConfirmPatWeight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NaninoBuyerDiscrepancyStatuses> NaninoBuyerDiscrepancyStatuses { get; set; }
    }
}
