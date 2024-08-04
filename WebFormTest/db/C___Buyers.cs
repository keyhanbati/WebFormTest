namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.___Buyers")]
    public partial class C___Buyers
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Code { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BuyerTypeId { get; set; }

        public int? BuyerSubTypeId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UsageTypeId { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UsageSubTypeId { get; set; }

        public int? OrganizationId { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CountryDivisionId { get; set; }

        [StringLength(30)]
        public string BusinessLicense { get; set; }

        [StringLength(11)]
        public string Tel { get; set; }

        [StringLength(11)]
        public string Fax { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        public int? OwnershipStatusId { get; set; }

        [StringLength(11)]
        public string Bakery_ProducerCode { get; set; }

        [StringLength(10)]
        public string CortexCode { get; set; }

        [StringLength(13)]
        public string GasReceiptSubscriptionNo { get; set; }

        [StringLength(13)]
        public string ElectricityReceiptId { get; set; }

        public int? VerificationStatusId { get; set; }

        public int? VerifyingUserId { get; set; }

        public DateTime? VerifyingDate { get; set; }

        [StringLength(500)]
        public string Comments { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreateUserId { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(50)]
        public string ISICCoding { get; set; }

        [StringLength(100)]
        public string ISICName { get; set; }

        public int? NaninoBuyerCode { get; set; }

        public int? FirstQuota { get; set; }

        public int? AlternativeBuyerId { get; set; }

        public bool? ExclusiveBakery { get; set; }

        public bool? Is24HoursBakery { get; set; }

        public bool? NoInternetAccess { get; set; }

        public byte? FamilyMemberCount { get; set; }

        public int? DistributeParentBuyerId { get; set; }

        public int? RawFlourParentBuyerId { get; set; }

        public int? SellerParentId { get; set; }

        public int? ConfirmationCode { get; set; }
    }
}
