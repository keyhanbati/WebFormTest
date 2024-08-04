namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log.QuotaFileDetailsExportLog")]
    public partial class QuotaFileDetailsExportLog
    {
        public int ID { get; set; }

        public int frkQuotaFileHeaderId { get; set; }

        public int? File_ID { get; set; }

        public int? File_IntervalCode { get; set; }

        public int? File_ProductTemplateCode { get; set; }

        [StringLength(255)]
        public string File_PhaseCode { get; set; }

        public double? File_BranPercentageCode { get; set; }

        [StringLength(255)]
        public string File_CountyCode { get; set; }

        [StringLength(255)]
        public string File_CountyTitle { get; set; }

        public int? File_BuyerCode { get; set; }

        public int? File_BuyerId { get; set; }

        [StringLength(255)]
        public string File_BuyerTitle { get; set; }

        public int? File_QuotaAmount { get; set; }

        public string File_Comment { get; set; }

        public int? File_FlourSaleAmount { get; set; }

        public int? File_LastIntervalQoutaAmount { get; set; }

        public int? File_QoutaIncerase { get; set; }

        public int? File_SaleIncerase { get; set; }

        public int? File_Percent { get; set; }

        public int? File_DiffPercent { get; set; }

        [StringLength(255)]
        public string File_BuyerTypeTitle { get; set; }

        public int? File_QuotaDifference { get; set; }

        [StringLength(500)]
        public string File_BuyerCookingTypes { get; set; }

        [StringLength(255)]
        public string File_BuyerPerformanceGroup { get; set; }

        public int? File_BuyerPerformanceGoupsID { get; set; }

        public decimal? File_FunctionalPercent { get; set; }

        public double? File_FinalScore { get; set; }

        public short? File_MessageId { get; set; }

        public virtual QuotaFileHeaderExportLog QuotaFileHeaderExportLog { get; set; }
    }
}
