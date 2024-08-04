namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Wheat.WheatImportLogs")]
    public partial class WheatImportLogs
    {
        public int Id { get; set; }

        public int WheatImportId { get; set; }

        public int LogTypeId { get; set; }

        public int LogDetailTypeId { get; set; }

        [Required]
        public string LogMessage { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual WheatImports WheatImports { get; set; }
    }
}
