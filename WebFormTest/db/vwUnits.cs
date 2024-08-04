namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vwUnits
    {
        [Key]
        [Column(Order = 0)]
        public int UnitID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UnitCode { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte UnitType { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte UnitDigit { get; set; }

        [Key]
        [Column(Order = 4)]
        public string UnitName { get; set; }

        public int? ParentUnitID { get; set; }

        public DateTime? MergeDate { get; set; }

        public int? MergeToUnitID { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool IsVirtual { get; set; }

        [Key]
        [Column(Order = 6)]
        public byte UnitStatus { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UnitFlag { get; set; }

        public DateTime? OpenningDate { get; set; }

        public int? AccountingCode { get; set; }

        public int? UnitDegreeId { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BankID { get; set; }
    }
}
