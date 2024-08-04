namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipping.DriverCarTransportationCompanies")]
    public partial class DriverCarTransportationCompanies
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public int DriverId { get; set; }

        public int TransportationCompanyId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public byte RowStatusId { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual Cars Cars { get; set; }

        public virtual Drivers Drivers { get; set; }

        public virtual TransportationCompanies TransportationCompanies { get; set; }
    }
}
