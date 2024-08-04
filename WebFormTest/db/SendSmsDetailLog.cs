namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SMS.SendSmsDetailLog")]
    public partial class SendSmsDetailLog
    {
        public long Id { get; set; }

        public int ParentId { get; set; }

        [Required]
        [StringLength(50)]
        public string MobileNo { get; set; }

        public int Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public DateTime CreateDate { get; set; }

        public bool IsSuccess { get; set; }

        public virtual SendSmsMainLog SendSmsMainLog { get; set; }
    }
}
