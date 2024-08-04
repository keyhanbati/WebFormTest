namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipping.DriverTransportationCompanies")]
    public partial class DriverTransportationCompanies
    {
        public int Id { get; set; }

        public int DriverId { get; set; }

        public int TransportationCompanyId { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual TransportationCompanies TransportationCompanies { get; set; }
    }
}
