namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.CarPlateLetters")]
    public partial class CarPlateLetters
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string CarPlateLetterName { get; set; }
    }
}
