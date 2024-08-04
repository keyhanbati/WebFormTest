namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vwUsers
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [StringLength(256)]
        public string UserName { get; set; }

        [StringLength(256)]
        public string NormalizedUserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public int? RoleId { get; set; }

        [StringLength(256)]
        public string RoleName { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [StringLength(256)]
        public string NormalizedEmail { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool EmailConfirmed { get; set; }

        public string PhoneNumber { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool PhoneNumberConfirmed { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool IsActive { get; set; }
    }
}
