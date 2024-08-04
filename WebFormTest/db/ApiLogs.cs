namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("acc.ApiLogs")]
    public partial class ApiLogs
    {
        public long Id { get; set; }

        [Required]
        public string ActionName { get; set; }

        [Required]
        public string Request { get; set; }

        [Required]
        public string Response { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
