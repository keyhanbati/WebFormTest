namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Msg.MessageSendLogs")]
    public partial class MessageSendLogs
    {
        public int Id { get; set; }

        public int MessageReceiverId { get; set; }

        public int MessageSendStatusId { get; set; }

        public string LogMessage { get; set; }

        public bool IsLast { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual MessageReceivers MessageReceivers { get; set; }
    }
}
