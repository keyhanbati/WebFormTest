namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nanino.NaninoBuyers")]
    public partial class NaninoBuyers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NaninoBuyers()
        {
            NaninoBuyerCookingTypes = new HashSet<NaninoBuyerCookingTypes>();
            NaninoBuyerPos = new HashSet<NaninoBuyerPos>();
        }

        public int Id { get; set; }

        public int? BuyerId { get; set; }

        [StringLength(20)]
        public string BuyerCode { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(13)]
        public string NationalCode { get; set; }

        public int ProvinceId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProvinceName { get; set; }

        [Required]
        [StringLength(50)]
        public string CityCode { get; set; }

        [StringLength(50)]
        public string CityName { get; set; }

        [StringLength(14)]
        public string Mobile { get; set; }

        [StringLength(14)]
        public string Tel { get; set; }

        [StringLength(10)]
        public string ZipCode { get; set; }

        public DateTime? MainInstallDate { get; set; }

        public DateTime? LastModifyDate { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        public int RowStatusId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual Buyers Buyers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NaninoBuyerCookingTypes> NaninoBuyerCookingTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NaninoBuyerPos> NaninoBuyerPos { get; set; }
    }
}
