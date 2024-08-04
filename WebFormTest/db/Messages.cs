namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Msg.Messages")]
    public partial class Messages
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Messages()
        {
            MessageReceivers = new HashSet<MessageReceivers>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Title { get; set; }

        public int MessageTypeId { get; set; }

        public int MessageSendTypeId { get; set; }

        public int ShowTypeId { get; set; }

        public int ReceiverTypeId { get; set; }

        public DateTime ShowStartDateTime { get; set; }

        public DateTime? ShowEndDateTime { get; set; }

        [Required]
        [StringLength(4000)]
        public string MessageText { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MessageReceivers> MessageReceivers { get; set; }
    }
}
