namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Wheat.WheatImportInfos")]
    public partial class WheatImportInfos
    {
        public int Id { get; set; }

        public int WheatImportId { get; set; }

        public int? Code { get; set; }

        public string CreatedTime { get; set; }

        public string SolarDate { get; set; }

        public int? FirstCustomerCode { get; set; }

        public string FirstCustomerName { get; set; }

        [Required]
        public string GoodsCode { get; set; }

        public int? Name { get; set; }

        [StringLength(14)]
        public string NationalCode { get; set; }

        public int? UseTypeCode { get; set; }

        public int? Value { get; set; }

        public bool IsValid { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public long? OstanCode { get; set; }

        public string OstanName { get; set; }

        public string ValidationDescription { get; set; }

        public int? SellerId { get; set; }

        public virtual WheatImports WheatImports { get; set; }
    }
}
