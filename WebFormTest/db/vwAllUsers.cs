namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vwAllUsers
    {
        [Key]
        public int UserId { get; set; }

        public string FullName { get; set; }
    }
}
