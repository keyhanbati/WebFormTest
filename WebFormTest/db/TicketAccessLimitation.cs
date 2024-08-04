namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("System.TicketAccessLimitation")]
    public partial class TicketAccessLimitation
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string RoleTitle { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceiverTypeId { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool HasSendAccess { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool InterProvincialAccess { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RowStatusId { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreateUserId { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
