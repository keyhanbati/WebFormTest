namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SMS.SendSmsMainLog")]
    public partial class SendSmsMainLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SendSmsMainLog()
        {
            SendSmsDetailLog = new HashSet<SendSmsDetailLog>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string MessagePattern { get; set; }

        [Required]
        [StringLength(400)]
        public string Filters { get; set; }

        [Required]
        [StringLength(200)]
        public string ReplacementClause { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SendSmsDetailLog> SendSmsDetailLog { get; set; }
    }
}
