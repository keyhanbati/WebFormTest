namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipping.TransportationCompanies")]
    public partial class TransportationCompanies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransportationCompanies()
        {
            TransportLimitations = new HashSet<TransportLimitations>();
            DriverCarTransportationCompanies = new HashSet<DriverCarTransportationCompanies>();
            DriverTransportationCompanies = new HashSet<DriverTransportationCompanies>();
            ShipmentCosts = new HashSet<ShipmentCosts>();
            ShipmentInquiries = new HashSet<ShipmentInquiries>();
        }

        public int Id { get; set; }

        public int Code { get; set; }

        [Required]
        [StringLength(500)]
        public string Title { get; set; }

        [Required]
        [StringLength(14)]
        public string NationalId { get; set; }

        public int TransportationCompanyTypeId { get; set; }

        [StringLength(50)]
        public string Tel { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(50)]
        public string PostalCode { get; set; }

        public byte RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? UpdateUserId { get; set; }

        [Required]
        [StringLength(13)]
        public string IntermediateAccountNumber { get; set; }

        [Required]
        [StringLength(13)]
        public string MainAccountNumber { get; set; }

        public bool IsExternal { get; set; }

        public int ProvinceId { get; set; }

        public int? CountyId { get; set; }

        public int? CityId { get; set; }

        public int? VillageId { get; set; }

        public int? CenteralTransportationCompanyId { get; set; }

        public int? CentralTransportationCompanyId { get; set; }

        public int? ShipmentPlatformTypeId { get; set; }

        public virtual CountryDivisions CountryDivisions { get; set; }

        public virtual CountryDivisions CountryDivisions1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportLimitations> TransportLimitations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DriverCarTransportationCompanies> DriverCarTransportationCompanies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DriverTransportationCompanies> DriverTransportationCompanies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipmentCosts> ShipmentCosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipmentInquiries> ShipmentInquiries { get; set; }
    }
}
