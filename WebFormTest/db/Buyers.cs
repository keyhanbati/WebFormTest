namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer.Buyers")]
    public partial class Buyers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Buyers()
        {
            BuyerAgents = new HashSet<BuyerAgents>();
            BuyerBankCards = new HashSet<BuyerBankCards>();
            BuyerComments = new HashSet<BuyerComments>();
            BuyerConsumptionTypes = new HashSet<BuyerConsumptionTypes>();
            BuyerCookingTypes = new HashSet<BuyerCookingTypes>();
            BuyerDismissals = new HashSet<BuyerDismissals>();
            BuyerFacilities = new HashSet<BuyerFacilities>();
            BuyerGroupBuyers = new HashSet<BuyerGroupBuyers>();
            BuyerInfoCorrections = new HashSet<BuyerInfoCorrections>();
            BuyerMonths = new HashSet<BuyerMonths>();
            BuyerOwners = new HashSet<BuyerOwners>();
            BuyerPos = new HashSet<BuyerPos>();
            BuyerProductTemplates = new HashSet<BuyerProductTemplates>();
            BuyerPurchaseTypes = new HashSet<BuyerPurchaseTypes>();
            BranPercentageLimitations = new HashSet<BranPercentageLimitations>();
            BuyerReceiptLimitations = new HashSet<BuyerReceiptLimitations>();
            Buyers1 = new HashSet<Buyers>();
            Buyers11 = new HashSet<Buyers>();
            BuyerScores = new HashSet<BuyerScores>();
            BuyerStatuses = new HashSet<BuyerStatuses>();
            BuyerSubCountryDivisionIds = new HashSet<BuyerSubCountryDivisionIds>();
            BuyerTransportTypeLimitations = new HashSet<BuyerTransportTypeLimitations>();
            DealingLimitations = new HashSet<DealingLimitations>();
            FlourSalesDetails = new HashSet<FlourSalesDetails>();
            NaninoBuyers = new HashSet<NaninoBuyers>();
            Orders = new HashSet<Orders>();
            RawFlourDetailFileImportLogs = new HashSet<RawFlourDetailFileImportLogs>();
            TransportLimitations = new HashSet<TransportLimitations>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public int BuyerTypeId { get; set; }

        public int? BuyerSubTypeId { get; set; }

        public int UsageTypeId { get; set; }

        public int UsageSubTypeId { get; set; }

        public int? OrganizationId { get; set; }

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

        public int CreateUserId { get; set; }

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

        public int? FamilyMemberCount { get; set; }

        public int? DistributeParentBuyerId { get; set; }

        public int? RawFlourParentBuyerId { get; set; }

        public int? SellerParentId { get; set; }

        public int? ConfirmationCode { get; set; }

        public virtual CountryDivisions CountryDivisions { get; set; }

        public virtual Organizations Organizations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerAgents> BuyerAgents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerBankCards> BuyerBankCards { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerComments> BuyerComments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerConsumptionTypes> BuyerConsumptionTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerCookingTypes> BuyerCookingTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerDismissals> BuyerDismissals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerFacilities> BuyerFacilities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerGroupBuyers> BuyerGroupBuyers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerInfoCorrections> BuyerInfoCorrections { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerMonths> BuyerMonths { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerOwners> BuyerOwners { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerPos> BuyerPos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerProductTemplates> BuyerProductTemplates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerPurchaseTypes> BuyerPurchaseTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BranPercentageLimitations> BranPercentageLimitations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerReceiptLimitations> BuyerReceiptLimitations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buyers> Buyers1 { get; set; }

        public virtual Buyers Buyers2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buyers> Buyers11 { get; set; }

        public virtual Buyers Buyers3 { get; set; }

        public virtual Sellers Sellers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerScores> BuyerScores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerStatuses> BuyerStatuses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerSubCountryDivisionIds> BuyerSubCountryDivisionIds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerTransportTypeLimitations> BuyerTransportTypeLimitations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DealingLimitations> DealingLimitations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlourSalesDetails> FlourSalesDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NaninoBuyers> NaninoBuyers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RawFlourDetailFileImportLogs> RawFlourDetailFileImportLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportLimitations> TransportLimitations { get; set; }
    }
}
