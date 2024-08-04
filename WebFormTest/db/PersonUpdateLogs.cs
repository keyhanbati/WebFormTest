namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.PersonUpdateLogs")]
    public partial class PersonUpdateLogs
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string LastName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(13)]
        public string NationalCode { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(14)]
        public string MobileNo { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LegalTypeId { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool Verification { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool Death { get; set; }

        [Key]
        [Column(Order = 8)]
        public byte RowStatusId { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreateUserId { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime CreateDate { get; set; }

        public int? Gender { get; set; }
    }
}
