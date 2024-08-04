namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TempMessage")]
    public partial class TempMessage
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(500)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MessageTypeId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShowTypeId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceiverTypeId { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime ShowStartDateTime { get; set; }

        public DateTime? ShowEndDateTime { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(4000)]
        public string MessageText { get; set; }

        [Key]
        [Column(Order = 7)]
        public byte RowStatusId { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreateUserId { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? UpdateUserId { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MessageSendTypeId { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(200)]
        public string RowStatusTitle { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(200)]
        public string ShowTypeTitle { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(200)]
        public string ReceiverTypeTitle { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(200)]
        public string MessageTypeTitle { get; set; }

        public long? RowsCount { get; set; }
    }
}
