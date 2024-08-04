namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Msg.MessageReceivers")]
    public partial class MessageReceivers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MessageReceivers()
        {
            MessageSendLogs = new HashSet<MessageSendLogs>();
        }

        public int Id { get; set; }

        public int MessageId { get; set; }

        public int UserId { get; set; }

        [StringLength(11)]
        public string PhoneNumber { get; set; }

        public int ViewStatusId { get; set; }

        public DateTime? SendDateTime { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual Messages Messages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MessageSendLogs> MessageSendLogs { get; set; }
    }
}
