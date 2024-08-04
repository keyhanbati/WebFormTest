namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShipmentInfoStatusItemsLog")]
    public partial class ShipmentInfoStatusItemsLog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long OrderCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ShipmentInfoCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string DriverNationalCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string CarCode { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string TransportationCompanyCode { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShipmentPackageCount { get; set; }

        [Key]
        [Column(Order = 6)]
        public double ShipmentWeight { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShipmentStatusTypeId { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime StatusUpdateDate { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(65)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime CreateDate { get; set; }
    }
}
