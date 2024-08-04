namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log.JobLogs")]
    public partial class JobLogs
    {
        [Key]
        [Column(Order = 0)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string Username { get; set; }

        [Key]
        [Column(Order = 2)]
        public string JobName { get; set; }

        [Key]
        [Column(Order = 3)]
        public string MachinName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string IPAddress { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Status { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Duration { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime CreateDate { get; set; }
    }
}
