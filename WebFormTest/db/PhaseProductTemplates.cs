namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.PhaseProductTemplates")]
    public partial class PhaseProductTemplates
    {
        public long Id { get; set; }

        public int PhaseId { get; set; }

        public int ProductTemplateId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual Phases Phases { get; set; }

        public virtual ProductTemplates ProductTemplates { get; set; }
    }
}
