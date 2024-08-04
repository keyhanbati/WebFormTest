namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log.ServiceLogs")]
    public partial class ServiceLogs
    {
        [Key]
        [Column(Order = 0)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServiceTypeId { get; set; }

        public int? MethodTypeId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string URL { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LogDetailTypeId { get; set; }

        public int? StatusCode { get; set; }

        public long? Duration { get; set; }

        [Column(TypeName = "ntext")]
        public string Request { get; set; }

        [Column(TypeName = "ntext")]
        public string SentData { get; set; }

        [Column(TypeName = "ntext")]
        public string Response { get; set; }

        [Column(TypeName = "ntext")]
        public string ReceivedData { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreateUserId { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime CreateDate { get; set; }
    }
}
