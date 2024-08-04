namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log.Histories")]
    public partial class Histories
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RefrenceId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RefrenceTypeId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OperationTypeId { get; set; }

        [Key]
        [Column(Order = 4)]
        public string JsonData { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(15)]
        public string IPAddress { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string MachineName { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OperationUserId { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime OperationDate { get; set; }
    }
}
