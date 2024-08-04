namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Units
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Units()
        {
            Payments = new HashSet<Payments>();
            Units1 = new HashSet<Units>();
        }

        [Key]
        public int UnitID { get; set; }

        public int UnitCode { get; set; }

        public byte UnitDigit { get; set; }

        public byte UnitType { get; set; }

        [Required]
        public string UnitName { get; set; }

        public int? ParentUnitID { get; set; }

        public DateTime? MergeDate { get; set; }

        public int? MergeToUnitID { get; set; }

        public bool IsVirtual { get; set; }

        public byte UnitStatus { get; set; }

        public int UnitFlag { get; set; }

        public DateTime? OpenningDate { get; set; }

        public int? UnitDegreeId { get; set; }

        public int BankID { get; set; }

        public virtual Banks Banks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payments> Payments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Units> Units1 { get; set; }

        public virtual Units Units2 { get; set; }
    }
}
