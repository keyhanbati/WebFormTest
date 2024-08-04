namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.CountryDivisions")]
    public partial class CountryDivisions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CountryDivisions()
        {
            BranPercentageLimitations = new HashSet<BranPercentageLimitations>();
            BuyerReceiptLimitations = new HashSet<BuyerReceiptLimitations>();
            Buyers = new HashSet<Buyers>();
            BuyerSubCountryDivisionIds = new HashSet<BuyerSubCountryDivisionIds>();
            BuyerTransportTypeLimitations = new HashSet<BuyerTransportTypeLimitations>();
            CountryDivisions1 = new HashSet<CountryDivisions>();
            DealingAmountLimitations = new HashSet<DealingAmountLimitations>();
            DealingLimitations = new HashSet<DealingLimitations>();
            DealingLimitations1 = new HashSet<DealingLimitations>();
            DealingSeperateLimitations = new HashSet<DealingSeperateLimitations>();
            HolidayCalendarCountryDivisions = new HashSet<HolidayCalendarCountryDivisions>();
            OrganizationCountryDivisions = new HashSet<OrganizationCountryDivisions>();
            Phases = new HashSet<Phases>();
            PopulationInfo = new HashSet<PopulationInfo>();
            QuotaPhaseConfiguration = new HashSet<QuotaPhaseConfiguration>();
            Sellers = new HashSet<Sellers>();
            ShipmentCosts = new HashSet<ShipmentCosts>();
            ShipmentCosts1 = new HashSet<ShipmentCosts>();
            ShipmentCosts2 = new HashSet<ShipmentCosts>();
            ShipmentPlatforms = new HashSet<ShipmentPlatforms>();
            TransportationCompanies = new HashSet<TransportationCompanies>();
            TransportationCompanies1 = new HashSet<TransportationCompanies>();
            UserCountryDivisions = new HashSet<UserCountryDivisions>();
            Yeast = new HashSet<Yeast>();
            Yeast1 = new HashSet<Yeast>();
        }

        public int Id { get; set; }

        public int? ParentId { get; set; }

        public int CountryDivisionTypeId { get; set; }

        [Required]
        [StringLength(100)]
        public string Code { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BranPercentageLimitations> BranPercentageLimitations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerReceiptLimitations> BuyerReceiptLimitations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buyers> Buyers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerSubCountryDivisionIds> BuyerSubCountryDivisionIds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerTransportTypeLimitations> BuyerTransportTypeLimitations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CountryDivisions> CountryDivisions1 { get; set; }

        public virtual CountryDivisions CountryDivisions2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DealingAmountLimitations> DealingAmountLimitations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DealingLimitations> DealingLimitations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DealingLimitations> DealingLimitations1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DealingSeperateLimitations> DealingSeperateLimitations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HolidayCalendarCountryDivisions> HolidayCalendarCountryDivisions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationCountryDivisions> OrganizationCountryDivisions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phases> Phases { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PopulationInfo> PopulationInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuotaPhaseConfiguration> QuotaPhaseConfiguration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sellers> Sellers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipmentCosts> ShipmentCosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipmentCosts> ShipmentCosts1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipmentCosts> ShipmentCosts2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipmentPlatforms> ShipmentPlatforms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportationCompanies> TransportationCompanies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportationCompanies> TransportationCompanies1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserCountryDivisions> UserCountryDivisions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yeast> Yeast { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yeast> Yeast1 { get; set; }
    }
}
