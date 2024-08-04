namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nanino.NaninoCookingTypes")]
    public partial class NaninoCookingTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NaninoCookingTypes()
        {
            NaninoBuyerCookingTypes = new HashSet<NaninoBuyerCookingTypes>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CookingTypeTitle { get; set; }

        public int CookingTypeId { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NaninoBuyerCookingTypes> NaninoBuyerCookingTypes { get; set; }
    }
}
