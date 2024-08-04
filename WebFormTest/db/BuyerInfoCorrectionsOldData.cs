namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.BuyerInfoCorrectionsOldData")]
    public partial class BuyerInfoCorrectionsOldData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }

        [StringLength(13)]
        public string NationalCode { get; set; }

        [StringLength(14)]
        public string MobileNo { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(50)]
        public string ISICCoding { get; set; }

        [StringLength(11)]
        public string BakeryProducerCode { get; set; }

        [StringLength(30)]
        public string BusinessLicense { get; set; }
    }
}
